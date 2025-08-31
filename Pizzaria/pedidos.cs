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
    public partial class pedidos : Form
    {
        // Varievais da interface da compra
        public Panel produtoPanel;
        public Label lblNomeProduto;
        public Label lblDescricaoProduto;
        public Label lblPreco;
        public Label lblMetodoPagamento;
        public ComboBox cbVolume;
        public TextBox txtQuantidade;
        public Button btnComprar;
        public Button btnAdicionarQuantidade;
        public Button btnRemoverQuantidade;
        public PictureBox pbImagemProduto;
        //Varievais da interface da compra
        /*
            // Inves de ficar usando esse tipo de metodo:

            Panel produtoPanel = new Panel();
            produtoPanel.Size = new Size(300, 400);
            produtoPanel.Visible = true;
            produtoPanel.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(produtoPanel);
            produtoPanel.Visible = true;


           // é melhor usar esse tipo metodo:
            Utilizar uma varieval que atribui para todos outros tipos de metodos que o forms utiliza

             produtoPanel = new Panel()
            {
                Size = new Size(300, 400),
                Visible = false,
                BorderStyle = BorderStyle.FixedSingle
            };
            Controls.Add(produtoPanel);

        Como pode ver ,melhor, simples e mais eficaz, algumas coisas mudam, mas nada problematico.
        Control.add precisa estar fora das chaves

        */
        private NivelAcesso nivelAcesso;
        Estoque esstou;
        private Estoque estoqueponte;
        public static Estoque ii;
        private hisotooriicoo historicodadosprala;
        public pedidos(Estoque estoquedados, hisotooriicoo HistoricoTrazer, NivelAcesso nivelAcesso)
        {
            InitializeComponent();
            this.esstou = estoquedados;
            this.nivelAcesso = nivelAcesso;
            this.historicodadosprala = HistoricoTrazer;

            ConfigurarAcesso();

        }
        private void ConfigurarAcesso()
        {
            // Configura a interface com base no nível de acesso [TEMPLATE]
            switch (nivelAcesso)
            {
                case NivelAcesso.Visualizador:
                    button1.Enabled = false;
                    button2.Enabled = false;
                    comprartomate.Enabled = false;
                    button3.Enabled = false;
                    button10.Enabled = false;
                    button11.Enabled = false;
                    button12.Enabled = false;
                    button13.Enabled = false;
                    button14.Enabled = false;
                    button15.Enabled = false;
                    button16.Enabled = false;
                    button17.Enabled = false;
                    button18.Enabled = false;
                    button19.Enabled = false;
                    button20.Enabled = false;
                    button21.Enabled = false;
                    button22.Enabled = false;
                    button23.Enabled = false;
                    button24.Enabled = false;
                    button25.Enabled = false;
                    button26.Enabled = false;
                    button27.Enabled = false;
                    button28.Enabled = false;
                    button29.Enabled = false;
                    button30.Enabled = false;
                    button31.Enabled = false;
                    button32.Enabled = false;
                    button33.Enabled = false;
                    button34.Enabled = false;
                    button35.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    break;
                case NivelAcesso.Funcionario:
                    button1.Enabled = true;
                    button2.Enabled = true;
                    comprartomate.Enabled = true;
                    button3.Enabled = true;
                    button10.Enabled = true;
                    button11.Enabled = true;
                    button12.Enabled = true;
                    button13.Enabled = true;
                    button14.Enabled = true;
                    button15.Enabled = true;
                    button16.Enabled = true;
                    button17.Enabled = true;
                    button18.Enabled = true;
                    button19.Enabled = true;
                    button20.Enabled = true;
                    button21.Enabled = true;
                    button22.Enabled = true;
                    button23.Enabled = true;
                    button24.Enabled = true;
                    button25.Enabled = true;
                    button26.Enabled = true;
                    button27.Enabled = true;
                    button28.Enabled = true;
                    button29.Enabled = true;
                    button30.Enabled = true;
                    button31.Enabled = true;
                    button32.Enabled = true;
                    button33.Enabled = true;
                    button34.Enabled = true;
                    button35.Enabled = true;
                    button4.Enabled = true;
                    button5.Enabled = true;
                    button6.Enabled = true;
                    button7.Enabled = true;
                    button8.Enabled = true;
                    button9.Enabled = true;
                    break;
                case NivelAcesso.Administrador:
                    button1.Enabled = true;
                    button2.Enabled = true;
                    comprartomate.Enabled = true;
                    button3.Enabled = true;
                    button10.Enabled = true;
                    button11.Enabled = true;
                    button12.Enabled = true;
                    button13.Enabled = true;
                    button14.Enabled = true;
                    button15.Enabled = true;
                    button16.Enabled = true;
                    button17.Enabled = true;
                    button18.Enabled = true;
                    button19.Enabled = true;
                    button20.Enabled = true;
                    button21.Enabled = true;
                    button22.Enabled = true;
                    button23.Enabled = true;
                    button24.Enabled = true;
                    button25.Enabled = true;
                    button26.Enabled = true;
                    button27.Enabled = true;
                    button28.Enabled = true;
                    button29.Enabled = true;
                    button30.Enabled = true;
                    button31.Enabled = true;
                    button32.Enabled = true;
                    button33.Enabled = true;
                    button34.Enabled = true;
                    button35.Enabled = true;
                    button4.Enabled = true;
                    button5.Enabled = true;
                    button6.Enabled = true;
                    button7.Enabled = true;
                    button8.Enabled = true;
                    button9.Enabled = true;
                    break;
            }
        }
        private void InicializarComponentesProduto() // Template para abrir panel com as informações para o funcionario, basta colocar o nome.Text = "";
        {

            int PosX = 10;
            int PosY = 30;

            produtoPanel = new Panel()
            {
                Size = new Size(300, 400),
                AutoSize = true,
                Visible = false,
                BorderStyle = BorderStyle.FixedSingle,
                Location = new Point(PosX, PosY)
            };
            Controls.Add(produtoPanel);

            pbImagemProduto = new PictureBox
            {
                Location = new Point(5, 15),
                Size = new Size(100, 100),
                BorderStyle = BorderStyle.FixedSingle,
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            produtoPanel.Controls.Add(pbImagemProduto);


            lblNomeProduto = new Label
            {
                Font = new Font("Arial", 14, FontStyle.Bold),
                Location = new Point(150, 10)
            };
            produtoPanel.Controls.Add(lblNomeProduto);
            produtoPanel.BringToFront();

            lblDescricaoProduto = new Label
            {
                Location = new Point(150, 40),
                Size = new Size(280, 60)
            };
            produtoPanel.Controls.Add(lblDescricaoProduto);

            Button btnFechar = new Button
            {
                Text = "Fechar",
                Location = new Point(100, 250),
                Size = new Size(80, 30),
                BackColor = Color.LightCoral
            };
            btnFechar.Click += (s, e) => produtoPanel.Visible = false; // Oculta o painel
            produtoPanel.Controls.Add(btnFechar);

            lblPreco = new Label
            {
                Font = new Font("Arial", 12, FontStyle.Bold),
                ForeColor = Color.Green,
                Location = new Point(150, 120)
            };
            produtoPanel.Controls.Add(lblPreco);

            lblMetodoPagamento = new Label
            {
                Location = new Point(150, 150),
                Size = new Size(200, 30)
            };
            produtoPanel.Controls.Add(lblMetodoPagamento);

            cbVolume = new ComboBox
            {
                Name = "cbVolume",
                Location = new Point(10, 160),
                Size = new Size(100, 30)
            };
            cbVolume.Items.AddRange(new object[] { "250g", "1 kg", "25 kg" }); // necessario para o calculo de kg no estoque
            cbVolume.SelectedIndex = 0;
            produtoPanel.Controls.Add(cbVolume);
            txtQuantidade = new TextBox
            {
                Location = new Point(10, 200),
                Size = new Size(50, 30),
                Text = "1"
            };
            produtoPanel.Controls.Add(txtQuantidade);

            btnAdicionarQuantidade = new Button
            {
                Text = "+",
                Location = new Point(70, 200),
                Size = new Size(30, 30)
            };
            btnAdicionarQuantidade.Click += (s, e) =>
            {
                int quantidade = int.Parse(txtQuantidade.Text);
                quantidade++;
                txtQuantidade.Text = quantidade.ToString();
            };
            produtoPanel.Controls.Add(btnAdicionarQuantidade);

            btnRemoverQuantidade = new Button
            {
                Text = "-",
                Location = new Point(110, 200),
                Size = new Size(30, 30)
            };
            btnRemoverQuantidade.Click += (s, e) =>
            {
                int quantidade = int.Parse(txtQuantidade.Text);
                if (quantidade > 1)
                {
                    quantidade--;
                    txtQuantidade.Text = quantidade.ToString();
                }
            };
            produtoPanel.Controls.Add(btnRemoverQuantidade);
            btnComprar = new Button
            {
                Text = "Comprar",
                Location = new Point(10, 250),
                Size = new Size(80, 30),
                BackColor = Color.LightGreen
            };
            btnComprar.Click += BtnComprar_Click;
            produtoPanel.Controls.Add(btnComprar);
        }
        private void BtnComprar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Adicionado ao Estoque!");
            string nomeProduto = lblNomeProduto.Text;
            string pesoSelecionadoTexto = cbVolume.SelectedItem?.ToString();
            int quantidade = int.Parse(txtQuantidade.Text);
            DateTime datadechegada = DateTime.Now;
            DateTime datadevalidade = datadechegada.AddDays(30);

            esstou.AdicionaringredienteBaseadopedido(nomeProduto, pesoSelecionadoTexto, quantidade, datadechegada, datadevalidade);
            string funcao = btnComprar.Text.ToString();
            string descricao = nomeProduto;

            historicodadosprala.AdicionarRegistro(funcao, descricao);
        }

        private void pedidos_Load(object sender, EventArgs e)
        {

        }

        private void comprartomate_Click(object sender, EventArgs e)     //Farinha de Trigo
        {
            InicializarComponentesProduto();
            lblNomeProduto.Text = "Farinha";        //Template para mudança
            lblMetodoPagamento.Text = "PIX, PAYPAL";
            lblPreco.Text = "R$8,10";
            lblDescricaoProduto.Text = "Farinha deleciosa";
            pbImagemProduto.Image = Image.FromFile(@"c:\Users\rapha\source\repos\Pizzaria\Pizzaria\Resources\farinhadetrigo.png");

            produtoPanel.Visible = true;
            produtoPanel.BringToFront();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void precotomate_Click(object sender, EventArgs e)
        {

        }
        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click_1(object sender, EventArgs e) // ignore aqui para baixo
        {
            InicializarComponentesProduto();
            lblNomeProduto.Font = new Font("Arial", 14, FontStyle.Bold);
            lblNomeProduto.Text = "Fermento Biológico";
            lblNomeProduto.AutoSize = true;
            lblMetodoPagamento.Text = "PIX, PAYPAL";
            lblPreco.Text = "R$16";
            lblDescricaoProduto.Text = "Fermento Biológico delecioso";
            produtoPanel.Visible = true;
            produtoPanel.BringToFront();
            pbImagemProduto.Image = Image.FromFile(@"c:\Users\rapha\source\repos\Pizzaria\Pizzaria\Resources\fermentobiologico.png");
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            InicializarComponentesProduto();
            lblNomeProduto.Font = new Font("Arial", 14, FontStyle.Bold);
            lblNomeProduto.Text = "Azeite de Oliva";
            lblNomeProduto.AutoSize = true;
            lblMetodoPagamento.Text = "PIX, PAYPAL";
            lblPreco.Text = "R$33";
            lblDescricaoProduto.Text = "Azeite de Oliva para dar aquele gosto";
            produtoPanel.Visible = true;
            produtoPanel.BringToFront();
            pbImagemProduto.Image = Image.FromFile(@"c:\Users\rapha\source\repos\Pizzaria\Pizzaria\Resources\azeitedeoliva.png");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            InicializarComponentesProduto();
            lblNomeProduto.Font = new Font("Arial", 14, FontStyle.Bold);
            lblNomeProduto.Text = "Sal";
            lblNomeProduto.AutoSize = true;
            lblMetodoPagamento.Text = "PIX, PAYPAL";
            lblPreco.Text = "R$2,20";
            lblDescricaoProduto.Text = "Salzin";
            produtoPanel.Visible = true;
            produtoPanel.BringToFront();
            pbImagemProduto.Image = Image.FromFile(@"c:\Users\rapha\source\repos\Pizzaria\Pizzaria\Resources\Sal.png");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            InicializarComponentesProduto();
            lblNomeProduto.Font = new Font("Arial", 14, FontStyle.Bold);
            lblNomeProduto.Text = "Açucar";
            lblNomeProduto.AutoSize = true;
            lblMetodoPagamento.Text = "PIX, PAYPAL";
            lblPreco.Text = "R$4,10";
            lblDescricaoProduto.Text = "Açucar";
            produtoPanel.Visible = true;
            produtoPanel.BringToFront();
            pbImagemProduto.Image = Image.FromFile(@"c:\Users\rapha\source\repos\Pizzaria\Pizzaria\Resources\açucar.png");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InicializarComponentesProduto();
            lblNomeProduto.Font = new Font("Arial", 14, FontStyle.Bold);
            lblNomeProduto.Text = "Molho de Tomate";
            lblNomeProduto.AutoSize = true;
            lblMetodoPagamento.Text = "PIX, PAYPAL";
            lblPreco.Text = "R$15,0";
            lblDescricaoProduto.Text = "Sabor extra";
            produtoPanel.Visible = true;
            produtoPanel.BringToFront();
            pbImagemProduto.Image = Image.FromFile(@"c:\Users\rapha\source\repos\Pizzaria\Pizzaria\Resources\molhodetomate.png");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InicializarComponentesProduto();
            lblNomeProduto.Font = new Font("Arial", 14, FontStyle.Bold);
            lblNomeProduto.Text = "Molho Branco";
            lblNomeProduto.AutoSize = true;
            lblMetodoPagamento.Text = "PIX, PAYPAL";
            lblPreco.Text = "R$45,0";
            lblDescricaoProduto.Text = "Sabor especial";
            produtoPanel.Visible = true;
            produtoPanel.BringToFront();
            pbImagemProduto.Image = Image.FromFile(@"c:\Users\rapha\source\repos\Pizzaria\Pizzaria\Resources\molhobranco.png");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            InicializarComponentesProduto();
            lblNomeProduto.Font = new Font("Arial", 14, FontStyle.Bold);
            lblNomeProduto.Text = "Molho Pesto";
            lblNomeProduto.AutoSize = true;
            lblMetodoPagamento.Text = "PIX, PAYPAL";
            lblPreco.Text = "R$20,0";
            lblDescricaoProduto.Text = "Sabor unico";
            produtoPanel.Visible = true;
            produtoPanel.BringToFront();
            pbImagemProduto.Image = Image.FromFile(@"c:\Users\rapha\source\repos\Pizzaria\Pizzaria\Resources\molhoposto.png");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InicializarComponentesProduto();
            lblNomeProduto.Font = new Font("Arial", 14, FontStyle.Bold);
            lblNomeProduto.Text = "Mussarela";
            lblNomeProduto.AutoSize = true;
            lblMetodoPagamento.Text = "PIX, PAYPAL";
            lblPreco.Text = "R$80,0";
            lblDescricaoProduto.Text = "Bom";
            produtoPanel.Visible = true;
            produtoPanel.BringToFront();
            pbImagemProduto.Image = Image.FromFile(@"c:\Users\rapha\source\repos\Pizzaria\Pizzaria\Resources\mussarela.png");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            InicializarComponentesProduto();
            lblNomeProduto.Font = new Font("Arial", 14, FontStyle.Bold);
            lblNomeProduto.Text = "Parmesao";
            lblNomeProduto.AutoSize = true;
            lblMetodoPagamento.Text = "PIX, PAYPAL";
            lblPreco.Text = "R$127,0";
            lblDescricaoProduto.Text = "Bom";
            produtoPanel.Visible = true;
            produtoPanel.BringToFront();
            pbImagemProduto.Image = Image.FromFile(@"c:\Users\rapha\source\repos\Pizzaria\Pizzaria\Resources\parmesao.png");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            InicializarComponentesProduto();
            lblNomeProduto.Font = new Font("Arial", 14, FontStyle.Bold);
            lblNomeProduto.Text = "Provolone";
            lblNomeProduto.AutoSize = true;
            lblMetodoPagamento.Text = "PIX, PAYPAL";
            lblPreco.Text = "R$114,0";
            lblDescricaoProduto.Text = "Bom";
            produtoPanel.Visible = true;
            produtoPanel.BringToFront();
            pbImagemProduto.Image = Image.FromFile(@"c:\Users\rapha\source\repos\Pizzaria\Pizzaria\Resources\provolone.png");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            InicializarComponentesProduto();
            lblNomeProduto.Font = new Font("Arial", 14, FontStyle.Bold);
            lblNomeProduto.Text = "Gorgonzola";
            lblNomeProduto.AutoSize = true;
            lblMetodoPagamento.Text = "PIX, PAYPAL";
            lblPreco.Text = "R$121,0";
            lblDescricaoProduto.Text = "Tipo de queijo delecioso";
            produtoPanel.Visible = true;
            produtoPanel.BringToFront();
            pbImagemProduto.Image = Image.FromFile(@"c:\Users\rapha\source\repos\Pizzaria\Pizzaria\Resources\gorgonzola.png");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            InicializarComponentesProduto();
            lblNomeProduto.Font = new Font("Arial", 14, FontStyle.Bold);
            lblNomeProduto.Text = "Catupiry";
            lblNomeProduto.AutoSize = true;
            lblMetodoPagamento.Text = "PIX, PAYPAL";
            lblPreco.Text = "R$47,0";
            lblDescricaoProduto.Text = "1# Requeijao do brasil";
            produtoPanel.Visible = true;
            produtoPanel.BringToFront();
            pbImagemProduto.Image = Image.FromFile(@"c:\Users\rapha\source\repos\Pizzaria\Pizzaria\Resources\catapury.png");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            InicializarComponentesProduto();
            lblNomeProduto.Font = new Font("Arial", 14, FontStyle.Bold);
            lblNomeProduto.Text = "Presunto";
            lblNomeProduto.AutoSize = true;
            lblMetodoPagamento.Text = "PIX, PAYPAL";
            lblPreco.Text = "R$300,0";
            lblDescricaoProduto.Text = "Presuntao";
            produtoPanel.Visible = true;
            produtoPanel.BringToFront();
            pbImagemProduto.Image = Image.FromFile(@"c:\Users\rapha\source\repos\Pizzaria\Pizzaria\Resources\Presunto.png");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            InicializarComponentesProduto();
            lblNomeProduto.Font = new Font("Arial", 14, FontStyle.Bold);
            lblNomeProduto.Text = "Calabresa";
            lblNomeProduto.AutoSize = true;
            lblMetodoPagamento.Text = "PIX, PAYPAL";
            lblPreco.Text = "R$65,0";
            lblDescricaoProduto.Text = "Hmm calabreso";
            produtoPanel.Visible = true;
            produtoPanel.BringToFront();
            pbImagemProduto.Image = Image.FromFile(@"c:\Users\rapha\source\repos\Pizzaria\Pizzaria\Resources\calabresa.jpeg");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            InicializarComponentesProduto();
            lblNomeProduto.Font = new Font("Arial", 14, FontStyle.Bold);
            lblNomeProduto.Text = "Frango Desfiado";
            lblNomeProduto.AutoSize = true;
            lblMetodoPagamento.Text = "PIX, PAYPAL";
            lblPreco.Text = "R$55,0";
            lblDescricaoProduto.Text = "Hmm calabreso";
            produtoPanel.Visible = true;
            produtoPanel.BringToFront();
            pbImagemProduto.Image = Image.FromFile(@"c:\Users\rapha\source\repos\Pizzaria\Pizzaria\Resources\fragondesfiado.jpeg");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            InicializarComponentesProduto();
            lblNomeProduto.Font = new Font("Arial", 14, FontStyle.Bold);
            lblNomeProduto.Text = "Pepperoni";
            lblNomeProduto.AutoSize = true;
            lblMetodoPagamento.Text = "PIX, PAYPAL";
            lblPreco.Text = "R$58,80";
            lblDescricaoProduto.Text = "Italia";
            produtoPanel.Visible = true;
            produtoPanel.BringToFront();
            pbImagemProduto.Image = Image.FromFile(@"c:\Users\rapha\source\repos\Pizzaria\Pizzaria\Resources\pepperoni.jpeg");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            InicializarComponentesProduto();
            lblNomeProduto.Font = new Font("Arial", 14, FontStyle.Bold);
            lblNomeProduto.Text = "Lata de Atum";
            lblNomeProduto.AutoSize = true;
            lblMetodoPagamento.Text = "PIX, PAYPAL";
            lblPreco.Text = "R$55";
            lblDescricaoProduto.Text = "Atum BOM";
            produtoPanel.Visible = true;
            produtoPanel.BringToFront();
            pbImagemProduto.Image = Image.FromFile(@"c:\Users\rapha\source\repos\Pizzaria\Pizzaria\Resources\latadeatum.jpeg");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            InicializarComponentesProduto();
            lblNomeProduto.Font = new Font("Arial", 14, FontStyle.Bold);
            lblNomeProduto.Text = "Bacon";
            lblNomeProduto.AutoSize = true;
            lblMetodoPagamento.Text = "PIX, PAYPAL";
            lblPreco.Text = "R$61,65";
            lblDescricaoProduto.Text = "Bacon";
            produtoPanel.Visible = true;
            produtoPanel.BringToFront();
            pbImagemProduto.Image = Image.FromFile(@"c:\Users\rapha\source\repos\Pizzaria\Pizzaria\Resources\bacon.jpeg");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            InicializarComponentesProduto();
            lblNomeProduto.Font = new Font("Arial", 14, FontStyle.Bold);
            lblNomeProduto.Text = "Carne Moida";
            lblNomeProduto.AutoSize = true;
            lblMetodoPagamento.Text = "PIX, PAYPAL";
            lblPreco.Text = "R$48";
            lblDescricaoProduto.Text = "Carne Moida gostosa";
            produtoPanel.Visible = true;
            produtoPanel.BringToFront();
            pbImagemProduto.Image = Image.FromFile(@"c:\Users\rapha\source\repos\Pizzaria\Pizzaria\Resources\carnemoida.jpeg");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            InicializarComponentesProduto();
            lblNomeProduto.Font = new Font("Arial", 14, FontStyle.Bold);
            lblNomeProduto.Text = "Cebola";
            lblNomeProduto.AutoSize = true;
            lblMetodoPagamento.Text = "PIX, PAYPAL";
            lblPreco.Text = "R$20";
            lblDescricaoProduto.Text = "Cebola chorosa";
            produtoPanel.Visible = true;
            produtoPanel.BringToFront();
            pbImagemProduto.Image = Image.FromFile(@"c:\Users\rapha\source\repos\Pizzaria\Pizzaria\Resources\cebola.jpeg");
        }

        private void button23_Click(object sender, EventArgs e)
        {
            {
                InicializarComponentesProduto();
                lblNomeProduto.Font = new Font("Arial", 14, FontStyle.Bold);
                lblNomeProduto.Text = "Pimentão";
                lblNomeProduto.AutoSize = true;
                lblMetodoPagamento.Text = "PIX, PAYPAL";
                lblPreco.Text = "R$15,99";
                lblDescricaoProduto.Text = "Pimentão quente";
                produtoPanel.Visible = true;
                produtoPanel.BringToFront();
                pbImagemProduto.Image = Image.FromFile(@"c:\Users\rapha\source\repos\Pizzaria\Pizzaria\Resources\pimentao.jpeg");
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            InicializarComponentesProduto();
            lblNomeProduto.Font = new Font("Arial", 14, FontStyle.Bold);
            lblNomeProduto.Text = "Tomate";
            lblNomeProduto.AutoSize = true;
            lblMetodoPagamento.Text = "PIX, PAYPAL";
            lblPreco.Text = "R$6";
            lblDescricaoProduto.Text = "Tomate delicioso";
            produtoPanel.Visible = true;
            produtoPanel.BringToFront();
            pbImagemProduto.Image = Image.FromFile(@"c:\Users\rapha\source\repos\Pizzaria\Pizzaria\Resources\Tomate.png");
        }

        private void button25_Click(object sender, EventArgs e)
        {
            InicializarComponentesProduto();
            lblNomeProduto.Font = new Font("Arial", 14, FontStyle.Bold);
            lblNomeProduto.Text = "Azeitonas";
            lblNomeProduto.AutoSize = true;
            lblMetodoPagamento.Text = "PIX, PAYPAL";
            lblPreco.Text = "R$49,99";
            lblDescricaoProduto.Text = "Azeitonas, aquele extra na pizza";
            produtoPanel.Visible = true;
            produtoPanel.BringToFront();
            pbImagemProduto.Image = Image.FromFile(@"c:\Users\rapha\source\repos\Pizzaria\Pizzaria\Resources\azeitonass.jpeg");
        }

        private void button26_Click(object sender, EventArgs e)
        {
            InicializarComponentesProduto();
            lblNomeProduto.Font = new Font("Arial", 14, FontStyle.Bold);
            lblNomeProduto.Text = "Manjericão";
            lblNomeProduto.AutoSize = true;
            lblMetodoPagamento.Text = "PIX, PAYPAL";
            lblPreco.Text = "R$12";
            lblDescricaoProduto.Text = "Manjericão";
            produtoPanel.Visible = true;
            produtoPanel.BringToFront();
            pbImagemProduto.Image = Image.FromFile(@"c:\Users\rapha\source\repos\Pizzaria\Pizzaria\Resources\manjericao.jpeg");
        }

        private void button27_Click(object sender, EventArgs e)
        {
            InicializarComponentesProduto();
            lblNomeProduto.Font = new Font("Arial", 14, FontStyle.Bold);
            lblNomeProduto.Text = "Alho";
            lblNomeProduto.AutoSize = true;
            lblMetodoPagamento.Text = "PIX, PAYPAL";
            lblPreco.Text = "R$29";
            lblDescricaoProduto.Text = "Alho, sabor extra bom";
            produtoPanel.Visible = true;
            produtoPanel.BringToFront();
            pbImagemProduto.Image = Image.FromFile(@"c:\Users\rapha\source\repos\Pizzaria\Pizzaria\Resources\alho.jpeg");
        }

        private void button28_Click(object sender, EventArgs e)
        {
            InicializarComponentesProduto();
            lblNomeProduto.Font = new Font("Arial", 14, FontStyle.Bold);
            lblNomeProduto.Text = "Orégano";
            lblNomeProduto.AutoSize = true;
            lblMetodoPagamento.Text = "PIX, PAYPAL";
            lblPreco.Text = "R$26";
            lblDescricaoProduto.Text = "Orégano";
            produtoPanel.Visible = true;
            produtoPanel.BringToFront();
            pbImagemProduto.Image = Image.FromFile(@"c:\Users\rapha\source\repos\Pizzaria\Pizzaria\Resources\oregano.jpeg");
        }

        private void button29_Click(object sender, EventArgs e)
        {
            InicializarComponentesProduto();
            lblNomeProduto.Font = new Font("Arial", 14, FontStyle.Bold);
            lblNomeProduto.Text = "Rúcula";
            lblNomeProduto.AutoSize = true;
            lblMetodoPagamento.Text = "PIX, PAYPAL";
            lblPreco.Text = "R$3,10";
            lblDescricaoProduto.Text = "Rúcula para veganos";
            produtoPanel.Visible = true;
            produtoPanel.BringToFront();
            pbImagemProduto.Image = Image.FromFile(@"c:\Users\rapha\source\repos\Pizzaria\Pizzaria\Resources\rucula.jpeg");
        }

        private void button30_Click(object sender, EventArgs e)
        {
            InicializarComponentesProduto();
            lblNomeProduto.Font = new Font("Arial", 14, FontStyle.Bold);
            lblNomeProduto.Text = "Requeijão";
            lblNomeProduto.AutoSize = true;
            lblMetodoPagamento.Text = "PIX, PAYPAL";
            lblPreco.Text = "R$37";
            lblDescricaoProduto.Text = "Requeijão delicioso";
            produtoPanel.Visible = true;
            produtoPanel.BringToFront();
            pbImagemProduto.Image = Image.FromFile(@"c:\Users\rapha\source\repos\Pizzaria\Pizzaria\Resources\requeijao.jpeg");
        }

        private void button31_Click(object sender, EventArgs e)
        {
            InicializarComponentesProduto();
            lblNomeProduto.Font = new Font("Arial", 14, FontStyle.Bold);
            lblNomeProduto.Text = "Tomate Seco";
            lblNomeProduto.AutoSize = true;
            lblMetodoPagamento.Text = "PIX, PAYPAL";
            lblPreco.Text = "R$37";
            lblDescricaoProduto.Text = "Tomate Seco para tempero extra";
            produtoPanel.Visible = true;
            produtoPanel.BringToFront();
            pbImagemProduto.Image = Image.FromFile(@"c:\Users\rapha\source\repos\Pizzaria\Pizzaria\Resources\tomateseco.jpeg");
        }

        private void button32_Click(object sender, EventArgs e)
        {
            InicializarComponentesProduto();
            lblNomeProduto.Font = new Font("Arial", 14, FontStyle.Bold);
            lblNomeProduto.Text = "Milho";
            lblNomeProduto.AutoSize = true;
            lblMetodoPagamento.Text = "PIX, PAYPAL";
            lblPreco.Text = "R$39,90";
            lblDescricaoProduto.Text = "Milho muito bom";
            produtoPanel.Visible = true;
            produtoPanel.BringToFront();
            pbImagemProduto.Image = Image.FromFile(@"c:\Users\rapha\source\repos\Pizzaria\Pizzaria\Resources\milho.jpeg");
        }

        private void button33_Click(object sender, EventArgs e)
        {
            InicializarComponentesProduto();
            lblNomeProduto.Font = new Font("Arial", 14, FontStyle.Bold);
            lblNomeProduto.Text = "Palmito";
            lblNomeProduto.AutoSize = true;
            lblMetodoPagamento.Text = "PIX, PAYPAL";
            lblPreco.Text = "R$32";
            lblDescricaoProduto.Text = "Palmito muito bom";
            produtoPanel.Visible = true;
            produtoPanel.BringToFront();
            pbImagemProduto.Image = Image.FromFile(@"c:\Users\rapha\source\repos\Pizzaria\Pizzaria\Resources\palmito.jpeg");
        }

        private void button34_Click(object sender, EventArgs e)
        {
            InicializarComponentesProduto();
            lblNomeProduto.Font = new Font("Arial", 14, FontStyle.Bold);
            lblNomeProduto.Text = "Champignon";
            lblNomeProduto.AutoSize = true;
            lblMetodoPagamento.Text = "PIX, PAYPAL";
            lblPreco.Text = "R$100";
            lblDescricaoProduto.Text = "Champignon para complementar";
            produtoPanel.Visible = true;
            produtoPanel.BringToFront();
            pbImagemProduto.Image = Image.FromFile(@"c:\Users\rapha\source\repos\Pizzaria\Pizzaria\Resources\champignon.jpeg");
        }

        private void button35_Click(object sender, EventArgs e)
        {
            InicializarComponentesProduto();
            lblNomeProduto.Font = new Font("Arial", 14, FontStyle.Bold);
            lblNomeProduto.Text = "Ovos";
            lblNomeProduto.AutoSize = true;
            lblMetodoPagamento.Text = "PIX, PAYPAL";
            lblPreco.Text = "R$22";
            lblDescricaoProduto.Text = "Ovos para ficar monstro";
            produtoPanel.Visible = true;
            produtoPanel.BringToFront();
            pbImagemProduto.Image = Image.FromFile(@"c:\Users\rapha\source\repos\Pizzaria\Pizzaria\Resources\ovos.jpeg");
        }
    }
}