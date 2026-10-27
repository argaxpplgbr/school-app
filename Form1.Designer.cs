namespace SchoolApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlNav = new Panel();
            btnNavStudent = new Button();
            btnNavVisitor = new Button();
            pnlStudent = new Panel();
            pnlVisitor = new Panel();

            label1 = new Label();
            label2 = new Label();
            lblClass = new Label();
            lblAddress = new Label();
            txtName = new TextBox();
            txtNIS = new TextBox();
            txtClass = new TextBox();
            txtAddress = new TextBox();
            txtSearchStudent = new TextBox();
            btnSave = new Button();
            btnUpdateStudent = new Button();
            btnDeleteStudent = new Button();
            dgvData = new DataGridView();

            label3 = new Label();
            label4 = new Label();
            txtVisitors = new TextBox();
            txtInstitution = new TextBox();
            btnSaveVisitors = new Button();
            btnUpdateVisitors = new Button();
            btnDeleteVisitors = new Button();
            dgvVisitors = new DataGridView();

            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvVisitors).BeginInit();
            pnlNav.SuspendLayout();
            pnlStudent.SuspendLayout();
            pnlVisitor.SuspendLayout();
            SuspendLayout();
            //
            // pnlNav (menu navigasi di atas)
            //
            pnlNav.BackColor = SystemColors.ActiveCaption;
            pnlNav.Controls.Add(btnNavVisitor);
            pnlNav.Controls.Add(btnNavStudent);
            pnlNav.Dock = DockStyle.Top;
            pnlNav.Name = "pnlNav";
            pnlNav.Size = new Size(919, 50);
            pnlNav.TabIndex = 0;
            //
            // btnNavStudent
            //
            btnNavStudent.FlatStyle = FlatStyle.Flat;
            btnNavStudent.Location = new Point(12, 10);
            btnNavStudent.Name = "btnNavStudent";
            btnNavStudent.Size = new Size(140, 30);
            btnNavStudent.TabIndex = 0;
            btnNavStudent.Text = "Students";
            btnNavStudent.UseVisualStyleBackColor = false;
            //
            // btnNavVisitor
            //
            btnNavVisitor.FlatStyle = FlatStyle.Flat;
            btnNavVisitor.Location = new Point(158, 10);
            btnNavVisitor.Name = "btnNavVisitor";
            btnNavVisitor.Size = new Size(140, 30);
            btnNavVisitor.TabIndex = 1;
            btnNavVisitor.Text = "Visitors";
            btnNavVisitor.UseVisualStyleBackColor = false;
            //
            // pnlStudent (halaman Students)
            //
            pnlStudent.Controls.Add(dgvData);
            pnlStudent.Controls.Add(txtSearchStudent);
            pnlStudent.Controls.Add(btnDeleteStudent);
            pnlStudent.Controls.Add(btnUpdateStudent);
            pnlStudent.Controls.Add(btnSave);
            pnlStudent.Controls.Add(txtAddress);
            pnlStudent.Controls.Add(lblAddress);
            pnlStudent.Controls.Add(txtClass);
            pnlStudent.Controls.Add(lblClass);
            pnlStudent.Controls.Add(txtNIS);
            pnlStudent.Controls.Add(label2);
            pnlStudent.Controls.Add(txtName);
            pnlStudent.Controls.Add(label1);
            pnlStudent.Dock = DockStyle.Fill;
            pnlStudent.Name = "pnlStudent";
            pnlStudent.TabIndex = 1;
            //
            // label1
            //
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(224, 35);
            label1.TabIndex = 0;
            label1.Text = "STUDENTS NAME";
            //
            // txtName
            //
            txtName.BackColor = SystemColors.InactiveCaption;
            txtName.Location = new Point(12, 50);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "masukan nama....";
            txtName.Size = new Size(280, 27);
            txtName.TabIndex = 1;
            //
            // label2
            //
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(12, 92);
            label2.Name = "label2";
            label2.Size = new Size(279, 35);
            label2.TabIndex = 2;
            label2.Text = "NOMER INDUK SISWA";
            //
            // txtNIS
            //
            txtNIS.BackColor = SystemColors.InactiveCaption;
            txtNIS.Location = new Point(12, 130);
            txtNIS.Name = "txtNIS";
            txtNIS.PlaceholderText = "masukan nis....";
            txtNIS.Size = new Size(280, 27);
            txtNIS.TabIndex = 3;
            //
            // lblClass
            //
            lblClass.AutoSize = true;
            lblClass.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblClass.ForeColor = SystemColors.ActiveCaption;
            lblClass.Location = new Point(340, 12);
            lblClass.Name = "lblClass";
            lblClass.Size = new Size(80, 35);
            lblClass.TabIndex = 4;
            lblClass.Text = "KELAS";
            //
            // txtClass
            //
            txtClass.BackColor = SystemColors.InactiveCaption;
            txtClass.Location = new Point(340, 50);
            txtClass.Name = "txtClass";
            txtClass.PlaceholderText = "contoh: XII RPL 1";
            txtClass.Size = new Size(280, 27);
            txtClass.TabIndex = 5;
            //
            // lblAddress
            //
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblAddress.ForeColor = SystemColors.ActiveCaption;
            lblAddress.Location = new Point(340, 92);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(100, 35);
            lblAddress.TabIndex = 6;
            lblAddress.Text = "ALAMAT";
            //
            // txtAddress
            //
            txtAddress.BackColor = SystemColors.InactiveCaption;
            txtAddress.Location = new Point(340, 130);
            txtAddress.Name = "txtAddress";
            txtAddress.PlaceholderText = "masukan alamat....";
            txtAddress.Size = new Size(280, 27);
            txtAddress.TabIndex = 7;
            //
            // btnSave
            //
            btnSave.BackColor = SystemColors.GradientActiveCaption;
            btnSave.Location = new Point(12, 180);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            //
            // btnUpdateStudent
            //
            btnUpdateStudent.BackColor = SystemColors.GradientActiveCaption;
            btnUpdateStudent.Location = new Point(112, 180);
            btnUpdateStudent.Name = "btnUpdateStudent";
            btnUpdateStudent.Size = new Size(94, 29);
            btnUpdateStudent.TabIndex = 9;
            btnUpdateStudent.Text = "Update";
            btnUpdateStudent.UseVisualStyleBackColor = false;
            //
            // btnDeleteStudent
            //
            btnDeleteStudent.BackColor = SystemColors.GradientActiveCaption;
            btnDeleteStudent.Location = new Point(212, 180);
            btnDeleteStudent.Name = "btnDeleteStudent";
            btnDeleteStudent.Size = new Size(94, 29);
            btnDeleteStudent.TabIndex = 10;
            btnDeleteStudent.Text = "Delete";
            btnDeleteStudent.UseVisualStyleBackColor = false;
            //
            // txtSearchStudent
            //
            txtSearchStudent.BackColor = SystemColors.InactiveCaption;
            txtSearchStudent.Location = new Point(12, 226);
            txtSearchStudent.Name = "txtSearchStudent";
            txtSearchStudent.PlaceholderText = "cari nama / NIS / kelas...";
            txtSearchStudent.Size = new Size(300, 27);
            txtSearchStudent.TabIndex = 11;
            //
            // dgvData
            //
            dgvData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvData.BackgroundColor = SystemColors.GradientInactiveCaption;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(12, 262);
            dgvData.Name = "dgvData";
            dgvData.RowHeadersWidth = 51;
            dgvData.Size = new Size(895, 340);
            dgvData.TabIndex = 12;
            //
            // pnlVisitor (halaman Visitors)
            //
            pnlVisitor.Controls.Add(dgvVisitors);
            pnlVisitor.Controls.Add(btnDeleteVisitors);
            pnlVisitor.Controls.Add(btnUpdateVisitors);
            pnlVisitor.Controls.Add(btnSaveVisitors);
            pnlVisitor.Controls.Add(txtInstitution);
            pnlVisitor.Controls.Add(label4);
            pnlVisitor.Controls.Add(txtVisitors);
            pnlVisitor.Controls.Add(label3);
            pnlVisitor.Dock = DockStyle.Fill;
            pnlVisitor.Name = "pnlVisitor";
            pnlVisitor.TabIndex = 2;
            pnlVisitor.Visible = false;
            //
            // label3
            //
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            label3.ForeColor = SystemColors.ActiveCaption;
            label3.Location = new Point(12, 12);
            label3.Name = "label3";
            label3.Size = new Size(125, 35);
            label3.TabIndex = 0;
            label3.Text = "VISITORS";
            //
            // txtVisitors
            //
            txtVisitors.BackColor = SystemColors.InactiveCaption;
            txtVisitors.Location = new Point(12, 50);
            txtVisitors.Name = "txtVisitors";
            txtVisitors.PlaceholderText = "masukan visitors...";
            txtVisitors.Size = new Size(280, 27);
            txtVisitors.TabIndex = 1;
            //
            // label4
            //
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            label4.ForeColor = SystemColors.ActiveCaption;
            label4.Location = new Point(12, 92);
            label4.Name = "label4";
            label4.Size = new Size(175, 35);
            label4.TabIndex = 2;
            label4.Text = "INSTITUTION";
            //
            // txtInstitution
            //
            txtInstitution.BackColor = SystemColors.InactiveCaption;
            txtInstitution.Location = new Point(12, 130);
            txtInstitution.Name = "txtInstitution";
            txtInstitution.PlaceholderText = "masukan institusi...";
            txtInstitution.Size = new Size(280, 27);
            txtInstitution.TabIndex = 3;
            //
            // btnSaveVisitors
            //
            btnSaveVisitors.BackColor = SystemColors.GradientActiveCaption;
            btnSaveVisitors.Location = new Point(12, 180);
            btnSaveVisitors.Name = "btnSaveVisitors";
            btnSaveVisitors.Size = new Size(94, 29);
            btnSaveVisitors.TabIndex = 4;
            btnSaveVisitors.Text = "Save";
            btnSaveVisitors.UseVisualStyleBackColor = false;
            //
            // btnUpdateVisitors
            //
            btnUpdateVisitors.BackColor = SystemColors.GradientActiveCaption;
            btnUpdateVisitors.Location = new Point(112, 180);
            btnUpdateVisitors.Name = "btnUpdateVisitors";
            btnUpdateVisitors.Size = new Size(94, 29);
            btnUpdateVisitors.TabIndex = 5;
            btnUpdateVisitors.Text = "Update";
            btnUpdateVisitors.UseVisualStyleBackColor = false;
            //
            // btnDeleteVisitors
            //
            btnDeleteVisitors.BackColor = SystemColors.GradientActiveCaption;
            btnDeleteVisitors.Location = new Point(212, 180);
            btnDeleteVisitors.Name = "btnDeleteVisitors";
            btnDeleteVisitors.Size = new Size(94, 29);
            btnDeleteVisitors.TabIndex = 6;
            btnDeleteVisitors.Text = "Delete";
            btnDeleteVisitors.UseVisualStyleBackColor = false;
            //
            // dgvVisitors
            //
            dgvVisitors.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvVisitors.BackgroundColor = SystemColors.GradientInactiveCaption;
            dgvVisitors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVisitors.Location = new Point(12, 226);
            dgvVisitors.Name = "dgvVisitors";
            dgvVisitors.RowHeadersWidth = 51;
            dgvVisitors.Size = new Size(895, 376);
            dgvVisitors.TabIndex = 7;
            //
            // Form1
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(919, 625);
            Controls.Add(pnlStudent);
            Controls.Add(pnlVisitor);
            Controls.Add(pnlNav);
            Name = "Form1";
            Text = "School App";
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvVisitors).EndInit();
            pnlNav.ResumeLayout(false);
            pnlStudent.ResumeLayout(false);
            pnlStudent.PerformLayout();
            pnlVisitor.ResumeLayout(false);
            pnlVisitor.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlNav;
        private Button btnNavStudent;
        private Button btnNavVisitor;
        private Panel pnlStudent;
        private Panel pnlVisitor;

        private Label label1;
        private Label label2;
        private Label lblClass;
        private Label lblAddress;
        private TextBox txtName;
        private TextBox txtNIS;
        private TextBox txtClass;
        private TextBox txtAddress;
        private TextBox txtSearchStudent;
        private Button btnSave;
        private Button btnUpdateStudent;
        private Button btnDeleteStudent;
        private DataGridView dgvData;

        private Label label3;
        private Label label4;
        private TextBox txtVisitors;
        private TextBox txtInstitution;
        private Button btnSaveVisitors;
        private Button btnUpdateVisitors;
        private Button btnDeleteVisitors;
        private DataGridView dgvVisitors;
    }
}
