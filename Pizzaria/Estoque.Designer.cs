namespace Pizzaria
{
    partial class Estoque
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
            dataGridView1 = new DataGridView();
            KG = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            datadevalidade = new DataGridViewTextBoxColumn();
            datadechegada = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            label2 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { KG, Nome, datadevalidade, datadechegada });
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(474, 367);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // KG
            // 
            KG.HeaderText = "KG";
            KG.Name = "KG";
            KG.Width = 25;
            // 
            // Nome
            // 
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            // 
            // datadevalidade
            // 
            datadevalidade.HeaderText = "Data de Validade";
            datadevalidade.Name = "datadevalidade";
            // 
            // datadechegada
            // 
            datadechegada.HeaderText = "Data de Chegada";
            datadechegada.Name = "datadechegada";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox1);
            panel1.ForeColor = Color.Red;
            panel1.Location = new Point(492, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(154, 367);
            panel1.TabIndex = 1;
            // 
            // button4
            // 
            button4.Location = new Point(9, 319);
            button4.Name = "button4";
            button4.RightToLeft = RightToLeft.No;
            button4.Size = new Size(140, 45);
            button4.TabIndex = 7;
            button4.Text = "Salvar em TXT [SALVAR DADOS DE ESTOQUE]";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(9, 126);
            button3.Name = "button3";
            button3.Size = new Size(140, 23);
            button3.TabIndex = 6;
            button3.Text = "Remover Ingrediente";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(9, 155);
            button2.Name = "button2";
            button2.RightToLeft = RightToLeft.No;
            button2.Size = new Size(140, 25);
            button2.TabIndex = 5;
            button2.Text = "Atualizar o Estoque";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 62);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 4;
            label2.Text = "Quantia";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(58, 59);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(46, 23);
            textBox2.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(9, 97);
            button1.Name = "button1";
            button1.Size = new Size(140, 23);
            button1.TabIndex = 2;
            button1.Text = "Adicionar Ingrediente";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 12);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 1;
            label1.Text = "Novo Ingrediente";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(148, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button5
            // 
            button5.ForeColor = Color.DarkRed;
            button5.Location = new Point(9, 268);
            button5.Name = "button5";
            button5.RightToLeft = RightToLeft.No;
            button5.Size = new Size(140, 45);
            button5.TabIndex = 8;
            button5.Text = "Salvar em CSV [SALVAR DADOS DE ESTOQUE]";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Estoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(653, 394);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Name = "Estoque";
            Text = "Estoque";
            Load += Estoque_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private DataGridViewTextBoxColumn KG;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn datadevalidade;
        private DataGridViewTextBoxColumn datadechegada;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}