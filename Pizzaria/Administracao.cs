using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria
{
    public partial class Administracao : Form
    {
        private NivelAcesso nivelAcesso;
        public Administracao(NivelAcesso nivelAcesso)
        {
            InitializeComponent();
            this.nivelAcesso = nivelAcesso;

        }

        private void Administracao_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)                 //Bloco de codigo para adicionar baseado nas varievais
        {
            string funcao = comboBox1.SelectedItem?.ToString();
            string email = textBox1.Text;
            string nome = textBox2.Text;
            string dataAtual = DateTime.Now.ToString("dd/MM/yyyy");

            if (string.IsNullOrEmpty(funcao) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("Preencha os campos em brancos");
                return;
            }

            dataGridView1.Rows.Add(funcao, email, nome, dataAtual);            //Bloco de codigo para adicionar baseado nas varievais
        }
        private void SalvarComoCSV()                                           // Aqui para baixo sao os metodos para salvar em CSV e em txt
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "CSV file (*.csv)|*.csv";
                saveFileDialog.Title = "Salvar em CSV";
                saveFileDialog.FileName = "dados.csv";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StringBuilder sb = new StringBuilder();
                    string[] nomesColunas = dataGridView1.Columns
                        .Cast<DataGridViewColumn>()
                        .Select(column => column.HeaderText)
                        .ToArray();
                    sb.AppendLine(string.Join(";", nomesColunas));
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            string[] valores = row.Cells
                                .Cast<DataGridViewCell>()
                                .Select(cell => cell.Value?.ToString() ?? "")
                                .ToArray();
                            sb.AppendLine(string.Join(";", valores));
                        }
                    }
                    File.WriteAllText(saveFileDialog.FileName, sb.ToString(), Encoding.UTF8);
                    MessageBox.Show("Dados salvos em CSV com sucesso.");
                }
            }
        }

        private void SalvarComoTxt()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
                saveFileDialog.Title = "Salvar em TXT";
                saveFileDialog.FileName = "dados.txt";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                    {
                        string header = string.Join(" | ", dataGridView1.Columns
                            .Cast<DataGridViewColumn>()
                            .Select(column => column.HeaderText));
                        sw.WriteLine(header);
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                string linha = string.Join(" | ", row.Cells
                                    .Cast<DataGridViewCell>()
                                    .Select(cell => cell.Value?.ToString() ?? ""));
                                sw.WriteLine(linha);
                            }
                        }
                    }
                    MessageBox.Show("Dados salvos em TXT com sucesso.");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SalvarComoCSV();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SalvarComoTxt();
        }
    }
}
