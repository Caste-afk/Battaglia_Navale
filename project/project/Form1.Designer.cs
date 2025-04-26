namespace project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            dgv_Campo = new DataGridView();
            C0 = new DataGridViewTextBoxColumn();
            C1 = new DataGridViewTextBoxColumn();
            C2 = new DataGridViewTextBoxColumn();
            C3 = new DataGridViewTextBoxColumn();
            C4 = new DataGridViewTextBoxColumn();
            C5 = new DataGridViewTextBoxColumn();
            C6 = new DataGridViewTextBoxColumn();
            C7 = new DataGridViewTextBoxColumn();
            C8 = new DataGridViewTextBoxColumn();
            C9 = new DataGridViewTextBoxColumn();
            C10 = new DataGridViewTextBoxColumn();
            lbl_tentativi = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            lbl_vinto = new Label();
            lbl_naviaffondate = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            btn_NuovaPartita = new Button();
            btn_Salva = new Button();
            dgv_partitetot = new DataGridView();
            c0b = new DataGridViewTextBoxColumn();
            c1b = new DataGridViewTextBoxColumn();
            c2b = new DataGridViewTextBoxColumn();
            lbl_ris = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_Campo).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_partitetot).BeginInit();
            SuspendLayout();
            // 
            // dgv_Campo
            // 
            dgv_Campo.AllowUserToAddRows = false;
            dgv_Campo.AllowUserToDeleteRows = false;
            dgv_Campo.AllowUserToResizeColumns = false;
            dgv_Campo.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter;
            dgv_Campo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv_Campo.Anchor = AnchorStyles.Top;
            dgv_Campo.BackgroundColor = SystemColors.ControlLightLight;
            dgv_Campo.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Ink Free", 11.9999981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv_Campo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv_Campo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Campo.Columns.AddRange(new DataGridViewColumn[] { C0, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10 });
            dgv_Campo.Cursor = Cursors.Hand;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle14.BackColor = Color.White;
            dataGridViewCellStyle14.Font = new Font("Ink Free", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle14.ForeColor = Color.White;
            dataGridViewCellStyle14.SelectionBackColor = Color.White;
            dataGridViewCellStyle14.SelectionForeColor = Color.Black;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.False;
            dgv_Campo.DefaultCellStyle = dataGridViewCellStyle14;
            dgv_Campo.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgv_Campo.Location = new Point(31, 31);
            dgv_Campo.MultiSelect = false;
            dgv_Campo.Name = "dgv_Campo";
            dgv_Campo.RowHeadersVisible = false;
            dgv_Campo.RowHeadersWidth = 40;
            dgv_Campo.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.TopCenter;
            dgv_Campo.RowsDefaultCellStyle = dataGridViewCellStyle15;
            dgv_Campo.RowTemplate.Height = 70;
            dgv_Campo.ScrollBars = ScrollBars.None;
            dgv_Campo.ShowCellErrors = false;
            dgv_Campo.ShowCellToolTips = false;
            dgv_Campo.ShowEditingIcon = false;
            dgv_Campo.ShowRowErrors = false;
            dgv_Campo.Size = new Size(770, 725);
            dgv_Campo.TabIndex = 0;
            dgv_Campo.CellContentClick += dgv_Campo_CellClick;
            // 
            // C0
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Ink Free", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            C0.DefaultCellStyle = dataGridViewCellStyle3;
            C0.HeaderText = "";
            C0.MinimumWidth = 70;
            C0.Name = "C0";
            C0.Resizable = DataGridViewTriState.False;
            C0.SortMode = DataGridViewColumnSortMode.Programmatic;
            C0.Width = 70;
            // 
            // C1
            // 
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 72F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            C1.DefaultCellStyle = dataGridViewCellStyle4;
            C1.HeaderText = "A";
            C1.MinimumWidth = 70;
            C1.Name = "C1";
            C1.Resizable = DataGridViewTriState.False;
            C1.SortMode = DataGridViewColumnSortMode.Programmatic;
            C1.Width = 70;
            // 
            // C2
            // 
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 72F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            C2.DefaultCellStyle = dataGridViewCellStyle5;
            C2.HeaderText = "B";
            C2.MinimumWidth = 70;
            C2.Name = "C2";
            C2.Resizable = DataGridViewTriState.False;
            C2.SortMode = DataGridViewColumnSortMode.Programmatic;
            C2.Width = 70;
            // 
            // C3
            // 
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 72F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            C3.DefaultCellStyle = dataGridViewCellStyle6;
            C3.HeaderText = "C";
            C3.MinimumWidth = 70;
            C3.Name = "C3";
            C3.Resizable = DataGridViewTriState.False;
            C3.SortMode = DataGridViewColumnSortMode.Programmatic;
            C3.Width = 70;
            // 
            // C4
            // 
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 72F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            C4.DefaultCellStyle = dataGridViewCellStyle7;
            C4.HeaderText = "D";
            C4.MinimumWidth = 70;
            C4.Name = "C4";
            C4.Resizable = DataGridViewTriState.False;
            C4.SortMode = DataGridViewColumnSortMode.Programmatic;
            C4.Width = 70;
            // 
            // C5
            // 
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 72F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            C5.DefaultCellStyle = dataGridViewCellStyle8;
            C5.HeaderText = "E";
            C5.MinimumWidth = 70;
            C5.Name = "C5";
            C5.Resizable = DataGridViewTriState.False;
            C5.SortMode = DataGridViewColumnSortMode.Programmatic;
            C5.Width = 70;
            // 
            // C6
            // 
            dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 72F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            C6.DefaultCellStyle = dataGridViewCellStyle9;
            C6.HeaderText = "F";
            C6.MinimumWidth = 70;
            C6.Name = "C6";
            C6.Resizable = DataGridViewTriState.False;
            C6.SortMode = DataGridViewColumnSortMode.Programmatic;
            C6.Width = 70;
            // 
            // C7
            // 
            dataGridViewCellStyle10.Font = new Font("Microsoft Sans Serif", 72F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            C7.DefaultCellStyle = dataGridViewCellStyle10;
            C7.HeaderText = "G";
            C7.MinimumWidth = 70;
            C7.Name = "C7";
            C7.Resizable = DataGridViewTriState.False;
            C7.SortMode = DataGridViewColumnSortMode.Programmatic;
            C7.Width = 70;
            // 
            // C8
            // 
            dataGridViewCellStyle11.Font = new Font("Microsoft Sans Serif", 72F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            C8.DefaultCellStyle = dataGridViewCellStyle11;
            C8.HeaderText = "H";
            C8.MinimumWidth = 70;
            C8.Name = "C8";
            C8.Resizable = DataGridViewTriState.False;
            C8.SortMode = DataGridViewColumnSortMode.Programmatic;
            C8.Width = 70;
            // 
            // C9
            // 
            dataGridViewCellStyle12.Font = new Font("Microsoft Sans Serif", 72F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            C9.DefaultCellStyle = dataGridViewCellStyle12;
            C9.HeaderText = "I";
            C9.MinimumWidth = 70;
            C9.Name = "C9";
            C9.Resizable = DataGridViewTriState.False;
            C9.SortMode = DataGridViewColumnSortMode.Programmatic;
            C9.Width = 70;
            // 
            // C10
            // 
            dataGridViewCellStyle13.Font = new Font("Microsoft Sans Serif", 72F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            C10.DefaultCellStyle = dataGridViewCellStyle13;
            C10.HeaderText = "J";
            C10.MinimumWidth = 70;
            C10.Name = "C10";
            C10.Resizable = DataGridViewTriState.False;
            C10.SortMode = DataGridViewColumnSortMode.Programmatic;
            C10.Width = 70;
            // 
            // lbl_tentativi
            // 
            lbl_tentativi.Font = new Font("Ink Free", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl_tentativi.ForeColor = Color.White;
            lbl_tentativi.Location = new Point(3, 0);
            lbl_tentativi.Name = "lbl_tentativi";
            lbl_tentativi.Size = new Size(388, 81);
            lbl_tentativi.TabIndex = 1;
            lbl_tentativi.Text = "Tentativi: ";
            lbl_tentativi.TextAlign = ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(lbl_vinto, 0, 2);
            tableLayoutPanel1.Controls.Add(lbl_naviaffondate, 0, 1);
            tableLayoutPanel1.Controls.Add(lbl_tentativi, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 3);
            tableLayoutPanel1.Location = new Point(843, 31);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(394, 325);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // lbl_vinto
            // 
            lbl_vinto.BackColor = Color.Transparent;
            lbl_vinto.Font = new Font("Ink Free", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl_vinto.ForeColor = Color.IndianRed;
            lbl_vinto.Location = new Point(3, 162);
            lbl_vinto.Name = "lbl_vinto";
            lbl_vinto.Size = new Size(388, 81);
            lbl_vinto.TabIndex = 3;
            lbl_vinto.Text = "HAI VINTO!!";
            lbl_vinto.TextAlign = ContentAlignment.TopCenter;
            lbl_vinto.Visible = false;
            // 
            // lbl_naviaffondate
            // 
            lbl_naviaffondate.Font = new Font("Ink Free", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl_naviaffondate.ForeColor = Color.White;
            lbl_naviaffondate.Location = new Point(3, 81);
            lbl_naviaffondate.Name = "lbl_naviaffondate";
            lbl_naviaffondate.Size = new Size(388, 81);
            lbl_naviaffondate.TabIndex = 2;
            lbl_naviaffondate.Text = "Navi affondate: ";
            lbl_naviaffondate.TextAlign = ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(btn_NuovaPartita, 1, 0);
            tableLayoutPanel2.Controls.Add(btn_Salva, 0, 0);
            tableLayoutPanel2.Location = new Point(3, 246);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(388, 76);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // btn_NuovaPartita
            // 
            btn_NuovaPartita.BackColor = Color.RoyalBlue;
            btn_NuovaPartita.Cursor = Cursors.Hand;
            btn_NuovaPartita.FlatStyle = FlatStyle.Popup;
            btn_NuovaPartita.Font = new Font("Ink Free", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btn_NuovaPartita.ForeColor = Color.White;
            btn_NuovaPartita.Location = new Point(197, 3);
            btn_NuovaPartita.Name = "btn_NuovaPartita";
            btn_NuovaPartita.Size = new Size(188, 70);
            btn_NuovaPartita.TabIndex = 1;
            btn_NuovaPartita.Text = "Nuova Partita";
            btn_NuovaPartita.UseVisualStyleBackColor = false;
            btn_NuovaPartita.Visible = false;
            btn_NuovaPartita.Click += btn_NuovaPartita_Click;
            // 
            // btn_Salva
            // 
            btn_Salva.BackColor = Color.RoyalBlue;
            btn_Salva.BackgroundImageLayout = ImageLayout.Center;
            btn_Salva.Cursor = Cursors.Hand;
            btn_Salva.FlatStyle = FlatStyle.Popup;
            btn_Salva.Font = new Font("Ink Free", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btn_Salva.ForeColor = Color.White;
            btn_Salva.Location = new Point(3, 3);
            btn_Salva.Name = "btn_Salva";
            btn_Salva.Size = new Size(188, 70);
            btn_Salva.TabIndex = 0;
            btn_Salva.Text = "Salva punteggio";
            btn_Salva.UseVisualStyleBackColor = false;
            btn_Salva.Visible = false;
            btn_Salva.Click += btn_Salva_Click;
            // 
            // dgv_partitetot
            // 
            dgv_partitetot.AllowUserToAddRows = false;
            dgv_partitetot.AllowUserToDeleteRows = false;
            dgv_partitetot.AllowUserToResizeColumns = false;
            dgv_partitetot.AllowUserToResizeRows = false;
            dgv_partitetot.BackgroundColor = Color.White;
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = Color.RoyalBlue;
            dataGridViewCellStyle16.Font = new Font("Ink Free", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle16.ForeColor = SystemColors.Window;
            dataGridViewCellStyle16.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle16.SelectionForeColor = Color.White;
            dataGridViewCellStyle16.WrapMode = DataGridViewTriState.True;
            dgv_partitetot.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            dgv_partitetot.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_partitetot.Columns.AddRange(new DataGridViewColumn[] { c0b, c1b, c2b });
            dataGridViewCellStyle20.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = Color.RoyalBlue;
            dataGridViewCellStyle20.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle20.ForeColor = Color.White;
            dataGridViewCellStyle20.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle20.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = DataGridViewTriState.False;
            dgv_partitetot.DefaultCellStyle = dataGridViewCellStyle20;
            dgv_partitetot.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgv_partitetot.Location = new Point(849, 451);
            dgv_partitetot.Name = "dgv_partitetot";
            dgv_partitetot.RowHeadersVisible = false;
            dgv_partitetot.RowTemplate.Height = 25;
            dgv_partitetot.ShowCellErrors = false;
            dgv_partitetot.ShowCellToolTips = false;
            dgv_partitetot.ShowEditingIcon = false;
            dgv_partitetot.ShowRowErrors = false;
            dgv_partitetot.Size = new Size(388, 315);
            dgv_partitetot.TabIndex = 3;
            // 
            // c0b
            // 
            dataGridViewCellStyle17.Font = new Font("Ink Free", 13F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            c0b.DefaultCellStyle = dataGridViewCellStyle17;
            c0b.HeaderText = " Classifica";
            c0b.Name = "c0b";
            c0b.ReadOnly = true;
            c0b.Width = 128;
            // 
            // c1b
            // 
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle18.Font = new Font("Ink Free", 13F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            c1b.DefaultCellStyle = dataGridViewCellStyle18;
            c1b.HeaderText = "Nome";
            c1b.Name = "c1b";
            c1b.ReadOnly = true;
            c1b.Width = 128;
            // 
            // c2b
            // 
            dataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle19.Font = new Font("Ink Free", 13F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            c2b.DefaultCellStyle = dataGridViewCellStyle19;
            c2b.HeaderText = "Tentativi";
            c2b.Name = "c2b";
            c2b.ReadOnly = true;
            c2b.Width = 128;
            // 
            // lbl_ris
            // 
            lbl_ris.BackColor = Color.Transparent;
            lbl_ris.Font = new Font("Ink Free", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl_ris.ForeColor = Color.White;
            lbl_ris.Location = new Point(849, 415);
            lbl_ris.Name = "lbl_ris";
            lbl_ris.Size = new Size(385, 33);
            lbl_ris.TabIndex = 4;
            lbl_ris.Text = "Risultati migliori";
            lbl_ris.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(1249, 800);
            Controls.Add(lbl_ris);
            Controls.Add(dgv_partitetot);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(dgv_Campo);
            ForeColor = Color.White;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgv_Campo).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_partitetot).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lbl_tentativi;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lbl_naviaffondate;
        private DataGridView dgv_Campo;
        private Label lbl_vinto;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btn_NuovaPartita;
        private Button btn_Salva;
        private DataGridView dgv_partitetot;
        private Label lbl_ris;
        private DataGridViewTextBoxColumn c0b;
        private DataGridViewTextBoxColumn c1b;
        private DataGridViewTextBoxColumn c2b;
        private DataGridViewTextBoxColumn C0;
        private DataGridViewTextBoxColumn C1;
        private DataGridViewTextBoxColumn C2;
        private DataGridViewTextBoxColumn C3;
        private DataGridViewTextBoxColumn C4;
        private DataGridViewTextBoxColumn C5;
        private DataGridViewTextBoxColumn C6;
        private DataGridViewTextBoxColumn C7;
        private DataGridViewTextBoxColumn C8;
        private DataGridViewTextBoxColumn C9;
        private DataGridViewTextBoxColumn C10;
    }
}