namespace Basic1
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
            this.IComparableButton = new System.Windows.Forms.Button();
            this.SimpleInterfaceButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IComparableButton
            // 
            this.IComparableButton.Location = new System.Drawing.Point(9, 12);
            this.IComparableButton.Name = "IComparableButton";
            this.IComparableButton.Size = new System.Drawing.Size(191, 23);
            this.IComparableButton.TabIndex = 0;
            this.IComparableButton.Text = "IComparable.CompareTo";
            this.IComparableButton.UseVisualStyleBackColor = true;
            this.IComparableButton.Click += new System.EventHandler(this.IComparableButton_Click);
            // 
            // SimpleInterfaceButton
            // 
            this.SimpleInterfaceButton.Location = new System.Drawing.Point(12, 41);
            this.SimpleInterfaceButton.Name = "SimpleInterfaceButton";
            this.SimpleInterfaceButton.Size = new System.Drawing.Size(191, 23);
            this.SimpleInterfaceButton.TabIndex = 1;
            this.SimpleInterfaceButton.Text = "Simple Interface";
            this.SimpleInterfaceButton.UseVisualStyleBackColor = true;
            this.SimpleInterfaceButton.Click += new System.EventHandler(this.SimpleInterfaceButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 243);
            this.Controls.Add(this.SimpleInterfaceButton);
            this.Controls.Add(this.IComparableButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Basics";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button IComparableButton;
        private System.Windows.Forms.Button SimpleInterfaceButton;
    }
}

