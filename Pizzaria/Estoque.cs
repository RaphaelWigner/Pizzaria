using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria
{
    public partial class Estoque : Form
    {
        private NivelAcesso nivelAcesso;
        private hisotooriicoo historicodadosprala;
        private Label lblStatusEstoque;
        public Estoque(hisotooriicoo historico, NivelAcesso nivelAcesso)
        {
            InitializeComponent();
            AdicionarStatusEstoqueLabel();
            this.historicodadosprala = historico;
            this.nivelAcesso = nivelAcesso;
            this.FormClosing += Estoque_FormClosing; // shit is going on here

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
                    button2.Enabled = false;
                    button5.Enabled = false;
                    button5.Enabled = false;
                    button4.Enabled = false;
                    break;
                case NivelAcesso.Funcionario:
                    button1.Enabled = true;
                    button3.Enabled = true;
                    button2.Enabled = true;
                    button5.Enabled = true;
                    button5.Enabled = true;
                    button4.Enabled = true;
                    break;
                case NivelAcesso.Administrador:
                    button1.Enabled = true;
                    button3.Enabled = true;
                    button2.Enabled = true;
                    button5.Enabled = true;
                    button5.Enabled = true;
                    button4.Enabled = true;
                    break;
            }
        }
        private void Estoque_Load(object sender, EventArgs e)
        {
            VerificarEstoque();
        }
        private void Estoque_FormClosing(object sender, FormClosingEventArgs e) // impedir um bugzao
        {
            e.Cancel = true;
            this.Hide();
        }

        private void AdicionarStatusEstoqueLabel() // label de aviso
        {
            lblStatusEstoque = new Label
            {
                Location = new Point(501, 201),
                Size = new Size(200, 30),
                Font = new Font("Arial", 12, FontStyle.Bold),
                ForeColor = Color.DarkRed,
                BackColor = Color.Yellow,
                Visible = false
            };
            Controls.Add(lblStatusEstoque);
            lblStatusEstoque.BringToFront();
        }

        private void VerificarEstoque() // codigo para fazer a função de verificação do estoque
        {
            double totalKg = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["KG"].Value != null)
                {
                    string kgText = row.Cells["KG"].Value.ToString().Replace(" kg", ""); // calculo 
                    if (double.TryParse(kgText, out double kgValue))
                    {
                        totalKg += kgValue;
                    }
                }
            }

            if (totalKg > 1000) // if para aviso de estoque
            {
                lblStatusEstoque.Text = "Estoque está cheio";
                lblStatusEstoque.Visible = true;
                MessageBox.Show("O estoque está cheio! Não é possível adicionar mais.", "Aviso de Estoque Cheio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (totalKg < 100)
            {
                lblStatusEstoque.Text = "Estoque está vazio";
                lblStatusEstoque.Visible = true;
                MessageBox.Show("O estoque está baixo! Por favor, reabasteça.", "Aviso de Estoque Baixo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                lblStatusEstoque.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdicionarIngredientenoEstoque(string nomeingrediente) // Codigo para adicionar Ingrediente Novo ao estoque
        {
            VerificarEstoque();
            {
                int quantidade;
                if (!int.TryParse(textBox2.Text, out quantidade) || quantidade <= 0)
                {
                    MessageBox.Show("Por favor, insira uma quantidade válida.", "Erro");
                    return;
                }
                bool ingredienteEncontrado = false;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["Nome"].Value?.ToString() == nomeingrediente)
                    {
                        int quantidadeAtual = Convert.ToInt32(row.Cells["KG"].Value);
                        row.Cells["KG"].Value = quantidadeAtual + quantidade;
                        ingredienteEncontrado = true;
                        break;
                    }
                }

                if (!ingredienteEncontrado)
                {
                    int rowIndex = dataGridView1.Rows.Add();
                    dataGridView1.Rows[rowIndex].Cells["Nome"].Value = textBox1.Text;
                    dataGridView1.Rows[rowIndex].Cells["KG"].Value = quantidade;
                    dataGridView1.Rows[rowIndex].Cells["datadevalidade"].Value = DateTime.Now.AddDays(30).ToShortDateString();
                    dataGridView1.Rows[rowIndex].Cells["datadechegada"].Value = DateTime.Now.ToShortDateString();
                }
            }
        }// Codigo para adicionar Ingrediente Novo ao estoque


        private void button1_Click_1(object sender, EventArgs e) // esse é o butao que faz a função da criaçao do novo ingrediente
        {
            string nomeingrediente = textBox1.Text.Trim();
            if (!string.IsNullOrEmpty(nomeingrediente))
            {
                AdicionarIngredientenoEstoque(nomeingrediente);

                string funcao = button1.Text;
                string descricao = nomeingrediente;

                historicodadosprala.AdicionarRegistro(funcao, descricao);
                textBox1.Clear();
            }
        }

        private void AdicionarIngredientenoEstoqueComPeso(string nomeingrediente, string pesoSelecionadoTexto, int quantidade) //Funçao do peso, caso nao tiver um peso valido vai dar um erro
        {
            VerificarEstoque();
            double pesoSelecionado;
            switch (pesoSelecionadoTexto)
            {
                case "250g":
                    pesoSelecionado = 0.25;
                    break;
                case "1 kg":
                    pesoSelecionado = 1.0;
                    break;
                case "25 kg":
                    pesoSelecionado = 25.0;
                    break;
                default:
                    MessageBox.Show("Selecione um peso válido.", "Erro");
                    return;
            }

            // Resto do código para adicionar ao estoque
            double quantidadeTotalKg = pesoSelecionado * quantidade;
            bool ingredienteEncontrado = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Nome"].Value?.ToString() == nomeingrediente)
                {
                    double quantidadeAtualKg = Convert.ToDouble(row.Cells["KG"].Value.ToString().Replace(" kg", ""));
                    row.Cells["KG"].Value = (quantidadeAtualKg + quantidadeTotalKg).ToString("0.###") + " kg";
                    ingredienteEncontrado = true;
                    break;
                }
            }

            if (!ingredienteEncontrado)
            {
                int rowIndex = dataGridView1.Rows.Add();
                dataGridView1.Rows[rowIndex].Cells["Nome"].Value = nomeingrediente;
                dataGridView1.Rows[rowIndex].Cells["KG"].Value = quantidadeTotalKg.ToString("0.###") + " kg";
                dataGridView1.Rows[rowIndex].Cells["datadechegada"].Value = DateTime.Now.ToShortDateString();
                dataGridView1.Rows[rowIndex].Cells["datadevalidade"].Value = DateTime.Now.AddDays(30).ToShortDateString();
            }

            dataGridView1.Refresh();
        }// Resto do código para adicionar ao estoque



        // Codigo para receber informações de pedidos e colocar aqui no estoque 

        public void AdicionaringredienteBaseadopedido(string nomeProduto, string pesoSelecionadoTexto, int quantidade, DateTime datadechegada, DateTime datadevalidade)
        {
            AdicionarIngredientenoEstoqueComPeso(nomeProduto, pesoSelecionadoTexto, quantidade);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VerificarEstoque();
            Controls.Add(panel1);
            string funcao = button2.Text;
            string descricao = button2.Text;
            historicodadosprala.AdicionarRegistro(funcao, descricao);
        }

        private void button3_Click(object sender, EventArgs e) // codigo para remoção de ingrediente
        {
            string nomeIngrediente = Microsoft.VisualBasic.Interaction.InputBox("Digite o nome do ingrediente a remover:", "Remover Ingrediente"); // coisa interessante que eu nao sabia, da para colocar essa inputbox para receber um input do usuario e fazer algo, nao precisando de uma textbox no programa

            if (!string.IsNullOrEmpty(nomeIngrediente))
            {
                RemoverIngrediente(nomeIngrediente);


                string funcao = button3.Text;
                string descricao = nomeIngrediente;

                historicodadosprala.AdicionarRegistro(funcao, descricao);
            }
            else
            {
                MessageBox.Show("Nome do ingrediente não pode estar vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void RemoverIngrediente(string nomeIngrediente)
        {
            bool ingredienteEncontrado = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Nome"].Value != null && row.Cells["Nome"].Value.ToString().Equals(nomeIngrediente, StringComparison.OrdinalIgnoreCase))
                {
                    dataGridView1.Rows.Remove(row);
                    ingredienteEncontrado = true;
                    break;
                }
            } // codigo para remoção de ingrediente
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SalvarEmTxt();
            Controls.Add(panel1);
            string funcao = button4.Text;
            string descricao = "Estoque";

            historicodadosprala.AdicionarRegistro(funcao, descricao);
        }
        public void SalvarEmTxt()            // TEMPLATE PARA SALVAR ARQUVIOS NO COMPUTADOR
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Files|*.txt", FileName = "Estoque.txt" })
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
                saveFileDialog.FileName = "Estoque.csv";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        SalvarCSV(saveFileDialog.FileName);
                        MessageBox.Show("Dados salvos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao salvar o arquivo: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void SalvarCSV(string caminhoArquivo)
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

        private void button5_Click(object sender, EventArgs e)
        {
            SalvarDadosHistorico();
            string funcao = button5.Text;
            string descricao = "Estoque";

            historicodadosprala.AdicionarRegistro(funcao, descricao);
        }
    }
}
