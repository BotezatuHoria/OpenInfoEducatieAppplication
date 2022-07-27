
namespace OpenInfoEducatieAppplication
{
    partial class Register
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
            this.fNameTextBox = new System.Windows.Forms.TextBox();
            this.lNameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fNameTextBox
            // 
            this.fNameTextBox.Location = new System.Drawing.Point(115, 84);
            this.fNameTextBox.Multiline = true;
            this.fNameTextBox.Name = "fNameTextBox";
            this.fNameTextBox.Size = new System.Drawing.Size(262, 20);
            this.fNameTextBox.TabIndex = 0;
            // 
            // lNameTextBox
            // 
            this.lNameTextBox.Location = new System.Drawing.Point(115, 123);
            this.lNameTextBox.Multiline = true;
            this.lNameTextBox.Name = "lNameTextBox";
            this.lNameTextBox.Size = new System.Drawing.Size(262, 20);
            this.lNameTextBox.TabIndex = 1;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(115, 167);
            this.emailTextBox.Multiline = true;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(262, 20);
            this.emailTextBox.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(115, 215);
            this.passwordTextBox.Multiline = true;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(262, 20);
            this.passwordTextBox.TabIndex = 3;
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(368, 334);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 4;
            this.sendButton.Text = "button1";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.lNameTextBox);
            this.Controls.Add(this.fNameTextBox);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fNameTextBox;
        private System.Windows.Forms.TextBox lNameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button sendButton;
    }
}