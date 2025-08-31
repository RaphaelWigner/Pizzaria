using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Pizzaria.Program;



namespace Pizzaria
{


    public partial class Receitas : Form
    {
        private NivelAcesso nivelAcesso;
        private hisotooriicoo historicodadosprala;
        private Button BtnDel;
        private Button Salvar;
        public List<TableLayoutPanel> listareceita = new List<TableLayoutPanel>();
        public Receitas(hisotooriicoo historico, NivelAcesso nivelAcesso)
        {
            InitializeComponent();
            this.historicodadosprala = historico;
            this.FormClosing += Receitas_FormClosing;
            this.nivelAcesso = nivelAcesso;

            ConfigurarAcesso();

        }
        private void ConfigurarAcesso()
        {
            // Configura a interface com base no nível de acesso [TEMPLATE]
            switch (nivelAcesso)
            {
                case NivelAcesso.Visualizador:
                    button1.Enabled = false;
                    button3.Enabled = false;
                    adicionarpizza.Enabled = false;
                    break;
                case NivelAcesso.Funcionario:
                    button1.Enabled = true;
                    button3.Enabled = true;
                    adicionarpizza.Enabled = true;
                    break;
                case NivelAcesso.Administrador:
                    button1.Enabled = true;
                    button3.Enabled = true;
                    adicionarpizza.Enabled = true;
                    break;
            }
        }

        private void Receitas_Load(object sender, EventArgs e)
        {

        }
        private void Receitas_FormClosing(object sender, FormClosingEventArgs e) // impedir um bugzao
        {
            e.Cancel = true;
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (CriarReceita fazernovapizza = new CriarReceita())
            {
                if (fazernovapizza.ShowDialog() == DialogResult.OK)
                {
                    string funcao = adicionarpizza.Text; // Captura o texto do botão como função
                    string descricao = fazernovapizza.nomepizzac; // Nome da pizza para a descrição

                    if (historicodadosprala != null)
                    {
                        historicodadosprala.AdicionarRegistro(funcao, descricao);
                    }

                    CriarPainel(fazernovapizza.nomepizzac, fazernovapizza.ingredientesc);
                }
            }
        }
        public void CriarPainel(string nomepizzac, string ingredientesc)


        {
            TableLayoutPanel receita = new TableLayoutPanel();
            receita.Size = new Size(405, 261);
            receita.Name = "pizzacc";
            receita.BackColor = Color.Silver;
            receita.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            receita.ForeColor = Color.Red;
            receita.ColumnCount = 1;
            receita.RowCount = 3;
            receita.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));
            receita.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            receita.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            receita.Location = new Point(100, 100);
            this.Controls.Add(receita);
            receita.BringToFront();

            TextBox Nomepizza = new TextBox();
            Nomepizza.Name = nomepizzac;
            Nomepizza.Text = nomepizzac;
            Nomepizza.BringToFront();
            receita.Controls.Add(Nomepizza, 0, 0);
            Nomepizza.Location = new Point(103, 52);
            Nomepizza.Size = new Size(397, 40);
            Nomepizza.BackColor = Color.LightGray;
            Nomepizza.ForeColor = Color.Red;
            Nomepizza.BorderStyle = BorderStyle.Fixed3D;
            Nomepizza.Multiline = true;

            TextBox Ingredientes = new TextBox();
            Ingredientes.Location = new Point(203, 32);
            Ingredientes.Name = ingredientesc;
            Ingredientes.Text = ingredientesc;
            Ingredientes.BackColor = Color.LightGray;
            Ingredientes.ForeColor = Color.Red;
            Ingredientes.BorderStyle = BorderStyle.Fixed3D;
            Ingredientes.BringToFront();
            Ingredientes.Multiline = true;
            Ingredientes.Size = new Size(397, 206);
            receita.Controls.Add(Ingredientes, 0, 1);

            // Parte da formula para posição da nova label para o lado direito
            int x = listareceita.Count * 500;
            receita.Location = new Point(x, 80);
            listareceita.Add(receita);
            receita.BringToFront();

            BtnDel = new Button
            {
                BackColor = Color.LightGray,
                ForeColor = Color.Red,
                Text = "Deletar",
            };
            BtnDel.Click += (s, e) =>
            {
                this.Controls.Remove(receita);
                listareceita.Remove(receita);
                receita.Dispose();
            };
            receita.Controls.Add(BtnDel);
        }


        /* Salvar = new Button
         {
             BackColor = Color.LightGray,
             ForeColor = Color.LightGreen,
             Text = "Deletar",
         };
         receita.Controls.Add(Salvar);*/


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void SalvarReceitas() // Codigo para salvar o arquivo, mesma coisa que no estoque
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Arquivo de texto (*.txt)|*.txt",
                Title = "Salvar relatório de receitas",
                FileName = "ReceitasSalvas.txt"
            };
            string caminhoArquivo = saveFileDialog.FileName;
            using (StreamWriter writer = new StreamWriter(caminhoArquivo, false))
            {
                writer.WriteLine($"Receitas salvas {DateTime.Now:dd/MM/yyyy}");
                writer.WriteLine("=========");
                writer.WriteLine("=========\n");
                foreach (var receita in listareceita)
                {
                    TextBox nomePizza = receita.Controls[0] as TextBox;
                    TextBox ingredientesPizza = receita.Controls[1] as TextBox;

                    if (nomePizza != null && ingredientesPizza != null)
                    {
                        writer.WriteLine($"Nome da receita: {nomePizza.Text}");
                        writer.WriteLine($"Descrição da receita:\n{ingredientesPizza.Text}");
                        writer.WriteLine("========");
                        writer.WriteLine("========\n");
                    }
                }

                writer.WriteLine("Concluído com sucesso!");
            }

            MessageBox.Show("Receitas salvas com sucesso em 'ReceitasSalvas.txt'", "Salvar Receitas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void SalvarReceitasCSV()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Arquivo CSV (.csv)|.csv",
                Title = "Salvar Receitas em CSV",
                FileName = "Receitas.csv"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName, false, Encoding.UTF8))
                    {
                        // Escreve cabeçalho
                        writer.WriteLine("Nome da Pizza;Ingredientes");

                        // Itera sobre as receitas e escreve nome e ingredientes
                        foreach (var receita in listareceita)
                        {
                            TextBox nomePizza = receita.Controls[0] as TextBox;
                            TextBox ingredientesPizza = receita.Controls[1] as TextBox;

                            if (nomePizza != null && ingredientesPizza != null)
                            {
                                string linha = $"{nomePizza.Text};{ingredientesPizza.Text.Replace("\n", " ")}";
                                writer.WriteLine(linha);
                            }
                        }
                    }

                    MessageBox.Show("Receitas salvas com sucesso em formato CSV!", "Salvar Receitas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao salvar o arquivo CSV: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SalvarReceitas();

            string funcao = button1.Text;
            string descricao = "Criar Receita TXT";
            historicodadosprala.AdicionarRegistro(funcao, descricao);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SalvarReceitasCSV();


            string funcao = button3.Text;
            string descricao = "Criar Receita CSV";
            historicodadosprala.AdicionarRegistro(funcao, descricao);
        }

    }
}
