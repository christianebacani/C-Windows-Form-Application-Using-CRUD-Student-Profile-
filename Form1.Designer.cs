namespace CS2C_CRUD_BacaniChristiane
{
    partial class StudFrm
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
            txtstudentid = new TextBox();
            txtln = new TextBox();
            txtfn = new TextBox();
            txtmn = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnAdd = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dgstud = new DataGridView();
            btnEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgstud).BeginInit();
            SuspendLayout();
            // 
            // txtstudentid
            // 
            txtstudentid.Location = new Point(143, 12);
            txtstudentid.Name = "txtstudentid";
            txtstudentid.Size = new Size(645, 27);
            txtstudentid.TabIndex = 0;
            // 
            // txtln
            // 
            txtln.Location = new Point(143, 56);
            txtln.Name = "txtln";
            txtln.Size = new Size(645, 27);
            txtln.TabIndex = 1;
            // 
            // txtfn
            // 
            txtfn.Location = new Point(143, 100);
            txtfn.Name = "txtfn";
            txtfn.Size = new Size(645, 27);
            txtfn.TabIndex = 2;
            // 
            // txtmn
            // 
            txtmn.Location = new Point(143, 140);
            txtmn.Name = "txtmn";
            txtmn.Size = new Size(645, 27);
            txtmn.TabIndex = 3;
            txtmn.TextChanged += txtmn_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 19);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 8;
            label1.Text = "Student ID";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 59);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 9;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 107);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 10;
            label3.Text = "First Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 147);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 11;
            label4.Text = "Middle Name";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(89, 400);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 16;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(267, 400);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 18;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(640, 400);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 20;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click_Click;
            // 
            // dgstud
            // 
            dgstud.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgstud.Location = new Point(172, 186);
            dgstud.Name = "dgstud";
            dgstud.RowHeadersWidth = 51;
            dgstud.Size = new Size(548, 188);
            dgstud.TabIndex = 21;
            dgstud.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(461, 400);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 22;
            btnEdit.Text = "EDIT";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click_1;
            // 
            // StudFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEdit);
            Controls.Add(dgstud);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtmn);
            Controls.Add(txtfn);
            Controls.Add(txtln);
            Controls.Add(txtstudentid);
            Name = "StudFrm";
            Text = "frmDashboard";
            Load += StudFrm_Load;
            ((System.ComponentModel.ISupportInitialize)dgstud).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtstudentid;
        private TextBox txtln;
        private TextBox txtfn;
        private TextBox txtmn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnClear;
        private DataGridView dgstud;
        private Button btnEdit;
    }
}
