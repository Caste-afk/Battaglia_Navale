namespace project
{
    partial class Fine
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
            label1 = new Label();
            btn_salva = new Button();
            lbl_nome = new Label();
            tbx_nome = new TextBox();
            btn_Annulla = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Ink Free", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(140, 9);
            label1.Name = "label1";
            label1.Size = new Size(246, 50);
            label1.TabIndex = 1;
            label1.Text = "Salvare punteggio?";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btn_salva
            // 
            btn_salva.Location = new Point(86, 183);
            btn_salva.Name = "btn_salva";
            btn_salva.Size = new Size(172, 32);
            btn_salva.TabIndex = 3;
            btn_salva.Text = "Salva";
            btn_salva.UseVisualStyleBackColor = true;
            btn_salva.Click += btn_salva_Click;
            // 
            // lbl_nome
            // 
            lbl_nome.Font = new Font("Ink Free", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_nome.Location = new Point(12, 86);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(246, 40);
            lbl_nome.TabIndex = 4;
            lbl_nome.Text = "Inserisci nome";
            lbl_nome.TextAlign = ContentAlignment.TopCenter;
            // 
            // tbx_nome
            // 
            tbx_nome.Font = new Font("Ink Free", 18F, FontStyle.Bold, GraphicsUnit.Point);
            tbx_nome.Location = new Point(285, 89);
            tbx_nome.Name = "tbx_nome";
            tbx_nome.Size = new Size(219, 37);
            tbx_nome.TabIndex = 5;
            // 
            // btn_Annulla
            // 
            btn_Annulla.Location = new Point(285, 183);
            btn_Annulla.Name = "btn_Annulla";
            btn_Annulla.Size = new Size(172, 32);
            btn_Annulla.TabIndex = 6;
            btn_Annulla.Text = "Annulla";
            btn_Annulla.UseVisualStyleBackColor = true;
            btn_Annulla.Click += btn_Annulla_Click;
            // 
            // Fine
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 275);
            Controls.Add(btn_Annulla);
            Controls.Add(tbx_nome);
            Controls.Add(lbl_nome);
            Controls.Add(btn_salva);
            Controls.Add(label1);
            Name = "Fine";
            Text = "Fine";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btn_salva;
        private Label lbl_nome;
        private TextBox tbx_nome;
        private Button btn_Annulla;
    }
}