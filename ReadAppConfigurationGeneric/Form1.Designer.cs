namespace ReadAppConfigurationGeneric
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
            this.GetBoolButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.GetTimeSpanButton = new System.Windows.Forms.Button();
            this.GetAlertDateButton = new System.Windows.Forms.Button();
            this.GetStringButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GetBoolButton
            // 
            this.GetBoolButton.Location = new System.Drawing.Point(12, 45);
            this.GetBoolButton.Name = "GetBoolButton";
            this.GetBoolButton.Size = new System.Drawing.Size(164, 23);
            this.GetBoolButton.TabIndex = 0;
            this.GetBoolButton.Text = "Get bool";
            this.GetBoolButton.UseVisualStyleBackColor = true;
            this.GetBoolButton.Click += new System.EventHandler(this.GetBoolButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(191, 16);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(370, 162);
            this.textBox1.TabIndex = 1;
            // 
            // GetTimeSpanButton
            // 
            this.GetTimeSpanButton.Location = new System.Drawing.Point(12, 74);
            this.GetTimeSpanButton.Name = "GetTimeSpanButton";
            this.GetTimeSpanButton.Size = new System.Drawing.Size(164, 23);
            this.GetTimeSpanButton.TabIndex = 2;
            this.GetTimeSpanButton.Text = "Get TimeSpan";
            this.GetTimeSpanButton.UseVisualStyleBackColor = true;
            this.GetTimeSpanButton.Click += new System.EventHandler(this.GetTimeSpanButton_Click);
            // 
            // GetAlertDateButton
            // 
            this.GetAlertDateButton.Location = new System.Drawing.Point(12, 103);
            this.GetAlertDateButton.Name = "GetAlertDateButton";
            this.GetAlertDateButton.Size = new System.Drawing.Size(164, 23);
            this.GetAlertDateButton.TabIndex = 3;
            this.GetAlertDateButton.Text = "Get Date";
            this.GetAlertDateButton.UseVisualStyleBackColor = true;
            this.GetAlertDateButton.Click += new System.EventHandler(this.GetAlertDateButton_Click);
            // 
            // GetStringButton
            // 
            this.GetStringButton.Location = new System.Drawing.Point(12, 16);
            this.GetStringButton.Name = "GetStringButton";
            this.GetStringButton.Size = new System.Drawing.Size(164, 23);
            this.GetStringButton.TabIndex = 4;
            this.GetStringButton.Text = "Get string";
            this.GetStringButton.UseVisualStyleBackColor = true;
            this.GetStringButton.Click += new System.EventHandler(this.GetStringButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 196);
            this.Controls.Add(this.GetStringButton);
            this.Controls.Add(this.GetAlertDateButton);
            this.Controls.Add(this.GetTimeSpanButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.GetBoolButton);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Get app.config settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetBoolButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button GetTimeSpanButton;
        private System.Windows.Forms.Button GetAlertDateButton;
        private System.Windows.Forms.Button GetStringButton;
    }
}

