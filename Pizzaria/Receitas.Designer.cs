namespace Pizzaria
{
    partial class Receitas
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
            adicionarpizza = new Button();
            panel1 = new Panel();
            button1 = new Button();
            button3 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // adicionarpizza
            // 
            adicionarpizza.BackColor = Color.Silver;
            adicionarpizza.FlatStyle = FlatStyle.Flat;
            adicionarpizza.ForeColor = Color.Red;
            adicionarpizza.Location = new Point(334, 18);
            adicionarpizza.Name = "adicionarpizza";
            adicionarpizza.Size = new Size(105, 28);
            adicionarpizza.TabIndex = 0;
            adicionarpizza.Text = "Criar Pizza";
            adicionarpizza.UseVisualStyleBackColor = false;
            adicionarpizza.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(adicionarpizza);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 426);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Red;
            button1.Location = new Point(378, 395);
            button1.Name = "button1";
            button1.Size = new Size(105, 28);
            button1.TabIndex = 1;
            button1.Text = "Salvar em TxT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button3
            // 
            button3.BackColor = Color.Silver;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.Red;
            button3.Location = new Point(267, 395);
            button3.Name = "button3";
            button3.Size = new Size(105, 28);
            button3.TabIndex = 3;
            button3.Text = "Salvar em CSV";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Receitas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Receitas";
            Text = "Receitas";
            Load += Receitas_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button adicionarpizza;
        private Panel panel1;
        private HScrollBar hScrollBar1;
        private Button button1;
        private Button button3;
    }
}