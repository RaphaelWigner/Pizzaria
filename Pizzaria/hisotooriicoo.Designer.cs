namespace Pizzaria
{
    partial class hisotooriicoo
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
            IDHISTORICO = new DataGridViewTextBoxColumn();
            FUNÇÃO = new DataGridViewTextBoxColumn();
            DESCRICAO = new DataGridViewTextBoxColumn();
            Data = new DataGridViewTextBoxColumn();
            Horário = new DataGridViewTextBoxColumn();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IDHISTORICO, FUNÇÃO, DESCRICAO, Data, Horário });
            dataGridView1.Location = new Point(-1, 1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(543, 437);
            dataGridView1.TabIndex = 0;
            // 
            // IDHISTORICO
            // 
            IDHISTORICO.HeaderText = "ID";
            IDHISTORICO.Name = "IDHISTORICO";
            // 
            // FUNÇÃO
            // 
            FUNÇÃO.HeaderText = "FUNCAO";
            FUNÇÃO.Name = "FUNÇÃO";
            // 
            // DESCRICAO
            // 
            DESCRICAO.HeaderText = "Descrição";
            DESCRICAO.Name = "DESCRICAO";
            // 
            // Data
            // 
            Data.HeaderText = "Data";
            Data.Name = "Data";
            // 
            // Horário
            // 
            Horário.HeaderText = "Horário";
            Horário.Name = "Horário";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.ForeColor = Color.Red;
            button1.Location = new Point(693, 411);
            button1.Name = "button1";
            button1.Size = new Size(105, 27);
            button1.TabIndex = 1;
            button1.Text = "Salvar em TxT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.ForeColor = Color.Red;
            button2.Location = new Point(548, 411);
            button2.Name = "button2";
            button2.Size = new Size(139, 27);
            button2.TabIndex = 2;
            button2.Text = "Salvar em CSV[EXCEL]";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // hisotooriicoo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "hisotooriicoo";
            Text = "hisotooriicoo";
            Load += hisotooriicoo_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn IDHISTORICO;
        private DataGridViewTextBoxColumn FUNÇÃO;
        private DataGridViewTextBoxColumn DESCRICAO;
        private DataGridViewTextBoxColumn Data;
        private DataGridViewTextBoxColumn Horário;
        private Button button1;
        private Button button2;
    }
}