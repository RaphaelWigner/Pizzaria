namespace Pizzaria
{
    partial class Gerenciamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gerenciamento));
            Estoque = new Panel();
            buttonEditar = new Button();
            pictureBox6 = new PictureBox();
            button5 = new Button();
            pictureBox5 = new PictureBox();
            button4 = new Button();
            pictureBox4 = new PictureBox();
            button3 = new Button();
            button1 = new Button();
            label1 = new Label();
            Duvida = new Button();
            button2 = new Button();
            ReceitaButao = new Button();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            Estoquebutao = new Button();
            pictureBox1 = new PictureBox();
            Estoque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Estoque
            // 
            Estoque.BorderStyle = BorderStyle.FixedSingle;
            Estoque.Controls.Add(buttonEditar);
            Estoque.Controls.Add(pictureBox6);
            Estoque.Controls.Add(button5);
            Estoque.Controls.Add(pictureBox5);
            Estoque.Controls.Add(button4);
            Estoque.Controls.Add(pictureBox4);
            Estoque.Controls.Add(button3);
            Estoque.Controls.Add(button1);
            Estoque.Controls.Add(label1);
            Estoque.Controls.Add(Duvida);
            Estoque.Controls.Add(button2);
            Estoque.Controls.Add(ReceitaButao);
            Estoque.Controls.Add(pictureBox3);
            Estoque.Controls.Add(pictureBox2);
            Estoque.Controls.Add(Estoquebutao);
            Estoque.Controls.Add(pictureBox1);
            Estoque.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Estoque.Location = new Point(12, 12);
            Estoque.Name = "Estoque";
            Estoque.Size = new Size(310, 457);
            Estoque.TabIndex = 0;
            Estoque.Paint += panel1_Paint;
            // 
            // buttonEditar
            // 
            buttonEditar.Location = new Point(230, 420);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(75, 23);
            buttonEditar.TabIndex = 17;
            buttonEditar.Text = "EDITAR";
            buttonEditar.UseVisualStyleBackColor = true;
            buttonEditar.Click += buttonEditar_Click_1;
            // 
            // pictureBox6
            // 
            pictureBox6.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(3, 320);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(61, 43);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 16;
            pictureBox6.TabStop = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Silver;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.Red;
            button5.Location = new Point(96, 331);
            button5.Name = "button5";
            button5.Size = new Size(130, 23);
            button5.TabIndex = 15;
            button5.Text = "Administrador";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(3, 260);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(61, 44);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 14;
            pictureBox5.TabStop = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Silver;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.Red;
            button4.Location = new Point(96, 271);
            button4.Name = "button4";
            button4.Size = new Size(130, 23);
            button4.TabIndex = 13;
            button4.Text = "Análise";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(3, 204);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(61, 44);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Silver;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.Red;
            button3.Location = new Point(96, 216);
            button3.Name = "button3";
            button3.Size = new Size(130, 23);
            button3.TabIndex = 11;
            button3.Text = "Histórico";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Red;
            button1.Location = new Point(96, 162);
            button1.Name = "button1";
            button1.Size = new Size(130, 23);
            button1.TabIndex = 10;
            button1.Text = "Cliente";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Castellar", 30F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 100);
            label1.Name = "label1";
            label1.Size = new Size(54, 48);
            label1.TabIndex = 9;
            label1.Text = "A";
            // 
            // Duvida
            // 
            Duvida.BackColor = Color.Silver;
            Duvida.BackgroundImage = Properties.Resources.Duvida;
            Duvida.BackgroundImageLayout = ImageLayout.Zoom;
            Duvida.FlatStyle = FlatStyle.Flat;
            Duvida.Location = new Point(266, 3);
            Duvida.Name = "Duvida";
            Duvida.Size = new Size(39, 33);
            Duvida.TabIndex = 7;
            Duvida.TextImageRelation = TextImageRelation.ImageAboveText;
            Duvida.UseCompatibleTextRendering = true;
            Duvida.UseVisualStyleBackColor = false;
            Duvida.Click += Duvida_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Silver;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.Red;
            button2.Location = new Point(96, 112);
            button2.Name = "button2";
            button2.Size = new Size(130, 23);
            button2.TabIndex = 5;
            button2.Text = "FORNECEDOR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // ReceitaButao
            // 
            ReceitaButao.BackColor = Color.Silver;
            ReceitaButao.FlatStyle = FlatStyle.Flat;
            ReceitaButao.ForeColor = Color.Red;
            ReceitaButao.Location = new Point(96, 63);
            ReceitaButao.Name = "ReceitaButao";
            ReceitaButao.Size = new Size(130, 23);
            ReceitaButao.TabIndex = 4;
            ReceitaButao.Text = "RECEITAS";
            ReceitaButao.UseVisualStyleBackColor = false;
            ReceitaButao.Click += ReceitaButao_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(3, 151);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(61, 44);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(11, 53);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 44);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Estoquebutao
            // 
            Estoquebutao.BackColor = Color.Silver;
            Estoquebutao.FlatStyle = FlatStyle.Flat;
            Estoquebutao.ForeColor = Color.Red;
            Estoquebutao.Location = new Point(96, 13);
            Estoquebutao.Name = "Estoquebutao";
            Estoquebutao.Size = new Size(130, 23);
            Estoquebutao.TabIndex = 1;
            Estoquebutao.Text = "ESTOQUE";
            Estoquebutao.UseVisualStyleBackColor = false;
            Estoquebutao.Click += Estoquebutao_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = Properties.Resources.Caixa;
            pictureBox1.Location = new Point(-1, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(61, 44);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Gerenciamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(334, 481);
            Controls.Add(Estoque);
            Name = "Gerenciamento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerenciamento";
            Load += Gerenciamento_Load;
            Estoque.ResumeLayout(false);
            Estoque.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Estoque;
        private Button Estoquebutao;
        private PictureBox pictureBox1;
        private Button button2;
        private Button ReceitaButao;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Button Duvida;
        private Label label1;
        private Button button1;
        private PictureBox pictureBox4;
        private Button button3;
        private PictureBox pictureBox5;
        private Button button4;
        private Button button5;
        private PictureBox pictureBox6;
        private Button buttonEditar;
    }
}