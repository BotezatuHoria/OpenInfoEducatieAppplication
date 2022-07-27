
namespace OpenInfoEducatieAppplication
{
    partial class Interface
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
            this.controlPanel = new System.Windows.Forms.Panel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.logoPicture = new System.Windows.Forms.PictureBox();
            this.userButton = new System.Windows.Forms.Button();
            this.quizButton = new System.Windows.Forms.Button();
            this.pomoButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.trackButton = new System.Windows.Forms.Button();
            this.appPanel = new System.Windows.Forms.Panel();
            this.articleButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.verifButton = new System.Windows.Forms.Button();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).BeginInit();
            this.appPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.articleButton);
            this.controlPanel.Controls.Add(this.trackButton);
            this.controlPanel.Controls.Add(this.logOutButton);
            this.controlPanel.Controls.Add(this.pomoButton);
            this.controlPanel.Controls.Add(this.quizButton);
            this.controlPanel.Controls.Add(this.userButton);
            this.controlPanel.Location = new System.Drawing.Point(2, 12);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(159, 609);
            this.controlPanel.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.Location = new System.Drawing.Point(167, 15);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(217, 52);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "label1";
            // 
            // logoPicture
            // 
            this.logoPicture.Location = new System.Drawing.Point(545, 10);
            this.logoPicture.Name = "logoPicture";
            this.logoPicture.Size = new System.Drawing.Size(139, 73);
            this.logoPicture.TabIndex = 3;
            this.logoPicture.TabStop = false;
            // 
            // userButton
            // 
            this.userButton.Location = new System.Drawing.Point(37, 3);
            this.userButton.Name = "userButton";
            this.userButton.Size = new System.Drawing.Size(75, 76);
            this.userButton.TabIndex = 0;
            this.userButton.UseVisualStyleBackColor = true;
            this.userButton.Click += new System.EventHandler(this.userButton_Click);
            // 
            // quizButton
            // 
            this.quizButton.Location = new System.Drawing.Point(37, 107);
            this.quizButton.Name = "quizButton";
            this.quizButton.Size = new System.Drawing.Size(75, 76);
            this.quizButton.TabIndex = 1;
            this.quizButton.Text = "button2";
            this.quizButton.UseVisualStyleBackColor = true;
            this.quizButton.Click += new System.EventHandler(this.quizButton_Click);
            // 
            // pomoButton
            // 
            this.pomoButton.Location = new System.Drawing.Point(37, 313);
            this.pomoButton.Name = "pomoButton";
            this.pomoButton.Size = new System.Drawing.Size(75, 76);
            this.pomoButton.TabIndex = 2;
            this.pomoButton.Text = "button3";
            this.pomoButton.UseVisualStyleBackColor = true;
            // 
            // logOutButton
            // 
            this.logOutButton.Location = new System.Drawing.Point(37, 524);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(75, 66);
            this.logOutButton.TabIndex = 3;
            this.logOutButton.Text = "button4";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // trackButton
            // 
            this.trackButton.Location = new System.Drawing.Point(37, 420);
            this.trackButton.Name = "trackButton";
            this.trackButton.Size = new System.Drawing.Size(75, 76);
            this.trackButton.TabIndex = 4;
            this.trackButton.Text = "button5";
            this.trackButton.UseVisualStyleBackColor = true;
            this.trackButton.Click += new System.EventHandler(this.trackButton_Click);
            // 
            // appPanel
            // 
            this.appPanel.Controls.Add(this.flowLayoutPanel);
            this.appPanel.Location = new System.Drawing.Point(170, 89);
            this.appPanel.Name = "appPanel";
            this.appPanel.Size = new System.Drawing.Size(911, 533);
            this.appPanel.TabIndex = 4;
            // 
            // articleButton
            // 
            this.articleButton.Location = new System.Drawing.Point(37, 204);
            this.articleButton.Name = "articleButton";
            this.articleButton.Size = new System.Drawing.Size(75, 76);
            this.articleButton.TabIndex = 5;
            this.articleButton.Text = "button3";
            this.articleButton.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(905, 527);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // verifButton
            // 
            this.verifButton.Enabled = false;
            this.verifButton.Location = new System.Drawing.Point(928, 638);
            this.verifButton.Name = "verifButton";
            this.verifButton.Size = new System.Drawing.Size(75, 23);
            this.verifButton.TabIndex = 5;
            this.verifButton.Text = "button1";
            this.verifButton.UseVisualStyleBackColor = true;
            this.verifButton.Visible = false;
            this.verifButton.Click += new System.EventHandler(this.NextClick);
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 673);
            this.Controls.Add(this.verifButton);
            this.Controls.Add(this.appPanel);
            this.Controls.Add(this.logoPicture);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.controlPanel);
            this.Name = "Interface";
            this.Text = "Interface";
            this.controlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).EndInit();
            this.appPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Button trackButton;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button pomoButton;
        private System.Windows.Forms.Button quizButton;
        private System.Windows.Forms.Button userButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.PictureBox logoPicture;
        private System.Windows.Forms.Panel appPanel;
        private System.Windows.Forms.Button articleButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Button verifButton;
    }
}