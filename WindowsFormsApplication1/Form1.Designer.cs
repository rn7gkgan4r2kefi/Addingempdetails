namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.EMPCODE = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Empcodetxt = new System.Windows.Forms.TextBox();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.pexptxt = new System.Windows.Forms.TextBox();
            this.saltxt = new System.Windows.Forms.TextBox();
            this.addrichtxt = new System.Windows.Forms.RichTextBox();
            this.rdb1 = new System.Windows.Forms.RadioButton();
            this.rdb2 = new System.Windows.Forms.RadioButton();
            this.subtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.depttxt = new System.Windows.Forms.TextBox();
            this.employeeDataGridView = new System.Windows.Forms.DataGridView();
            this.empdetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new WindowsFormsApplication1.HRDataSetTableAdapters.EmployeeTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.HRDataSetTableAdapters.TableAdapterManager();
            this.empdetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.empdetailsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.empdetailsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.empCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.joiningDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prevExpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hR1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hR1DataSet = new WindowsFormsApplication1.HR1DataSet();
            this.empdetailsTableAdapter = new WindowsFormsApplication1.HR1DataSetTableAdapters.EmpdetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empdetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empdetailsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empdetailsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empdetailsBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hR1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hR1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(532, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Employee";
            // 
            // EMPCODE
            // 
            this.EMPCODE.AutoSize = true;
            this.EMPCODE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EMPCODE.Location = new System.Drawing.Point(37, 99);
            this.EMPCODE.Name = "EMPCODE";
            this.EMPCODE.Size = new System.Drawing.Size(87, 20);
            this.EMPCODE.TabIndex = 1;
            this.EMPCODE.Text = "Emp Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Department";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "DOB";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Joining Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(37, 397);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Prev Exp";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(37, 452);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Salary";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(37, 521);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Address";
            // 
            // Empcodetxt
            // 
            this.Empcodetxt.Location = new System.Drawing.Point(152, 97);
            this.Empcodetxt.Name = "Empcodetxt";
            this.Empcodetxt.Size = new System.Drawing.Size(192, 22);
            this.Empcodetxt.TabIndex = 10;
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(152, 139);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(370, 22);
            this.nametxt.TabIndex = 11;
            this.nametxt.Tag = "name";
            // 
            // pexptxt
            // 
            this.pexptxt.Location = new System.Drawing.Point(152, 395);
            this.pexptxt.Name = "pexptxt";
            this.pexptxt.Size = new System.Drawing.Size(160, 22);
            this.pexptxt.TabIndex = 14;
            // 
            // saltxt
            // 
            this.saltxt.Location = new System.Drawing.Point(152, 450);
            this.saltxt.Name = "saltxt";
            this.saltxt.Size = new System.Drawing.Size(160, 22);
            this.saltxt.TabIndex = 15;
            // 
            // addrichtxt
            // 
            this.addrichtxt.Location = new System.Drawing.Point(152, 490);
            this.addrichtxt.Name = "addrichtxt";
            this.addrichtxt.Size = new System.Drawing.Size(229, 83);
            this.addrichtxt.TabIndex = 16;
            this.addrichtxt.Text = "";
            // 
            // rdb1
            // 
            this.rdb1.AutoSize = true;
            this.rdb1.Location = new System.Drawing.Point(152, 234);
            this.rdb1.Name = "rdb1";
            this.rdb1.Size = new System.Drawing.Size(59, 21);
            this.rdb1.TabIndex = 18;
            this.rdb1.TabStop = true;
            this.rdb1.Text = "Male";
            this.rdb1.UseVisualStyleBackColor = true;
            // 
            // rdb2
            // 
            this.rdb2.AutoSize = true;
            this.rdb2.Location = new System.Drawing.Point(258, 234);
            this.rdb2.Name = "rdb2";
            this.rdb2.Size = new System.Drawing.Size(75, 21);
            this.rdb2.TabIndex = 19;
            this.rdb2.TabStop = true;
            this.rdb2.Text = "Female";
            this.rdb2.UseVisualStyleBackColor = true;
            // 
            // subtn
            // 
            this.subtn.Location = new System.Drawing.Point(152, 598);
            this.subtn.Name = "subtn";
            this.subtn.Size = new System.Drawing.Size(75, 23);
            this.subtn.TabIndex = 21;
            this.subtn.Text = "Submit";
            this.subtn.UseVisualStyleBackColor = true;
            this.subtn.Click += new System.EventHandler(this.subtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.Location = new System.Drawing.Point(269, 598);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(75, 23);
            this.cancelbtn.TabIndex = 22;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(152, 284);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 23;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(152, 338);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 24;
            // 
            // depttxt
            // 
            this.depttxt.Location = new System.Drawing.Point(152, 188);
            this.depttxt.Name = "depttxt";
            this.depttxt.Size = new System.Drawing.Size(180, 22);
            this.depttxt.TabIndex = 27;
            // 
            // employeeDataGridView
            // 
            this.employeeDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employeeDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.employeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empCodeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.joiningDateDataGridViewTextBoxColumn,
            this.prevExpDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.employeeDataGridView.DataSource = this.empdetailsBindingSource3;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.employeeDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.employeeDataGridView.Location = new System.Drawing.Point(27, 627);
            this.employeeDataGridView.Name = "employeeDataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employeeDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.employeeDataGridView.RowTemplate.Height = 24;
            this.employeeDataGridView.Size = new System.Drawing.Size(1051, 158);
            this.employeeDataGridView.TabIndex = 25;
            // 
            // empdetailsBindingSource
            // 
            this.empdetailsBindingSource.DataMember = "Empdetails";
            this.empdetailsBindingSource.DataSource = this.hR1DataSetBindingSource;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmployeeTableAdapter = this.employeeTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.HRDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // empdetailsBindingSource1
            // 
            this.empdetailsBindingSource1.DataMember = "Empdetails";
            this.empdetailsBindingSource1.DataSource = this.hR1DataSetBindingSource;
            // 
            // empdetailsBindingSource2
            // 
            this.empdetailsBindingSource2.DataMember = "Empdetails";
            this.empdetailsBindingSource2.DataSource = this.hR1DataSetBindingSource;
            // 
            // empdetailsBindingSource3
            // 
            this.empdetailsBindingSource3.DataMember = "Empdetails";
            this.empdetailsBindingSource3.DataSource = this.hR1DataSetBindingSource;
            // 
            // empCodeDataGridViewTextBoxColumn
            // 
            this.empCodeDataGridViewTextBoxColumn.DataPropertyName = "Emp code";
            this.empCodeDataGridViewTextBoxColumn.HeaderText = "Emp code";
            this.empCodeDataGridViewTextBoxColumn.Name = "empCodeDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "Department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "Department";
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            // 
            // joiningDateDataGridViewTextBoxColumn
            // 
            this.joiningDateDataGridViewTextBoxColumn.DataPropertyName = "Joining Date";
            this.joiningDateDataGridViewTextBoxColumn.HeaderText = "Joining Date";
            this.joiningDateDataGridViewTextBoxColumn.Name = "joiningDateDataGridViewTextBoxColumn";
            // 
            // prevExpDataGridViewTextBoxColumn
            // 
            this.prevExpDataGridViewTextBoxColumn.DataPropertyName = "Prev exp";
            this.prevExpDataGridViewTextBoxColumn.HeaderText = "Prev exp";
            this.prevExpDataGridViewTextBoxColumn.Name = "prevExpDataGridViewTextBoxColumn";
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "Salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "Salary";
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // hR1DataSetBindingSource
            // 
            this.hR1DataSetBindingSource.DataSource = this.hR1DataSet;
            this.hR1DataSetBindingSource.Position = 0;
            // 
            // hR1DataSet
            // 
            this.hR1DataSet.DataSetName = "HR1DataSet";
            this.hR1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empdetailsTableAdapter
            // 
            this.empdetailsTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 810);
            this.Controls.Add(this.depttxt);
            this.Controls.Add(this.employeeDataGridView);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.subtn);
            this.Controls.Add(this.rdb2);
            this.Controls.Add(this.rdb1);
            this.Controls.Add(this.addrichtxt);
            this.Controls.Add(this.saltxt);
            this.Controls.Add(this.pexptxt);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.Empcodetxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EMPCODE);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empdetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empdetailsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empdetailsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empdetailsBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hR1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hR1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label EMPCODE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Empcodetxt;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox pexptxt;
        private System.Windows.Forms.TextBox saltxt;
        private System.Windows.Forms.RichTextBox addrichtxt;
        private System.Windows.Forms.RadioButton rdb1;
        private System.Windows.Forms.RadioButton rdb2;
        private System.Windows.Forms.Button subtn;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private HRDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private HRDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView employeeDataGridView;
        private System.Windows.Forms.TextBox depttxt;
        private System.Windows.Forms.BindingSource hR1DataSetBindingSource;
        private HR1DataSet hR1DataSet;
        private System.Windows.Forms.BindingSource empdetailsBindingSource;
        private HR1DataSetTableAdapters.EmpdetailsTableAdapter empdetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn empCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn joiningDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prevExpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource empdetailsBindingSource3;
        private System.Windows.Forms.BindingSource empdetailsBindingSource1;
        private System.Windows.Forms.BindingSource empdetailsBindingSource2;
    }
}

