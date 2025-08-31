using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Ter um butao para adicionar o nome da pizza
// ter um butao para adicionar ingredientes, quando voce aperta esse butao, vai aparecer uma nova caixinha de baixo do painel, esse ingrediente vai ser salvo em estoque
// ter uma lista disponivel para adicionar ingredientes
// salvar essas informaçoes e colocar no fazer pizza no estoque

namespace Pizzaria
{
    public partial class CriarReceita : Form
    {

        public string nomepizzac { get; private set; }
        public string ingredientesc { get; private set; }

        public CriarReceita()
        {
            InitializeComponent();
        }

        private void CriarReceita_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            nomepizzac = fazerpizza1.Text;
            ingredientesc = ingredientespizza1.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private TextBox fazerpizza1;
        private Button finalizarpizza;
        private Label label1;
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void label2_Click_2(object sender, EventArgs e)
        {

        }
    }
}
