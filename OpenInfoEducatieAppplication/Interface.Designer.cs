
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interface));
            this.controlPanel = new System.Windows.Forms.Panel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.appPanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.verifButton = new System.Windows.Forms.Button();
            this.logoPicture = new System.Windows.Forms.PictureBox();
            this.trackButton = new System.Windows.Forms.Button();
            this.articleButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.pomoButton = new System.Windows.Forms.Button();
            this.quizButton = new System.Windows.Forms.Button();
            this.controlPanel.SuspendLayout();
            this.appPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.Color.LightGray;
            this.controlPanel.Controls.Add(this.trackButton);
            this.controlPanel.Controls.Add(this.articleButton);
            this.controlPanel.Controls.Add(this.logOutButton);
            this.controlPanel.Controls.Add(this.pomoButton);
            this.controlPanel.Controls.Add(this.quizButton);
            this.controlPanel.Location = new System.Drawing.Point(-1, 0);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(162, 800);
            this.controlPanel.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameLabel.Location = new System.Drawing.Point(167, 50);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(298, 52);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "label1";
            // 
            // appPanel
            // 
            this.appPanel.Controls.Add(this.flowLayoutPanel);
            this.appPanel.Location = new System.Drawing.Point(167, 125);
            this.appPanel.Name = "appPanel";
            this.appPanel.Size = new System.Drawing.Size(911, 599);
            this.appPanel.TabIndex = 4;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(905, 593);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // verifButton
            // 
            this.verifButton.BackColor = System.Drawing.Color.Salmon;
            this.verifButton.Enabled = false;
            this.verifButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.verifButton.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.verifButton.Location = new System.Drawing.Point(946, 730);
            this.verifButton.Name = "verifButton";
            this.verifButton.Size = new System.Drawing.Size(132, 49);
            this.verifButton.TabIndex = 5;
            this.verifButton.Text = "Answer";
            this.verifButton.UseVisualStyleBackColor = false;
            this.verifButton.Visible = false;
            this.verifButton.Click += new System.EventHandler(this.NextClick);
            // 
            // logoPicture
            // 
            this.logoPicture.Image = global::OpenInfoEducatieAppplication.Properties.Resources.logo;
            this.logoPicture.Location = new System.Drawing.Point(528, 10);
            this.logoPicture.Name = "logoPicture";
            this.logoPicture.Size = new System.Drawing.Size(166, 109);
            this.logoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logoPicture.TabIndex = 3;
            this.logoPicture.TabStop = false;
            // 
            // trackButton
            // 
            this.trackButton.BackgroundImage = global::OpenInfoEducatieAppplication.Properties.Resources.icons8_pie_chart_96;
            this.trackButton.Location = new System.Drawing.Point(29, 524);
            this.trackButton.Name = "trackButton";
            this.trackButton.Size = new System.Drawing.Size(93, 101);
            this.trackButton.TabIndex = 4;
            this.trackButton.UseVisualStyleBackColor = true;
            this.trackButton.Click += new System.EventHandler(this.trackButton_Click);
            // 
            // articleButton
            // 
            this.articleButton.BackColor = System.Drawing.Color.Transparent;
            this.articleButton.BackgroundImage = global::OpenInfoEducatieAppplication.Properties.Resources.icons8_powerpoint_96;
            this.articleButton.Location = new System.Drawing.Point(28, 260);
            this.articleButton.Name = "articleButton";
            this.articleButton.Size = new System.Drawing.Size(95, 98);
            this.articleButton.TabIndex = 5;
            this.articleButton.UseVisualStyleBackColor = false;
            this.articleButton.Click += new System.EventHandler(this.articleButton_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.BackgroundImage = global::OpenInfoEducatieAppplication.Properties.Resources.icons8_open_door_96;
            this.logOutButton.Location = new System.Drawing.Point(28, 686);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(93, 93);
            this.logOutButton.TabIndex = 3;
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // pomoButton
            // 
            this.pomoButton.BackgroundImage = global::OpenInfoEducatieAppplication.Properties.Resources.icons8_clock_96;
            this.pomoButton.Location = new System.Drawing.Point(29, 389);
            this.pomoButton.Name = "pomoButton";
            this.pomoButton.Size = new System.Drawing.Size(93, 97);
            this.pomoButton.TabIndex = 2;
            this.pomoButton.UseVisualStyleBackColor = true;
            this.pomoButton.Click += new System.EventHandler(this.pomoButton_Click);
            // 
            // quizButton
            // 
            this.quizButton.BackgroundImage = global::OpenInfoEducatieAppplication.Properties.Resources.icons8_query_96;
            this.quizButton.Location = new System.Drawing.Point(28, 125);
            this.quizButton.Name = "quizButton";
            this.quizButton.Size = new System.Drawing.Size(94, 101);
            this.quizButton.TabIndex = 1;
            this.quizButton.UseVisualStyleBackColor = true;
            this.quizButton.Click += new System.EventHandler(this.quizButton_Click);
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1099, 791);
            this.Controls.Add(this.verifButton);
            this.Controls.Add(this.appPanel);
            this.Controls.Add(this.logoPicture);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.controlPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Interface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interface";
            this.controlPanel.ResumeLayout(false);
            this.appPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Button trackButton;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button pomoButton;
        private System.Windows.Forms.Button quizButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.PictureBox logoPicture;
        private System.Windows.Forms.Panel appPanel;
        private System.Windows.Forms.Button articleButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Button verifButton;
    }
}