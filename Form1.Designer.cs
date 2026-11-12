namespace NSchoolApp
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
            txtInstitution = new TextBox();
            btnSave = new Button();
            dgvData = new DataGridView();
            btnUpdate = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.AliceBlue;
            label1.Location = new Point(5, 12);
            label1.Name = "label1";
            label1.Size = new Size(131, 46);
            label1.TabIndex = 0;
            label1.Text = "Visitor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 20F);
            label2.ForeColor = Color.AliceBlue;
            label2.Location = new Point(5, 72);
            label2.Name = "label2";
            label2.Size = new Size(195, 46);
            label2.TabIndex = 1;
            label2.Text = "Institution";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI Black", 10F);
            txtName.Location = new Point(214, 23);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Input yo name cuh!";
            txtName.Size = new Size(208, 30);
            txtName.TabIndex = 2;
            // 
            // txtInstitution
            // 
            txtInstitution.Font = new Font("Segoe UI Black", 10F);
            txtInstitution.Location = new Point(214, 89);
            txtInstitution.Name = "txtInstitution";
            txtInstitution.PlaceholderText = "Enter your institute...";
            txtInstitution.Size = new Size(208, 30);
            txtInstitution.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Gold;
            btnSave.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.Black;
            btnSave.Location = new Point(455, 23);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(148, 95);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(12, 178);
            dgvData.Name = "dgvData";
            dgvData.RowHeadersWidth = 51;
            dgvData.Size = new Size(509, 257);
            dgvData.TabIndex = 5;
            dgvData.CellContentClick += dgvData_CellContentClick;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(0, 0, 192);
            btnUpdate.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.Black;
            btnUpdate.Location = new Point(636, 24);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(98, 95);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(762, 23);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(98, 95);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(951, 481);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(dgvData);
            Controls.Add(btnSave);
            Controls.Add(txtInstitution);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtName;
        private TextBox txtInstitution;
        private Button btnSave;
        private DataGridView dgvData;
        private Button btnUpdate;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnDelete;
    }
}
