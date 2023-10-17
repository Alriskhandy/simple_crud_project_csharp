namespace Simple_crud_C_
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
            label_id = new Label();
            label_name = new Label();
            label_address = new Label();
            label_salary = new Label();
            txtid = new TextBox();
            txtfind = new TextBox();
            btn_insert = new Button();
            btn_find = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            txtname = new TextBox();
            txtaddress = new TextBox();
            txtsalary = new TextBox();
            btn_read = new Button();
            btn_exit = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label_id
            // 
            label_id.AutoSize = true;
            label_id.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_id.Location = new Point(27, 33);
            label_id.Name = "label_id";
            label_id.Size = new Size(29, 28);
            label_id.TabIndex = 0;
            label_id.Text = "Id";
            label_id.Click += label1_Click;
            // 
            // label_name
            // 
            label_name.AutoSize = true;
            label_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_name.Location = new Point(25, 80);
            label_name.Name = "label_name";
            label_name.Size = new Size(64, 28);
            label_name.TabIndex = 1;
            label_name.Text = "Name";
            label_name.Click += label2_Click;
            // 
            // label_address
            // 
            label_address.AutoSize = true;
            label_address.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_address.Location = new Point(25, 131);
            label_address.Name = "label_address";
            label_address.Size = new Size(82, 28);
            label_address.TabIndex = 2;
            label_address.Text = "Address";
            // 
            // label_salary
            // 
            label_salary.AutoSize = true;
            label_salary.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_salary.Location = new Point(27, 181);
            label_salary.Name = "label_salary";
            label_salary.Size = new Size(65, 28);
            label_salary.TabIndex = 3;
            label_salary.Text = "Salary";
            // 
            // txtid
            // 
            txtid.Location = new Point(158, 33);
            txtid.Name = "txtid";
            txtid.Size = new Size(250, 27);
            txtid.TabIndex = 4;
            // 
            // txtfind
            // 
            txtfind.Location = new Point(457, 32);
            txtfind.Name = "txtfind";
            txtfind.Size = new Size(387, 27);
            txtfind.TabIndex = 8;
            txtfind.TextChanged += textBox5_TextChanged;
            // 
            // btn_insert
            // 
            btn_insert.AccessibleName = "btninsert";
            btn_insert.Location = new Point(27, 247);
            btn_insert.Name = "btn_insert";
            btn_insert.Size = new Size(123, 38);
            btn_insert.TabIndex = 9;
            btn_insert.Text = "Insert";
            btn_insert.UseVisualStyleBackColor = true;
            btn_insert.Click += button1_Click;
            // 
            // btn_find
            // 
            btn_find.BackColor = Color.MediumSpringGreen;
            btn_find.Location = new Point(891, 29);
            btn_find.Name = "btn_find";
            btn_find.Size = new Size(119, 35);
            btn_find.TabIndex = 14;
            btn_find.Text = "Find";
            btn_find.UseVisualStyleBackColor = false;
            btn_find.Click += button6_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(156, 247);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(123, 38);
            btn_update.TabIndex = 15;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += button2_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(285, 247);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(123, 38);
            btn_delete.TabIndex = 16;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // txtname
            // 
            txtname.Location = new Point(156, 80);
            txtname.Name = "txtname";
            txtname.Size = new Size(250, 27);
            txtname.TabIndex = 17;
            // 
            // txtaddress
            // 
            txtaddress.Location = new Point(158, 131);
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new Size(250, 27);
            txtaddress.TabIndex = 18;
            // 
            // txtsalary
            // 
            txtsalary.Location = new Point(158, 181);
            txtsalary.Name = "txtsalary";
            txtsalary.Size = new Size(250, 27);
            txtsalary.TabIndex = 19;
            // 
            // btn_read
            // 
            btn_read.Location = new Point(27, 333);
            btn_read.Name = "btn_read";
            btn_read.Size = new Size(123, 38);
            btn_read.TabIndex = 20;
            btn_read.Text = "Show All";
            btn_read.UseVisualStyleBackColor = true;
            btn_read.Click += btn_read_Click;
            // 
            // btn_exit
            // 
            btn_exit.BackColor = Color.Red;
            btn_exit.ForeColor = SystemColors.ButtonHighlight;
            btn_exit.Location = new Point(285, 333);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(123, 38);
            btn_exit.TabIndex = 21;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = false;
            btn_exit.Click += btn_exit_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(457, 80);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(553, 291);
            dataGridView1.TabIndex = 22;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1033, 393);
            Controls.Add(dataGridView1);
            Controls.Add(btn_exit);
            Controls.Add(btn_read);
            Controls.Add(txtsalary);
            Controls.Add(txtaddress);
            Controls.Add(txtname);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_find);
            Controls.Add(btn_insert);
            Controls.Add(txtfind);
            Controls.Add(txtid);
            Controls.Add(label_salary);
            Controls.Add(label_address);
            Controls.Add(label_name);
            Controls.Add(label_id);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_id;
        private Label label_name;
        private Label label_address;
        private Label label_salary;
        private TextBox txtid;
        private TextBox txtfind;
        private TextBox txtname;
        private TextBox txtaddress;
        private TextBox txtsalary;
        private Button btn_insert;
        private Button btn_find;
        private Button btn_update;
        private Button btn_delete;
        private Button btn_read;
        private Button btn_exit;
        private DataGridView dataGridView1;

    }
}