namespace PCHueController
{
    partial class PCHueController
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PCHueController));
            this.pnlCurrentSwatch = new System.Windows.Forms.Panel();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lstHubs = new System.Windows.Forms.ListBox();
            this.lblTitle1 = new System.Windows.Forms.Label();
            this.btnNewColour = new System.Windows.Forms.Button();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.lblTitle4 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.grpConnection = new System.Windows.Forms.GroupBox();
            this.lblDeviceName = new System.Windows.Forms.Label();
            this.lblAppName = new System.Windows.Forms.Label();
            this.txtDeviceName = new System.Windows.Forms.TextBox();
            this.txtAppName = new System.Windows.Forms.TextBox();
            this.btnRefreshHubs = new System.Windows.Forms.Button();
            this.grpColour = new System.Windows.Forms.GroupBox();
            this.btnRefreshScene = new System.Windows.Forms.Button();
            this.lstScenes = new System.Windows.Forms.ListBox();
            this.btnOnOff = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRefreshLights = new System.Windows.Forms.Button();
            this.lstLights = new System.Windows.Forms.ListBox();
            this.lblTitle3 = new System.Windows.Forms.Label();
            this.grpExtras = new System.Windows.Forms.GroupBox();
            this.btnDisco = new System.Windows.Forms.Button();
            this.grpConnection.SuspendLayout();
            this.grpColour.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpExtras.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCurrentSwatch
            // 
            this.pnlCurrentSwatch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlCurrentSwatch.BackColor = System.Drawing.Color.White;
            this.pnlCurrentSwatch.Location = new System.Drawing.Point(731, 39);
            this.pnlCurrentSwatch.Name = "pnlCurrentSwatch";
            this.pnlCurrentSwatch.Size = new System.Drawing.Size(86, 60);
            this.pnlCurrentSwatch.TabIndex = 0;
            // 
            // lblCurrent
            // 
            this.lblCurrent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCurrent.ForeColor = System.Drawing.Color.White;
            this.lblCurrent.Location = new System.Drawing.Point(719, 16);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(116, 20);
            this.lblCurrent.TabIndex = 0;
            this.lblCurrent.Text = "Current Colour:";
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(259, 295);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(90, 24);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "Get API Key";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lstHubs
            // 
            this.lstHubs.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lstHubs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lstHubs.ForeColor = System.Drawing.Color.White;
            this.lstHubs.FormattingEnabled = true;
            this.lstHubs.Location = new System.Drawing.Point(10, 97);
            this.lstHubs.Name = "lstHubs";
            this.lstHubs.Size = new System.Drawing.Size(339, 95);
            this.lstHubs.TabIndex = 3;
            this.lstHubs.SelectedIndexChanged += new System.EventHandler(this.lstHubs_SelectedIndexChanged);
            // 
            // lblTitle1
            // 
            this.lblTitle1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle1.AutoSize = true;
            this.lblTitle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTitle1.ForeColor = System.Drawing.Color.White;
            this.lblTitle1.Location = new System.Drawing.Point(5, 25);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(222, 20);
            this.lblTitle1.TabIndex = 4;
            this.lblTitle1.Text = "1.Discover and select a device";
            // 
            // btnNewColour
            // 
            this.btnNewColour.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNewColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnNewColour.ForeColor = System.Drawing.Color.White;
            this.btnNewColour.Image = ((System.Drawing.Image)(resources.GetObject("btnNewColour.Image")));
            this.btnNewColour.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNewColour.Location = new System.Drawing.Point(66, 57);
            this.btnNewColour.Name = "btnNewColour";
            this.btnNewColour.Size = new System.Drawing.Size(80, 39);
            this.btnNewColour.TabIndex = 1;
            this.btnNewColour.Text = "Generic colour picker";
            this.btnNewColour.UseVisualStyleBackColor = true;
            this.btnNewColour.Click += new System.EventHandler(this.btnNewColour_Click);
            // 
            // lblTitle2
            // 
            this.lblTitle2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle2.AutoSize = true;
            this.lblTitle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTitle2.ForeColor = System.Drawing.Color.White;
            this.lblTitle2.Location = new System.Drawing.Point(6, 223);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(190, 40);
            this.lblTitle2.TabIndex = 7;
            this.lblTitle2.Text = "2.Get API key or connect \r\nwith an existing key";
            // 
            // lblTitle4
            // 
            this.lblTitle4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle4.AutoSize = true;
            this.lblTitle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTitle4.ForeColor = System.Drawing.Color.White;
            this.lblTitle4.Location = new System.Drawing.Point(7, 29);
            this.lblTitle4.Name = "lblTitle4";
            this.lblTitle4.Size = new System.Drawing.Size(174, 20);
            this.lblTitle4.TabIndex = 8;
            this.lblTitle4.Text = "4.Choose Colour/Effect";
            // 
            // txtKey
            // 
            this.txtKey.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtKey.ForeColor = System.Drawing.Color.White;
            this.txtKey.Location = new System.Drawing.Point(9, 328);
            this.txtKey.MaxLength = 50;
            this.txtKey.Multiline = true;
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(244, 39);
            this.txtKey.TabIndex = 9;
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnConnect.ForeColor = System.Drawing.Color.White;
            this.btnConnect.Location = new System.Drawing.Point(259, 328);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(90, 39);
            this.btnConnect.TabIndex = 10;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtResults
            // 
            this.txtResults.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtResults.BackColor = System.Drawing.Color.DarkGreen;
            this.txtResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResults.ForeColor = System.Drawing.Color.White;
            this.txtResults.Location = new System.Drawing.Point(259, 404);
            this.txtResults.MaxLength = 50;
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.ReadOnly = true;
            this.txtResults.Size = new System.Drawing.Size(267, 57);
            this.txtResults.TabIndex = 11;
            this.txtResults.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtResults.Visible = false;
            // 
            // grpConnection
            // 
            this.grpConnection.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grpConnection.Controls.Add(this.lblDeviceName);
            this.grpConnection.Controls.Add(this.lblAppName);
            this.grpConnection.Controls.Add(this.txtDeviceName);
            this.grpConnection.Controls.Add(this.txtAppName);
            this.grpConnection.Controls.Add(this.btnRefreshHubs);
            this.grpConnection.Controls.Add(this.lblTitle2);
            this.grpConnection.Controls.Add(this.btnConnect);
            this.grpConnection.Controls.Add(this.lblTitle1);
            this.grpConnection.Controls.Add(this.txtKey);
            this.grpConnection.Controls.Add(this.btnRegister);
            this.grpConnection.Controls.Add(this.lstHubs);
            this.grpConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.grpConnection.ForeColor = System.Drawing.Color.White;
            this.grpConnection.Location = new System.Drawing.Point(36, 12);
            this.grpConnection.Name = "grpConnection";
            this.grpConnection.Size = new System.Drawing.Size(355, 384);
            this.grpConnection.TabIndex = 12;
            this.grpConnection.TabStop = false;
            this.grpConnection.Text = "Connection";
            // 
            // lblDeviceName
            // 
            this.lblDeviceName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDeviceName.AutoSize = true;
            this.lblDeviceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblDeviceName.Location = new System.Drawing.Point(133, 277);
            this.lblDeviceName.Name = "lblDeviceName";
            this.lblDeviceName.Size = new System.Drawing.Size(75, 13);
            this.lblDeviceName.TabIndex = 17;
            this.lblDeviceName.Text = "Device Name:";
            // 
            // lblAppName
            // 
            this.lblAppName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblAppName.Location = new System.Drawing.Point(6, 277);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(60, 13);
            this.lblAppName.TabIndex = 16;
            this.lblAppName.Text = "App Name:";
            // 
            // txtDeviceName
            // 
            this.txtDeviceName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDeviceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtDeviceName.ForeColor = System.Drawing.Color.White;
            this.txtDeviceName.Location = new System.Drawing.Point(136, 296);
            this.txtDeviceName.MaxLength = 25;
            this.txtDeviceName.Name = "txtDeviceName";
            this.txtDeviceName.Size = new System.Drawing.Size(117, 20);
            this.txtDeviceName.TabIndex = 15;
            // 
            // txtAppName
            // 
            this.txtAppName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtAppName.ForeColor = System.Drawing.Color.White;
            this.txtAppName.Location = new System.Drawing.Point(9, 296);
            this.txtAppName.MaxLength = 25;
            this.txtAppName.Name = "txtAppName";
            this.txtAppName.Size = new System.Drawing.Size(117, 20);
            this.txtAppName.TabIndex = 14;
            // 
            // btnRefreshHubs
            // 
            this.btnRefreshHubs.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRefreshHubs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnRefreshHubs.ForeColor = System.Drawing.Color.White;
            this.btnRefreshHubs.Location = new System.Drawing.Point(139, 48);
            this.btnRefreshHubs.Name = "btnRefreshHubs";
            this.btnRefreshHubs.Size = new System.Drawing.Size(80, 39);
            this.btnRefreshHubs.TabIndex = 13;
            this.btnRefreshHubs.Text = "Refresh Hubs";
            this.btnRefreshHubs.UseVisualStyleBackColor = true;
            this.btnRefreshHubs.Click += new System.EventHandler(this.btnRefreshHubs_Click);
            // 
            // grpColour
            // 
            this.grpColour.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grpColour.Controls.Add(this.btnRefreshScene);
            this.grpColour.Controls.Add(this.lstScenes);
            this.grpColour.Controls.Add(this.lblTitle4);
            this.grpColour.Controls.Add(this.btnNewColour);
            this.grpColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.grpColour.ForeColor = System.Drawing.Color.White;
            this.grpColour.Location = new System.Drawing.Point(397, 206);
            this.grpColour.Name = "grpColour";
            this.grpColour.Size = new System.Drawing.Size(298, 190);
            this.grpColour.TabIndex = 13;
            this.grpColour.TabStop = false;
            this.grpColour.Text = "Colour";
            // 
            // btnRefreshScene
            // 
            this.btnRefreshScene.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRefreshScene.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnRefreshScene.ForeColor = System.Drawing.Color.White;
            this.btnRefreshScene.Location = new System.Drawing.Point(152, 57);
            this.btnRefreshScene.Name = "btnRefreshScene";
            this.btnRefreshScene.Size = new System.Drawing.Size(80, 39);
            this.btnRefreshScene.TabIndex = 12;
            this.btnRefreshScene.Text = "Refresh Scenes";
            this.btnRefreshScene.UseVisualStyleBackColor = true;
            this.btnRefreshScene.Click += new System.EventHandler(this.btnRefreshScene_Click);
            // 
            // lstScenes
            // 
            this.lstScenes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lstScenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lstScenes.ForeColor = System.Drawing.Color.White;
            this.lstScenes.FormattingEnabled = true;
            this.lstScenes.Location = new System.Drawing.Point(6, 102);
            this.lstScenes.Name = "lstScenes";
            this.lstScenes.Size = new System.Drawing.Size(286, 82);
            this.lstScenes.TabIndex = 12;
            this.lstScenes.SelectedIndexChanged += new System.EventHandler(this.lstScenes_SelectedIndexChanged);
            // 
            // btnOnOff
            // 
            this.btnOnOff.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOnOff.BackgroundImage = global::PCHueController.Properties.Resources.On;
            this.btnOnOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOnOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnOnOff.ForeColor = System.Drawing.Color.White;
            this.btnOnOff.Location = new System.Drawing.Point(743, 105);
            this.btnOnOff.Name = "btnOnOff";
            this.btnOnOff.Size = new System.Drawing.Size(58, 99);
            this.btnOnOff.TabIndex = 13;
            this.btnOnOff.UseVisualStyleBackColor = true;
            this.btnOnOff.Click += new System.EventHandler(this.btnOnOff_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.btnRefreshLights);
            this.groupBox2.Controls.Add(this.lstLights);
            this.groupBox2.Controls.Add(this.lblTitle3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(397, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 188);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lights";
            // 
            // btnRefreshLights
            // 
            this.btnRefreshLights.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRefreshLights.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnRefreshLights.ForeColor = System.Drawing.Color.White;
            this.btnRefreshLights.Location = new System.Drawing.Point(111, 48);
            this.btnRefreshLights.Name = "btnRefreshLights";
            this.btnRefreshLights.Size = new System.Drawing.Size(80, 39);
            this.btnRefreshLights.TabIndex = 18;
            this.btnRefreshLights.Text = "Refresh Lights";
            this.btnRefreshLights.UseVisualStyleBackColor = true;
            this.btnRefreshLights.Click += new System.EventHandler(this.btnRefreshLights_Click);
            // 
            // lstLights
            // 
            this.lstLights.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lstLights.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lstLights.ForeColor = System.Drawing.Color.White;
            this.lstLights.FormattingEnabled = true;
            this.lstLights.Location = new System.Drawing.Point(6, 93);
            this.lstLights.Name = "lstLights";
            this.lstLights.Size = new System.Drawing.Size(286, 82);
            this.lstLights.TabIndex = 11;
            this.lstLights.SelectedIndexChanged += new System.EventHandler(this.lstLights_SelectedIndexChanged);
            // 
            // lblTitle3
            // 
            this.lblTitle3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle3.AutoSize = true;
            this.lblTitle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTitle3.ForeColor = System.Drawing.Color.White;
            this.lblTitle3.Location = new System.Drawing.Point(10, 25);
            this.lblTitle3.Name = "lblTitle3";
            this.lblTitle3.Size = new System.Drawing.Size(124, 20);
            this.lblTitle3.TabIndex = 9;
            this.lblTitle3.Text = "3.Choose Lights";
            // 
            // grpExtras
            // 
            this.grpExtras.Controls.Add(this.btnDisco);
            this.grpExtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.grpExtras.ForeColor = System.Drawing.Color.White;
            this.grpExtras.Location = new System.Drawing.Point(705, 206);
            this.grpExtras.Name = "grpExtras";
            this.grpExtras.Size = new System.Drawing.Size(130, 190);
            this.grpExtras.TabIndex = 15;
            this.grpExtras.TabStop = false;
            this.grpExtras.Text = "Extras";
            // 
            // btnDisco
            // 
            this.btnDisco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnDisco.Image = ((System.Drawing.Image)(resources.GetObject("btnDisco.Image")));
            this.btnDisco.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDisco.Location = new System.Drawing.Point(6, 28);
            this.btnDisco.Name = "btnDisco";
            this.btnDisco.Size = new System.Drawing.Size(118, 41);
            this.btnDisco.TabIndex = 0;
            this.btnDisco.Text = "Disco Mode";
            this.btnDisco.UseVisualStyleBackColor = true;
            this.btnDisco.Click += new System.EventHandler(this.btnDisco_Click);
            // 
            // PCHueController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(847, 472);
            this.Controls.Add(this.grpExtras);
            this.Controls.Add(this.btnOnOff);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.lblCurrent);
            this.Controls.Add(this.pnlCurrentSwatch);
            this.Controls.Add(this.grpConnection);
            this.Controls.Add(this.grpColour);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PCHueController";
            this.Text = "PCHueController";
            this.grpConnection.ResumeLayout(false);
            this.grpConnection.PerformLayout();
            this.grpColour.ResumeLayout(false);
            this.grpColour.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpExtras.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCurrentSwatch;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.ListBox lstHubs;
        private System.Windows.Forms.Label lblTitle1;
        private System.Windows.Forms.Button btnNewColour;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.Label lblTitle4;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.GroupBox grpConnection;
        private System.Windows.Forms.GroupBox grpColour;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTitle3;
        private System.Windows.Forms.Button btnRefreshScene;
        private System.Windows.Forms.ListBox lstLights;
        private System.Windows.Forms.ListBox lstScenes;
        private System.Windows.Forms.Button btnOnOff;
        private System.Windows.Forms.Button btnRefreshHubs;
        private System.Windows.Forms.TextBox txtDeviceName;
        private System.Windows.Forms.TextBox txtAppName;
        private System.Windows.Forms.Label lblDeviceName;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Button btnRefreshLights;
        private System.Windows.Forms.GroupBox grpExtras;
        private System.Windows.Forms.Button btnDisco;
    }
}

