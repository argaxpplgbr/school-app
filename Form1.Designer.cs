namespace SchoolApp
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
            label1 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            txtNIS = new TextBox();
            btnSave = new Button();
            dgvData = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            txtVisitors = new TextBox();
            txtInstitution = new TextBox();
            btnSaveVisitors = new Button();
            dgvVisitors = new DataGridView();
            btnUpdateStudent = new Button();
            btnDeleteStudent = new Button();
            btnUpdateVisitors = new Button();
            btnDeleteVisitors = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvVisitors).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(12, 46);
            label1.Name = "label1";
            label1.Size = new Size(224, 35);
            label1.TabIndex = 0;
            label1.Text = "STUDENTS NAME";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(12, 144);
            label2.Name = "label2";
            label2.Size = new Size(279, 35);
            label2.TabIndex = 1;
            label2.Text = "NOMER INDUK SISWA";
            label2.Click += label2_Click;
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.InactiveCaption;
            txtName.Location = new Point(12, 84);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "masukan nama....";
            txtName.Size = new Size(175, 27);
            txtName.TabIndex = 2;
            // 
            // txtNIS
            // 
            txtNIS.BackColor = SystemColors.InactiveCaption;
            txtNIS.Location = new Point(12, 182);
            txtNIS.Name = "txtNIS";
            txtNIS.PlaceholderText = "masukan nis....";
            txtNIS.Size = new Size(175, 27);
            txtNIS.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.GradientActiveCaption;
            btnSave.Location = new Point(12, 253);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(102, 29);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // dgvData
            // 
            dgvData.BackgroundColor = SystemColors.GradientInactiveCaption;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(12, 302);
            dgvData.Name = "dgvData";
            dgvData.RowHeadersWidth = 51;
            dgvData.Size = new Size(393, 281);
            dgvData.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            label3.ForeColor = SystemColors.ActiveCaption;
            label3.Location = new Point(491, 46);
            label3.Name = "label3";
            label3.Size = new Size(125, 35);
            label3.TabIndex = 6;
            label3.Text = "VISITORS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            label4.ForeColor = SystemColors.ActiveCaption;
            label4.Location = new Point(491, 144);
            label4.Name = "label4";
            label4.Size = new Size(175, 35);
            label4.TabIndex = 7;
            label4.Text = "INSTITUTION";
            // 
            // txtVisitors
            // 
            txtVisitors.BackColor = SystemColors.InactiveCaption;
            txtVisitors.Location = new Point(491, 84);
            txtVisitors.Name = "txtVisitors";
            txtVisitors.PlaceholderText = "masukan visitors...";
            txtVisitors.Size = new Size(209, 27);
            txtVisitors.TabIndex = 8;
            // 
            // txtInstitution
            // 
            txtInstitution.BackColor = SystemColors.InactiveCaption;
            txtInstitution.Location = new Point(491, 182);
            txtInstitution.Name = "txtInstitution";
            txtInstitution.PlaceholderText = "masukan institusi...";
            txtInstitution.Size = new Size(209, 27);
            txtInstitution.TabIndex = 9;
            // 
            // btnSaveVisitors
            // 
            btnSaveVisitors.BackColor = SystemColors.GradientActiveCaption;
            btnSaveVisitors.Location = new Point(491, 253);
            btnSaveVisitors.Name = "btnSaveVisitors";
            btnSaveVisitors.Size = new Size(94, 29);
            btnSaveVisitors.TabIndex = 10;
            btnSaveVisitors.Text = "save";
            btnSaveVisitors.UseVisualStyleBackColor = false;
            // 
            // dgvVisitors
            // 
            dgvVisitors.BackgroundColor = SystemColors.GradientInactiveCaption;
            dgvVisitors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVisitors.Location = new Point(491, 302);
            dgvVisitors.Name = "dgvVisitors";
            dgvVisitors.RowHeadersWidth = 51;
            dgvVisitors.Size = new Size(393, 281);
            dgvVisitors.TabIndex = 11;
            // 
            // btnUpdateStudent
            // 
            btnUpdateStudent.BackColor = SystemColors.GradientActiveCaption;
            btnUpdateStudent.Font = new Font("Segoe UI", 9F);
            btnUpdateStudent.ForeColor = SystemColors.ActiveCaptionText;
            btnUpdateStudent.Location = new Point(120, 253);
            btnUpdateStudent.Name = "btnUpdateStudent";
            btnUpdateStudent.Size = new Size(94, 29);
            btnUpdateStudent.TabIndex = 12;
            btnUpdateStudent.Text = "Update";
            btnUpdateStudent.UseVisualStyleBackColor = false;
            // 
            // btnDeleteStudent
            // 
            btnDeleteStudent.BackColor = SystemColors.GradientActiveCaption;
            btnDeleteStudent.Location = new Point(220, 253);
            btnDeleteStudent.Name = "btnDeleteStudent";
            btnDeleteStudent.Size = new Size(94, 29);
            btnDeleteStudent.TabIndex = 13;
            btnDeleteStudent.Text = "Delete";
            btnDeleteStudent.UseVisualStyleBackColor = false;
            // 
            // btnUpdateVisitors
            // 
            btnUpdateVisitors.BackColor = SystemColors.GradientActiveCaption;
            btnUpdateVisitors.Location = new Point(591, 253);
            btnUpdateVisitors.Name = "btnUpdateVisitors";
            btnUpdateVisitors.Size = new Size(94, 29);
            btnUpdateVisitors.TabIndex = 14;
            btnUpdateVisitors.Text = "Update";
            btnUpdateVisitors.UseVisualStyleBackColor = false;
            // 
            // btnDeleteVisitors
            // 
            btnDeleteVisitors.BackColor = SystemColors.GradientActiveCaption;
            btnDeleteVisitors.Location = new Point(691, 253);
            btnDeleteVisitors.Name = "btnDeleteVisitors";
            btnDeleteVisitors.Size = new Size(94, 29);
            btnDeleteVisitors.TabIndex = 15;
            btnDeleteVisitors.Text = "Delete";
            btnDeleteVisitors.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(919, 625);
            Controls.Add(btnDeleteVisitors);
            Controls.Add(btnUpdateVisitors);
            Controls.Add(btnDeleteStudent);
            Controls.Add(btnUpdateStudent);
            Controls.Add(dgvVisitors);
            Controls.Add(btnSaveVisitors);
            Controls.Add(txtInstitution);
            Controls.Add(txtVisitors);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dgvData);
            Controls.Add(btnSave);
            Controls.Add(txtNIS);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvVisitors).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtName;
        private TextBox txtNIS;
        private Button btnSave;
        private DataGridView dgvData;
        private Label label3;
        private Label label4;
        private TextBox txtVisitors;
        private TextBox txtInstitution;
        private Button btnSaveVisitors;
        private DataGridView dgvVisitors;
        private Button btnUpdateStudent;
        private Button btnDeleteStudent;
        private Button btnUpdateVisitors;
        private Button btnDeleteVisitors;
    }
}
