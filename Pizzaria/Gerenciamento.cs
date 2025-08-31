using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Estoque, Receitas, Pedidos, Análise
/* Geral;
 * - Notificação de quando o estoque chegar o seu limite minimo e maximo
 * - Notificação de baixo estoque
 * Estoque;
 * - Tempo de validade dos produtos
 * - Data que chegaram
 * - Visualização do ingredientes
 * - Exportação de dados para um arquivo
 * - Exportação de dados para uma planinha
 * - Sistema de quantia media de pizzas que podem ser feitas pelos ingredientes
 * - Fazer um montante total na venda
 * Receitas;
 * - Mostrar as receitas das pizzas,
 * - Exportas receitas para arquivos e planilhas
 * - Sistema de anotação de cardápio, salvar no codigo e planinha
   - Sistema e quando o usuario salvar os ingrediantes e a tal pizza, vai ir para o estoque e vai poder adicionar essa pizza no estoque se quiser e ver o montante
   Pedidos;
    - Seleção de ingredientes e o custo final
    - Possivel data que vai chegar
    - Atualizar o estoque
    - Talvez calculo de distacia e tempo, tacar no montante? nao sei
    - Exportação de historico de pedidos
    Análise;
    - Sistema que indica quais ingredientes estão sendo mais consumidos, baseados em pontos, se x tomates foram consumidos, tomates ganhará x pontos
    assim em uma leaderboard de ingredientes
    - Exportação dessa análise (gráfico, arquivo)*/

namespace Pizzaria
{
    public partial class Gerenciamento : Form
    {

        private NivelAcesso nivelAcesso;
        private static Estoque eistoque;
        private static Cliente client;
        private static hisotooriicoo historicodadosprala;
        private Receitas ReceitasDadosV2;
        private pedidos DadosPedidos;


        public Gerenciamento(NivelAcesso nivelAcesso)
        {
            InitializeComponent();
            this.nivelAcesso = nivelAcesso;

            historicodadosprala = new hisotooriicoo(null, eistoque, DadosPedidos, nivelAcesso);
            eistoque = new Estoque(historicodadosprala, nivelAcesso);
            ReceitasDadosV2 = new Receitas(historicodadosprala, nivelAcesso);
            DadosPedidos = new pedidos(eistoque, historicodadosprala, nivelAcesso);
            client = new Cliente(ReceitasDadosV2);

            ConfigurarAcesso();

        }
        private void ConfigurarAcesso()
        {
            // Configura a interface com base no nível de acesso [TEMPLATE]
            switch (nivelAcesso)
            {
                case NivelAcesso.Visualizador:
                    buttonEditar.Enabled = false; 
                    button5.Enabled = false;
                    break;
                case NivelAcesso.Funcionario:
                    buttonEditar.Enabled = true;
                    button5.Enabled = false;
                    break;
                case NivelAcesso.Administrador:
                    buttonEditar.Enabled = true;
                    button5.Enabled = true;
                    break;
            }
        }
        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (nivelAcesso == NivelAcesso.Visualizador)
            {
                MessageBox.Show("Você não tem permissão para editar.", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Modo Edição");
            }
        }
        private void buttonAdministrar_Click(object sender, EventArgs e)
        {
            if (nivelAcesso == NivelAcesso.Administrador)
            {
                MessageBox.Show("Modo Administrador");
            }
            else
            {
                MessageBox.Show("Acesso negado.", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void buttonVisualizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Modo Visualização");
        }
        private void Gerenciamento_Load(object sender, EventArgs e)
        {
            historicodadosprala.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DadosPedidos.IsDisposed) //codigo para ver se resolve o problema
            {
                DadosPedidos = new pedidos(eistoque, historicodadosprala, nivelAcesso);
            }
            else
            {
                MessageBox.Show("Abrindo...");
            }

            DadosPedidos.Show();
            DadosPedidos.BringToFront();
        }

        private void ReceitaButao_Click(object sender, EventArgs e)
        {
            {
                ReceitasDadosV2.Show();
            }
        }
        private void Duvida_Click(object sender, EventArgs e)
        {
            MessageBox.Show("W.I.P");
        }

        private void Estoquebutao_Click(object sender, EventArgs e)
        {
            if (eistoque.IsDisposed)
            {
                eistoque = new Estoque(historicodadosprala, nivelAcesso);
            }

            eistoque.Show();
            eistoque.BringToFront();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            client.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (historicodadosprala.IsDisposed) //codigo para ver se resolve o problema
            {
                historicodadosprala = new hisotooriicoo(ReceitasDadosV2, eistoque, DadosPedidos, nivelAcesso);
            }
            else
            {
                MessageBox.Show("Carregando...");
            }

            historicodadosprala.Show();
            historicodadosprala.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if ( nivelAcesso == NivelAcesso.Administrador)
            {
                Administracao Acesso = new Administracao(nivelAcesso);
                Acesso.Show();
            }
        }

        private void buttonEditar_Click_1(object sender, EventArgs e)
        {
            if ( nivelAcesso == NivelAcesso.Visualizador)
            {
                MessageBox.Show("Você não tem acesso");
            }
        }
    }
}
