namespace Pizzaria
{
    partial class CriarReceita
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
            fazerpizza1 = new TextBox();
            finalizarpizza = new Button();
            label1 = new Label();
            ingredientespizza1 = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // fazerpizza1
            // 
            fazerpizza1.Location = new Point(43, 47);
            fazerpizza1.Name = "fazerpizza1";
            fazerpizza1.Size = new Size(335, 23);
            fazerpizza1.TabIndex = 0;
            fazerpizza1.TextChanged += textBox1_TextChanged;
            // 
            // finalizarpizza
            // 
            finalizarpizza.Location = new Point(43, 200);
            finalizarpizza.Name = "finalizarpizza";
            finalizarpizza.Size = new Size(335, 23);
            finalizarpizza.TabIndex = 2;
            finalizarpizza.Text = "Finalizar Pizza";
            finalizarpizza.UseVisualStyleBackColor = true;
            finalizarpizza.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(178, 29);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 3;
            label1.Text = "Nome da Pizza";
            label1.Click += label1_Click;
            // 
            // ingredientespizza1
            // 
            ingredientespizza1.Location = new Point(43, 91);
            ingredientespizza1.Multiline = true;
            ingredientespizza1.Name = "ingredientespizza1";
            ingredientespizza1.Size = new Size(335, 103);
            ingredientespizza1.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(178, 73);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 8;
            label2.Text = "Ingredientes";
            label2.Click += label2_Click_2;
            // 
            // CriarReceita
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Silver;
            ClientSize = new Size(435, 278);
            Controls.Add(label2);
            Controls.Add(ingredientespizza1);
            Controls.Add(label1);
            Controls.Add(finalizarpizza);
            Controls.Add(fazerpizza1);
            ForeColor = Color.Red;
            Name = "CriarReceita";
            Text = "CriarReceita";
            Load += CriarReceita_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox ingredientespizza1;
        private Label label2;
    }
}