namespace Pizzaria
{
    partial class Administracao
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
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            funcao = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            nome = new DataGridViewTextBoxColumn();
            data = new DataGridViewTextBoxColumn();
            label1 = new Label();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(54, 86);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(256, 23);
            textBox1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { funcao, email, nome, data });
            dataGridView1.Location = new Point(416, 1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(439, 409);
            dataGridView1.TabIndex = 3;
            // 
            // funcao
            // 
            funcao.HeaderText = "Função";
            funcao.Name = "funcao";
            // 
            // email
            // 
            email.HeaderText = "E-MAIL";
            email.Name = "email";
            // 
            // nome
            // 
            nome.HeaderText = "Nome";
            nome.Name = "nome";
            // 
            // data
            // 
            data.HeaderText = "Data";
            data.Name = "data";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(101, 9);
            label1.Name = "label1";
            label1.Size = new Size(142, 22);
            label1.TabIndex = 4;
            label1.Text = "NOVO MEMBRO";
            label1.Click += label1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Visualizador", "Funcionário", "Administrador" });
            comboBox1.Location = new Point(54, 45);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 5;
            comboBox1.Text = "Função";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(54, 126);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(256, 23);
            textBox2.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(101, 177);
            button1.Name = "button1";
            button1.Size = new Size(107, 23);
            button1.TabIndex = 8;
            button1.Text = "Adicionar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightGray;
            label2.Location = new Point(2, 89);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 9;
            label2.Text = "E-MAIL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightGray;
            label3.Location = new Point(2, 129);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 10;
            label3.Text = "Nome";
            // 
            // button2
            // 
            button2.Location = new Point(2, 374);
            button2.Name = "button2";
            button2.Size = new Size(107, 23);
            button2.TabIndex = 11;
            button2.Text = "Salvar em txt";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(2, 345);
            button3.Name = "button3";
            button3.Size = new Size(107, 23);
            button3.TabIndex = 12;
            button3.Text = "Salvar em CSV";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Administracao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(857, 409);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Name = "Administracao";
            Text = "Administracao";
            Load += Administracao_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn funcao;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn data;
        private Label label1;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private Button button1;
        private Label label2;
        private Label label3;
        private Button button2;
        private Button button3;
    }
}