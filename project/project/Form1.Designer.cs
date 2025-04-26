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
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            dgv_Campo = new DataGridView();
            lbl_tentativi = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            lbl_naviaffondate = new Label();
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
            ((System.ComponentModel.ISupportInitialize)dgv_Campo).BeginInit();
            tableLayoutPanel1.SuspendLayout();
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
            dgv_Campo.BorderStyle = BorderStyle.Fixed3D;
            dgv_Campo.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dgv_Campo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Campo.Columns.AddRange(new DataGridViewColumn[] { C0, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10 });
            dgv_Campo.Cursor = Cursors.Hand;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle12.BackColor = SystemColors.Window;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
            dgv_Campo.DefaultCellStyle = dataGridViewCellStyle12;
            dgv_Campo.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgv_Campo.Location = new Point(31, 31);
            dgv_Campo.MultiSelect = false;
            dgv_Campo.Name = "dgv_Campo";
            dgv_Campo.RowHeadersVisible = false;
            dgv_Campo.RowHeadersWidth = 40;
            dgv_Campo.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.TopCenter;
            dgv_Campo.RowsDefaultCellStyle = dataGridViewCellStyle13;
            dgv_Campo.RowTemplate.Height = 70;
            dgv_Campo.ScrollBars = ScrollBars.None;
            dgv_Campo.ShowCellErrors = false;
            dgv_Campo.ShowCellToolTips = false;
            dgv_Campo.ShowEditingIcon = false;
            dgv_Campo.ShowRowErrors = false;
            dgv_Campo.Size = new Size(775, 735);
            dgv_Campo.TabIndex = 0;
            dgv_Campo.CellContentClick += dgv_Campo_CellClick;
            // 
            // lbl_tentativi
            // 
            lbl_tentativi.Font = new Font("Ink Free", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl_tentativi.Location = new Point(3, 0);
            lbl_tentativi.Name = "lbl_tentativi";
            lbl_tentativi.Size = new Size(388, 109);
            lbl_tentativi.TabIndex = 1;
            lbl_tentativi.Text = "Tentativi: ";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(lbl_naviaffondate, 0, 1);
            tableLayoutPanel1.Controls.Add(lbl_tentativi, 0, 0);
            tableLayoutPanel1.Location = new Point(843, 31);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(394, 443);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // lbl_naviaffondate
            // 
            lbl_naviaffondate.Font = new Font("Ink Free", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl_naviaffondate.Location = new Point(3, 110);
            lbl_naviaffondate.Name = "lbl_naviaffondate";
            lbl_naviaffondate.Size = new Size(388, 109);
            lbl_naviaffondate.TabIndex = 2;
            lbl_naviaffondate.Text = "Navi affondate: ";
            // 
            // C0
            // 
            C0.HeaderText = "";
            C0.MinimumWidth = 70;
            C0.Name = "C0";
            C0.ReadOnly = true;
            C0.Width = 70;
            // 
            // C1
            // 
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 72F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            C1.DefaultCellStyle = dataGridViewCellStyle2;
            C1.HeaderText = "A";
            C1.MinimumWidth = 70;
            C1.Name = "C1";
            C1.Width = 70;
            // 
            // C2
            // 
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 72F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            C2.DefaultCellStyle = dataGridViewCellStyle3;
            C2.HeaderText = "B";
            C2.MinimumWidth = 70;
            C2.Name = "C2";
            C2.Width = 70;
            // 
            // C3
            // 
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 72F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            C3.DefaultCellStyle = dataGridViewCellStyle4;
            C3.HeaderText = "C";
            C3.MinimumWidth = 70;
            C3.Name = "C3";
            C3.Width = 70;
            // 
            // C4
            // 
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 72F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            C4.DefaultCellStyle = dataGridViewCellStyle5;
            C4.HeaderText = "D";
            C4.MinimumWidth = 70;
            C4.Name = "C4";
            C4.Width = 70;
            // 
            // C5
            // 
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 72F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            C5.DefaultCellStyle = dataGridViewCellStyle6;
            C5.HeaderText = "E";
            C5.MinimumWidth = 70;
            C5.Name = "C5";
            C5.Width = 70;
            // 
            // C6
            // 
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 72F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            C6.DefaultCellStyle = dataGridViewCellStyle7;
            C6.HeaderText = "F";
            C6.MinimumWidth = 70;
            C6.Name = "C6";
            C6.Width = 70;
            // 
            // C7
            // 
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 72F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            C7.DefaultCellStyle = dataGridViewCellStyle8;
            C7.HeaderText = "G";
            C7.MinimumWidth = 70;
            C7.Name = "C7";
            C7.Width = 70;
            // 
            // C8
            // 
            dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 72F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            C8.DefaultCellStyle = dataGridViewCellStyle9;
            C8.HeaderText = "H";
            C8.MinimumWidth = 70;
            C8.Name = "C8";
            C8.Width = 70;
            // 
            // C9
            // 
            dataGridViewCellStyle10.Font = new Font("Microsoft Sans Serif", 72F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            C9.DefaultCellStyle = dataGridViewCellStyle10;
            C9.HeaderText = "I";
            C9.MinimumWidth = 70;
            C9.Name = "C9";
            C9.Width = 70;
            // 
            // C10
            // 
            dataGridViewCellStyle11.Font = new Font("Microsoft Sans Serif", 72F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            C10.DefaultCellStyle = dataGridViewCellStyle11;
            C10.HeaderText = "J";
            C10.MinimumWidth = 70;
            C10.Name = "C10";
            C10.Width = 70;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1249, 847);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(dgv_Campo);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgv_Campo).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label lbl_tentativi;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lbl_naviaffondate;
        private DataGridView dgv_Campo;
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