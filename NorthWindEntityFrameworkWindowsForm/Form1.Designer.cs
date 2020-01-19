namespace NorthWindEntityFrameworkWindowsForm
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
            this.EmployeesGroupBox = new System.Windows.Forms.GroupBox();
            this.GetByEmployeeIdButton = new System.Windows.Forms.Button();
            this.EmployeeDataGridView = new System.Windows.Forms.DataGridView();
            this.EmployeesInsertButton = new System.Windows.Forms.Button();
            this.EmployeesDeleteButton = new System.Windows.Forms.Button();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.EmployeeLastNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EmployeeUpdateButton = new System.Windows.Forms.Button();
            this.EmployeesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeesGroupBox
            // 
            this.EmployeesGroupBox.Controls.Add(this.EmployeeUpdateButton);
            this.EmployeesGroupBox.Controls.Add(this.label2);
            this.EmployeesGroupBox.Controls.Add(this.label1);
            this.EmployeesGroupBox.Controls.Add(this.EmployeeLastNameTextBox);
            this.EmployeesGroupBox.Controls.Add(this.EmployeeFirstNameTextBox);
            this.EmployeesGroupBox.Controls.Add(this.GetByEmployeeIdButton);
            this.EmployeesGroupBox.Controls.Add(this.EmployeeDataGridView);
            this.EmployeesGroupBox.Controls.Add(this.EmployeesInsertButton);
            this.EmployeesGroupBox.Controls.Add(this.EmployeesDeleteButton);
            this.EmployeesGroupBox.Location = new System.Drawing.Point(14, 13);
            this.EmployeesGroupBox.Name = "EmployeesGroupBox";
            this.EmployeesGroupBox.Size = new System.Drawing.Size(379, 476);
            this.EmployeesGroupBox.TabIndex = 0;
            this.EmployeesGroupBox.TabStop = false;
            this.EmployeesGroupBox.Text = "Employees";
            // 
            // GetByEmployeeIdButton
            // 
            this.GetByEmployeeIdButton.Location = new System.Drawing.Point(25, 54);
            this.GetByEmployeeIdButton.Name = "GetByEmployeeIdButton";
            this.GetByEmployeeIdButton.Size = new System.Drawing.Size(75, 23);
            this.GetByEmployeeIdButton.TabIndex = 3;
            this.GetByEmployeeIdButton.Text = "Get by Id";
            this.GetByEmployeeIdButton.UseVisualStyleBackColor = true;
            this.GetByEmployeeIdButton.Click += new System.EventHandler(this.GetByEmployeeIdButton_Click);
            // 
            // EmployeeDataGridView
            // 
            this.EmployeeDataGridView.AllowUserToAddRows = false;
            this.EmployeeDataGridView.AllowUserToDeleteRows = false;
            this.EmployeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.FullNameColumn});
            this.EmployeeDataGridView.Location = new System.Drawing.Point(129, 25);
            this.EmployeeDataGridView.Name = "EmployeeDataGridView";
            this.EmployeeDataGridView.ReadOnly = true;
            this.EmployeeDataGridView.RowHeadersVisible = false;
            this.EmployeeDataGridView.Size = new System.Drawing.Size(235, 350);
            this.EmployeeDataGridView.TabIndex = 2;
            // 
            // EmployeesInsertButton
            // 
            this.EmployeesInsertButton.Location = new System.Drawing.Point(25, 83);
            this.EmployeesInsertButton.Name = "EmployeesInsertButton";
            this.EmployeesInsertButton.Size = new System.Drawing.Size(75, 23);
            this.EmployeesInsertButton.TabIndex = 1;
            this.EmployeesInsertButton.Text = "Insert";
            this.EmployeesInsertButton.UseVisualStyleBackColor = true;
            this.EmployeesInsertButton.Click += new System.EventHandler(this.EmployeesInsertButton_Click);
            // 
            // EmployeesDeleteButton
            // 
            this.EmployeesDeleteButton.Location = new System.Drawing.Point(25, 112);
            this.EmployeesDeleteButton.Name = "EmployeesDeleteButton";
            this.EmployeesDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.EmployeesDeleteButton.TabIndex = 0;
            this.EmployeesDeleteButton.Text = "Delete";
            this.EmployeesDeleteButton.UseVisualStyleBackColor = true;
            this.EmployeesDeleteButton.Click += new System.EventHandler(this.EmployeesDeleteButton_Click);
            // 
            // IdColumn
            // 
            this.IdColumn.DataPropertyName = "Id";
            this.IdColumn.HeaderText = "Id";
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.ReadOnly = true;
            // 
            // FullNameColumn
            // 
            this.FullNameColumn.DataPropertyName = "FullName";
            this.FullNameColumn.HeaderText = "Name";
            this.FullNameColumn.Name = "FullNameColumn";
            this.FullNameColumn.ReadOnly = true;
            // 
            // EmployeeFirstNameTextBox
            // 
            this.EmployeeFirstNameTextBox.Location = new System.Drawing.Point(163, 394);
            this.EmployeeFirstNameTextBox.Name = "EmployeeFirstNameTextBox";
            this.EmployeeFirstNameTextBox.Size = new System.Drawing.Size(110, 20);
            this.EmployeeFirstNameTextBox.TabIndex = 4;
            // 
            // EmployeeLastNameTextBox
            // 
            this.EmployeeLastNameTextBox.Location = new System.Drawing.Point(163, 420);
            this.EmployeeLastNameTextBox.Name = "EmployeeLastNameTextBox";
            this.EmployeeLastNameTextBox.Size = new System.Drawing.Size(110, 20);
            this.EmployeeLastNameTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 401);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "First";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 423);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Last";
            // 
            // EmployeeUpdateButton
            // 
            this.EmployeeUpdateButton.Location = new System.Drawing.Point(289, 401);
            this.EmployeeUpdateButton.Name = "EmployeeUpdateButton";
            this.EmployeeUpdateButton.Size = new System.Drawing.Size(75, 23);
            this.EmployeeUpdateButton.TabIndex = 8;
            this.EmployeeUpdateButton.Text = "Update";
            this.EmployeeUpdateButton.UseVisualStyleBackColor = true;
            this.EmployeeUpdateButton.Click += new System.EventHandler(this.EmployeeUpdateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 501);
            this.Controls.Add(this.EmployeesGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.EmployeesGroupBox.ResumeLayout(false);
            this.EmployeesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox EmployeesGroupBox;
        private System.Windows.Forms.Button EmployeesDeleteButton;
        private System.Windows.Forms.Button EmployeesInsertButton;
        private System.Windows.Forms.DataGridView EmployeeDataGridView;
        private System.Windows.Forms.Button GetByEmployeeIdButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullNameColumn;
        private System.Windows.Forms.Button EmployeeUpdateButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EmployeeLastNameTextBox;
        private System.Windows.Forms.TextBox EmployeeFirstNameTextBox;
    }
}

