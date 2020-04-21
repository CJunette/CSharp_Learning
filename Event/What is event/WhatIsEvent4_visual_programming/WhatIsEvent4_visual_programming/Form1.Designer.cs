namespace WhatIsEvent4_visual_programming
{
    partial class MyForm
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
            this.Button = new System.Windows.Forms.Button();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Button
            // 
            this.Button.Location = new System.Drawing.Point(13, 40);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(331, 23);
            this.Button.TabIndex = 0;
            this.Button.Text = "Say Hello!";
            this.Button.UseVisualStyleBackColor = true;
            this.Button.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(13, 13);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(331, 21);
            this.TextBox.TabIndex = 1;
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 311);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.Button);
            this.Name = "MyForm";
            this.Text = "Hello Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button;
        private System.Windows.Forms.TextBox TextBox;
    }
}

