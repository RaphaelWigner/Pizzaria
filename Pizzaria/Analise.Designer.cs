namespace Pizzaria
{
    partial class Analise
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
            components = new System.ComponentModel.Container();
            dataGridViewAnalise = new DataGridView();
            analiseTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dataGridViewAnalise).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewAnalise
            // 
            dataGridViewAnalise.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAnalise.Location = new Point(299, 174);
            dataGridViewAnalise.Name = "dataGridViewAnalise";
            dataGridViewAnalise.Size = new Size(240, 150);
            dataGridViewAnalise.TabIndex = 0;
            // 
            // Analise
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewAnalise);
            Name = "Analise";
            Text = "Analise";
            Load += Analise_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAnalise).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewAnalise;
        private System.Windows.Forms.Timer analiseTimer;
    }
}