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
    public partial class Analise : Form
    {

        private Cliente AnaliseDadosCliente;

        public Analise(Cliente cliente)
        {
            InitializeComponent();
            this.AnaliseDadosCliente = cliente;

            analiseTimer.Interval = 300000;
            analiseTimer.Tick += AnaliseTimer_Tick;
            analiseTimer.Start();

            AtualizarRelatorio();
        }
        private void AnaliseTimer_Tick(object sender, EventArgs e)
        {
            AtualizarRelatorio();
        }
        public void AtualizarRelatorio()
        {
            var pedidos = new List<string>();
            foreach (DataGridViewRow row in AnaliseDadosCliente.dataGridViewAcesso.Rows)
            {
                if (row.Cells[2].Value != null)
                {
                    pedidos.Add(row.Cells[2].Value.ToString());
                }
            }

            var maisComprados = pedidos
                .GroupBy(p => p)
                .OrderByDescending(g => g.Count())
                .Select(g => new { Pizza = g.Key, Quantidade = g.Count() })
                .ToList();

            dataGridViewAnalise.Rows.Clear();
            foreach (var item in maisComprados)
            {
                dataGridViewAnalise.Rows.Add(item.Pizza, item.Quantidade);
            }
        }

        private void Analise_Load(object sender, EventArgs e)
        {

        }
    }
}
