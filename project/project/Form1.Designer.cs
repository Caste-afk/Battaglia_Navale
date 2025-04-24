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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dgv_Campo = new DataGridView();
            C0 = new DataGridViewTextBoxColumn();
            C1 = new DataGridViewButtonColumn();
            C2 = new DataGridViewButtonColumn();
            C3 = new DataGridViewButtonColumn();
            C4 = new DataGridViewButtonColumn();
            C5 = new DataGridViewButtonColumn();
            C6 = new DataGridViewButtonColumn();
            C7 = new DataGridViewButtonColumn();
            C8 = new DataGridViewButtonColumn();
            C9 = new DataGridViewButtonColumn();
            C10 = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgv_Campo).BeginInit();
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
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_Campo.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_Campo.ImeMode = ImeMode.NoControl;
            dgv_Campo.Location = new Point(118, 25);
            dgv_Campo.MultiSelect = false;
            dgv_Campo.Name = "dgv_Campo";
            dgv_Campo.RowHeadersVisible = false;
            dgv_Campo.RowHeadersWidth = 40;
            dgv_Campo.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.TopCenter;
            dgv_Campo.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgv_Campo.RowTemplate.Height = 70;
            dgv_Campo.ScrollBars = ScrollBars.None;
            dgv_Campo.Size = new Size(775, 735);
            dgv_Campo.TabIndex = 0;
            dgv_Campo.CellContentClick += dgv_Campo_CellContentClick;
            // 
            // C0
            // 
            C0.Frozen = true;
            C0.HeaderText = " ";
            C0.Name = "C0";
            C0.ReadOnly = true;
            C0.Width = 70;
            // 
            // C1
            // 
            C1.HeaderText = "A";
            C1.Name = "C1";
            C1.Width = 70;
            // 
            // C2
            // 
            C2.HeaderText = "B";
            C2.Name = "C2";
            C2.Width = 70;
            // 
            // C3
            // 
            C3.HeaderText = "C";
            C3.Name = "C3";
            C3.Width = 70;
            // 
            // C4
            // 
            C4.HeaderText = "D";
            C4.Name = "C4";
            C4.Width = 70;
            // 
            // C5
            // 
            C5.HeaderText = "E";
            C5.Name = "C5";
            C5.Width = 70;
            // 
            // C6
            // 
            C6.HeaderText = "F";
            C6.Name = "C6";
            C6.Width = 70;
            // 
            // C7
            // 
            C7.HeaderText = "G";
            C7.Name = "C7";
            C7.Width = 70;
            // 
            // C8
            // 
            C8.HeaderText = "H";
            C8.Name = "C8";
            C8.Width = 70;
            // 
            // C9
            // 
            C9.HeaderText = "I";
            C9.Name = "C9";
            C9.Width = 70;
            // 
            // C10
            // 
            C10.HeaderText = "F";
            C10.Name = "C10";
            C10.Width = 70;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1009, 847);
            Controls.Add(dgv_Campo);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgv_Campo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_Campo;
        private DataGridViewTextBoxColumn C0;
        private DataGridViewButtonColumn C1;
        private DataGridViewButtonColumn C2;
        private DataGridViewButtonColumn C3;
        private DataGridViewButtonColumn C4;
        private DataGridViewButtonColumn C5;
        private DataGridViewButtonColumn C6;
        private DataGridViewButtonColumn C7;
        private DataGridViewButtonColumn C8;
        private DataGridViewButtonColumn C9;
        private DataGridViewButtonColumn C10;
    }
}