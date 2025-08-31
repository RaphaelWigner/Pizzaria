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
    public partial class Cliente : Form
    {
        public Receitas ReceitasDadosParaca; // Para acessar as receitas salvas no form Receitas
        private List<string> nomesUsuarios = new List<string> { "João", "Maria", "Lucas", "Ana", "Carlos" };
        private Random random = new Random();
        public DataGridView dataGridViewAcesso;
        public Cliente(Receitas ReceitasDadosV2)
        {
            InitializeComponent();
            // timer1.Start();
            this.ReceitasDadosParaca = ReceitasDadosV2;
            dataGridViewAcesso = dataGridView1;
            timer1.Interval = 5000; // 5 segundos (ajuste conforme necessário)
            timer1.Tick += Timer1_Tick;
            timer1.Start();

            this.FormClosing += Cliente_FormClosing;
        }
        private void Cliente_FormClosing(object sender, FormClosingEventArgs e) // impedir um bugzao
        {
            e.Cancel = true;
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            // Verifique se nomesUsuarios não está vazio
            if (nomesUsuarios.Count == 0)
            {
                return;
            }

            // Verifique se listareceita não está vazio
            if (ReceitasDadosParaca.listareceita.Count == 0)
            {
                return;
            }

            int id = dataGridView1.Rows.Count + 1;
            string nomeUsuario = nomesUsuarios[random.Next(nomesUsuarios.Count)];
            TableLayoutPanel receitaAleatoria = ReceitasDadosParaca.listareceita[random.Next(ReceitasDadosParaca.listareceita.Count)];

            // Verifique se receitaAleatoria possui os controles necessários
            if (receitaAleatoria.Controls.Count < 2)
            {
                MessageBox.Show("A receita selecionada não possui os controles esperados. Verifique a criação das receitas.");
                return;
            }

            string nomePizza = receitaAleatoria.Controls[0].Text;
            string descricaoPizza = receitaAleatoria.Controls[1].Text;
            string horarioPedido = DateTime.Now.ToString("HH:mm:ss");
            string porte = random.Next(1, 4) switch
            {
                1 => "Pequeno",
                2 => "Médio",
                _ => "Grande"
            };
            string nomePedido = $"{nomePizza} {porte}";

            // Adicionando um novo pedido no DataGridView
            dataGridView1.Rows.Add(id, nomeUsuario, nomePedido, DateTime.Now.ToString("dd/MM/yyyy"), horarioPedido);

            // Registrar o histórico de pedido
            RegistrarHistorico("PEDIDOS", nomePedido, DateTime.Now);
        }
        private void RegistrarHistorico(string funcao, string descricao, DateTime data)
        {
            // Adicionando uma nova entrada no histórico
           // hisotooriicoo.AdicionarHistorico(funcao, descricao, data);
        }
    }
}
