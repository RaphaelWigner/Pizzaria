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
    public partial class hisotooriicoo : Form
    {
        private NivelAcesso nivelAcesso;
        private int id = 1;
        CriarReceita Receitadados;
        Estoque EstoqueDados;
        pedidos PedidosDados;
        Cliente CleinteDados;
        Receitas ReceitasMensagemDados;

        public hisotooriicoo(Receitas receitadadus, Estoque TrazerDados, pedidos TrazerDadosPedidos, NivelAcesso nivelAcesso)
        {
            InitializeComponent();

            
            this.nivelAcesso = nivelAcesso;
            ReceitasMensagemDados = receitadadus;
            EstoqueDados = TrazerDados;
            PedidosDados = TrazerDadosPedidos;

            ConfigurarAcesso();

            if (dataGridView1.Columns.Count == 0)
            {
                dataGridView1.Columns.Add("ID", "ID");
                dataGridView1.Columns.Add("Função", "Função");
                dataGridView1.Columns.Add("Descrição", "Descrição");
                dataGridView1.Columns.Add("Data", "Data");
                dataGridView1.Columns.Add("Hora", "Hora");


                this.ReceitasMensagemDados = receitadadus;
                this.EstoqueDados = TrazerDados;
                this.PedidosDados = TrazerDadosPedidos;

                this.FormClosing += hisotooriicoo_FormClosing;
            }
        }
        private void ConfigurarAcesso()
        {
            // Configura a interface com base no nível de acesso [TEMPLATE]
            switch (nivelAcesso)
            {
                case NivelAcesso.Visualizador:
                    button1.Enabled = false;
                    button2.Enabled = false;
                    break;
                case NivelAcesso.Funcionario:
                    button1.Enabled = true;
                    button2.Enabled = true;
                    break;
                case NivelAcesso.Administrador:
                    button1.Enabled = true;
                    button2.Enabled = true;
                    break;
            }
        }
        private void hisotooriicoo_FormClosing(object sender, FormClosingEventArgs e) // impedir um bugzao
        {
            e.Cancel = true;
            this.Hide();
        }

        private void hisotooriicoo_Load(object sender, EventArgs e)
        {

        }
        public void AdicionarRegistro(string funcao, string descricao)
        {
            // Adiciona uma linha ao DataGridView e força a atualização visual
            dataGridView1.Rows.Add(
                id++,
                funcao,
                descricao,
                DateTime.Now.ToString("dd/MM/yyyy"),
                DateTime.Now.ToString("HH:mm:ss")
            );
            dataGridView1.Refresh();
        }

        public void SalvarEmTxt()            // TEMPLATE PARA SALVAR ARQUVIOS NO COMPUTADOR
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Files|*.txt", FileName = "historico.txt" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName))
                    {
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            var linha = string.Join(" | ", row.Cells.Cast<DataGridViewCell>().Select(cell => cell.Value?.ToString()));
                            sw.WriteLine(linha);
                        }
                    }
                    MessageBox.Show("Dados salvos em TXT com sucesso.");
                }
            }
        }


        private void SalvarDadosHistorico()
        {

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "CSV file (*.csv)|*.csv";
                saveFileDialog.Title = "Salvar Histórico";
                saveFileDialog.FileName = "historico.csv";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {

                        ExportarDataGridViewParaCSV(saveFileDialog.FileName);
                        MessageBox.Show("Dados salvos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao salvar o arquivo: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void ExportarDataGridViewParaCSV(string caminhoArquivo)
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
                        .Select(cell => cell.Value?.ToString().Trim() ?? "") 
                        .ToArray();


                    if (valores.Any(val => !string.IsNullOrEmpty(val)))
                    {
                        sb.AppendLine(string.Join(";", valores));
                    }
                }
            }

            File.WriteAllText(caminhoArquivo, sb.ToString(), Encoding.UTF8);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SalvarEmTxt();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SalvarDadosHistorico();
        }
    }
}
