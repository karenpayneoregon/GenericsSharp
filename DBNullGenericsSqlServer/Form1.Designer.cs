namespace DBNullGenericsSqlServer
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
            this.ReadTableWithNullsNoAssertionsButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ReadWithNullsUsingGenericsButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ReadNullsWithInlineNullAssertsButton = new System.Windows.Forms.Button();
            this.ReadWithNullsUsingGenericExtensionButton = new System.Windows.Forms.Button();
            this.ReaderToGenericListButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ReadTableWithNullsNoAssertionsButton
            // 
            this.ReadTableWithNullsNoAssertionsButton.Location = new System.Drawing.Point(12, 12);
            this.ReadTableWithNullsNoAssertionsButton.Name = "ReadTableWithNullsNoAssertionsButton";
            this.ReadTableWithNullsNoAssertionsButton.Size = new System.Drawing.Size(211, 23);
            this.ReadTableWithNullsNoAssertionsButton.TabIndex = 0;
            this.ReadTableWithNullsNoAssertionsButton.Text = "Read with nulls no assertions";
            this.ReadTableWithNullsNoAssertionsButton.UseVisualStyleBackColor = true;
            this.ReadTableWithNullsNoAssertionsButton.Click += new System.EventHandler(this.ReadTableWithNullsNoAssertionsButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(229, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(445, 106);
            this.textBox1.TabIndex = 2;
            // 
            // ReadWithNullsUsingGenericsButton
            // 
            this.ReadWithNullsUsingGenericsButton.Location = new System.Drawing.Point(12, 70);
            this.ReadWithNullsUsingGenericsButton.Name = "ReadWithNullsUsingGenericsButton";
            this.ReadWithNullsUsingGenericsButton.Size = new System.Drawing.Size(211, 23);
            this.ReadWithNullsUsingGenericsButton.TabIndex = 3;
            this.ReadWithNullsUsingGenericsButton.Text = "Read with nulls with generic method";
            this.ReadWithNullsUsingGenericsButton.UseVisualStyleBackColor = true;
            this.ReadWithNullsUsingGenericsButton.Click += new System.EventHandler(this.ReadWithNullsUsingGenericsButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(662, 210);
            this.dataGridView1.TabIndex = 4;
            // 
            // ReadNullsWithInlineNullAssertsButton
            // 
            this.ReadNullsWithInlineNullAssertsButton.Location = new System.Drawing.Point(12, 41);
            this.ReadNullsWithInlineNullAssertsButton.Name = "ReadNullsWithInlineNullAssertsButton";
            this.ReadNullsWithInlineNullAssertsButton.Size = new System.Drawing.Size(211, 23);
            this.ReadNullsWithInlineNullAssertsButton.TabIndex = 5;
            this.ReadNullsWithInlineNullAssertsButton.Text = "Read with nulls with null check";
            this.ReadNullsWithInlineNullAssertsButton.UseVisualStyleBackColor = true;
            this.ReadNullsWithInlineNullAssertsButton.Click += new System.EventHandler(this.ReadNullsWithInlineNullAssertsButton_Click);
            // 
            // ReadWithNullsUsingGenericExtensionButton
            // 
            this.ReadWithNullsUsingGenericExtensionButton.Location = new System.Drawing.Point(12, 99);
            this.ReadWithNullsUsingGenericExtensionButton.Name = "ReadWithNullsUsingGenericExtensionButton";
            this.ReadWithNullsUsingGenericExtensionButton.Size = new System.Drawing.Size(211, 23);
            this.ReadWithNullsUsingGenericExtensionButton.TabIndex = 6;
            this.ReadWithNullsUsingGenericExtensionButton.Text = "Read with nulls with generic extension";
            this.ReadWithNullsUsingGenericExtensionButton.UseVisualStyleBackColor = true;
            this.ReadWithNullsUsingGenericExtensionButton.Click += new System.EventHandler(this.ReadWithNullsUsingGenericExtensionButton_Click);
            // 
            // ReaderToGenericListButton
            // 
            this.ReaderToGenericListButton.Location = new System.Drawing.Point(12, 128);
            this.ReaderToGenericListButton.Name = "ReaderToGenericListButton";
            this.ReaderToGenericListButton.Size = new System.Drawing.Size(211, 23);
            this.ReaderToGenericListButton.TabIndex = 7;
            this.ReaderToGenericListButton.Text = "Reader to List<T>";
            this.ReaderToGenericListButton.UseVisualStyleBackColor = true;
            this.ReaderToGenericListButton.Click += new System.EventHandler(this.ReaderToGenericListButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 389);
            this.Controls.Add(this.ReaderToGenericListButton);
            this.Controls.Add(this.ReadWithNullsUsingGenericExtensionButton);
            this.Controls.Add(this.ReadNullsWithInlineNullAssertsButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ReadWithNullsUsingGenericsButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ReadTableWithNullsNoAssertionsButton);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Using generics to assert DBNull";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReadTableWithNullsNoAssertionsButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ReadWithNullsUsingGenericsButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ReadNullsWithInlineNullAssertsButton;
        private System.Windows.Forms.Button ReadWithNullsUsingGenericExtensionButton;
        private System.Windows.Forms.Button ReaderToGenericListButton;
    }
}

