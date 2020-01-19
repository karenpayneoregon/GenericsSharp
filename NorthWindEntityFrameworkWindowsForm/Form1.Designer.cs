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
            this.EmployeesDeleteButton = new System.Windows.Forms.Button();
            this.EmployeesInsertButton = new System.Windows.Forms.Button();
            this.EmployeeDataGridView = new System.Windows.Forms.DataGridView();
            this.EmployeesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeesGroupBox
            // 
            this.EmployeesGroupBox.Controls.Add(this.EmployeeDataGridView);
            this.EmployeesGroupBox.Controls.Add(this.EmployeesInsertButton);
            this.EmployeesGroupBox.Controls.Add(this.EmployeesDeleteButton);
            this.EmployeesGroupBox.Location = new System.Drawing.Point(14, 13);
            this.EmployeesGroupBox.Name = "EmployeesGroupBox";
            this.EmployeesGroupBox.Size = new System.Drawing.Size(379, 425);
            this.EmployeesGroupBox.TabIndex = 0;
            this.EmployeesGroupBox.TabStop = false;
            this.EmployeesGroupBox.Text = "Employees";
            // 
            // EmployeesDeleteButton
            // 
            this.EmployeesDeleteButton.Enabled = false;
            this.EmployeesDeleteButton.Location = new System.Drawing.Point(25, 78);
            this.EmployeesDeleteButton.Name = "EmployeesDeleteButton";
            this.EmployeesDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.EmployeesDeleteButton.TabIndex = 0;
            this.EmployeesDeleteButton.Text = "Delete";
            this.EmployeesDeleteButton.UseVisualStyleBackColor = true;
            this.EmployeesDeleteButton.Click += new System.EventHandler(this.EmployeesDeleteButton_Click);
            // 
            // EmployeesInsertButton
            // 
            this.EmployeesInsertButton.Enabled = false;
            this.EmployeesInsertButton.Location = new System.Drawing.Point(25, 49);
            this.EmployeesInsertButton.Name = "EmployeesInsertButton";
            this.EmployeesInsertButton.Size = new System.Drawing.Size(75, 23);
            this.EmployeesInsertButton.TabIndex = 1;
            this.EmployeesInsertButton.Text = "Insert";
            this.EmployeesInsertButton.UseVisualStyleBackColor = true;
            this.EmployeesInsertButton.Click += new System.EventHandler(this.EmployeesInsertButton_Click);
            // 
            // EmployeeDataGridView
            // 
            this.EmployeeDataGridView.AllowUserToAddRows = false;
            this.EmployeeDataGridView.AllowUserToDeleteRows = false;
            this.EmployeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeDataGridView.Location = new System.Drawing.Point(129, 25);
            this.EmployeeDataGridView.Name = "EmployeeDataGridView";
            this.EmployeeDataGridView.ReadOnly = true;
            this.EmployeeDataGridView.Size = new System.Drawing.Size(235, 350);
            this.EmployeeDataGridView.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EmployeesGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.EmployeesGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox EmployeesGroupBox;
        private System.Windows.Forms.Button EmployeesDeleteButton;
        private System.Windows.Forms.Button EmployeesInsertButton;
        private System.Windows.Forms.DataGridView EmployeeDataGridView;
    }
}

