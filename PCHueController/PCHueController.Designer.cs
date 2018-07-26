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
            this.txtInputKey = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.grpConnection = new System.Windows.Forms.GroupBox();
            this.grpColour = new System.Windows.Forms.GroupBox();
            this.lstScenes = new System.Windows.Forms.ListBox();
            this.btnOnOff = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstLights = new System.Windows.Forms.ListBox();
            this.lblTitle3 = new System.Windows.Forms.Label();
            this.grpExtra = new System.Windows.Forms.GroupBox();
            this.grpConnection.SuspendLayout();
            this.grpColour.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpExtra.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCurrentSwatch
            // 
            this.pnlCurrentSwatch.BackColor = System.Drawing.Color.White;
            this.pnlCurrentSwatch.Location = new System.Drawing.Point(637, 35);
            this.pnlCurrentSwatch.Name = "pnlCurrentSwatch";
            this.pnlCurrentSwatch.Size = new System.Drawing.Size(86, 60);
            this.pnlCurrentSwatch.TabIndex = 0;
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCurrent.ForeColor = System.Drawing.Color.White;
            this.lblCurrent.Location = new System.Drawing.Point(623, 12);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(116, 20);
            this.lblCurrent.TabIndex = 0;
            this.lblCurrent.Text = "Current Colour:";
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(36, 309);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(93, 37);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "Get API Key";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lstHubs
            // 
            this.lstHubs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lstHubs.ForeColor = System.Drawing.Color.White;
            this.lstHubs.FormattingEnabled = true;
            this.lstHubs.Location = new System.Drawing.Point(17, 77);
            this.lstHubs.Name = "lstHubs";
            this.lstHubs.Size = new System.Drawing.Size(262, 95);
            this.lstHubs.TabIndex = 3;
            this.lstHubs.SelectedIndexChanged += new System.EventHandler(this.lstHubs_SelectedIndexChanged);
            // 
            // lblTitle1
            // 
            this.lblTitle1.AutoSize = true;
            this.lblTitle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTitle1.ForeColor = System.Drawing.Color.White;
            this.lblTitle1.Location = new System.Drawing.Point(13, 44);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(222, 20);
            this.lblTitle1.TabIndex = 4;
            this.lblTitle1.Text = "1.Discover and select a device";
            // 
            // btnNewColour
            // 
            this.btnNewColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnNewColour.ForeColor = System.Drawing.Color.White;
            this.btnNewColour.Image = ((System.Drawing.Image)(resources.GetObject("btnNewColour.Image")));
            this.btnNewColour.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNewColour.Location = new System.Drawing.Point(107, 57);
            this.btnNewColour.Name = "btnNewColour";
            this.btnNewColour.Size = new System.Drawing.Size(80, 39);
            this.btnNewColour.TabIndex = 1;
            this.btnNewColour.Text = "Generic colour picker";
            this.btnNewColour.UseVisualStyleBackColor = true;
            this.btnNewColour.Click += new System.EventHandler(this.btnNewColour_Click);
            // 
            // lblTitle2
            // 
            this.lblTitle2.AutoSize = true;
            this.lblTitle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTitle2.ForeColor = System.Drawing.Color.White;
            this.lblTitle2.Location = new System.Drawing.Point(13, 210);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(190, 40);
            this.lblTitle2.TabIndex = 7;
            this.lblTitle2.Text = "2.Get API key or connect \r\nwith an existing key";
            // 
            // lblTitle4
            // 
            this.lblTitle4.AutoSize = true;
            this.lblTitle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTitle4.ForeColor = System.Drawing.Color.White;
            this.lblTitle4.Location = new System.Drawing.Point(7, 29);
            this.lblTitle4.Name = "lblTitle4";
            this.lblTitle4.Size = new System.Drawing.Size(174, 20);
            this.lblTitle4.TabIndex = 8;
            this.lblTitle4.Text = "4.Choose Colour/Effect";
            // 
            // txtInputKey
            // 
            this.txtInputKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtInputKey.ForeColor = System.Drawing.Color.White;
            this.txtInputKey.Location = new System.Drawing.Point(17, 263);
            this.txtInputKey.MaxLength = 50;
            this.txtInputKey.Multiline = true;
            this.txtInputKey.Name = "txtInputKey";
            this.txtInputKey.Size = new System.Drawing.Size(262, 32);
            this.txtInputKey.TabIndex = 9;
            this.txtInputKey.Text = "***REMOVED***";
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnConnect.ForeColor = System.Drawing.Color.White;
            this.btnConnect.Location = new System.Drawing.Point(161, 309);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(93, 37);
            this.btnConnect.TabIndex = 10;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtResults
            // 
            this.txtResults.BackColor = System.Drawing.Color.DarkGreen;
            this.txtResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResults.ForeColor = System.Drawing.Color.White;
            this.txtResults.Location = new System.Drawing.Point(246, 402);
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
            this.grpConnection.Controls.Add(this.lblTitle2);
            this.grpConnection.Controls.Add(this.btnConnect);
            this.grpConnection.Controls.Add(this.lblTitle1);
            this.grpConnection.Controls.Add(this.txtInputKey);
            this.grpConnection.Controls.Add(this.btnRegister);
            this.grpConnection.Controls.Add(this.lstHubs);
            this.grpConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.grpConnection.ForeColor = System.Drawing.Color.White;
            this.grpConnection.Location = new System.Drawing.Point(12, 12);
            this.grpConnection.Name = "grpConnection";
            this.grpConnection.Size = new System.Drawing.Size(291, 384);
            this.grpConnection.TabIndex = 12;
            this.grpConnection.TabStop = false;
            this.grpConnection.Text = "Connection";
            // 
            // grpColour
            // 
            this.grpColour.Controls.Add(this.lstScenes);
            this.grpColour.Controls.Add(this.lblTitle4);
            this.grpColour.Controls.Add(this.btnNewColour);
            this.grpColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.grpColour.ForeColor = System.Drawing.Color.White;
            this.grpColour.Location = new System.Drawing.Point(319, 206);
            this.grpColour.Name = "grpColour";
            this.grpColour.Size = new System.Drawing.Size(298, 190);
            this.grpColour.TabIndex = 13;
            this.grpColour.TabStop = false;
            this.grpColour.Text = "Colour";
            // 
            // lstScenes
            // 
            this.lstScenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lstScenes.ForeColor = System.Drawing.Color.White;
            this.lstScenes.FormattingEnabled = true;
            this.lstScenes.Location = new System.Drawing.Point(11, 102);
            this.lstScenes.Name = "lstScenes";
            this.lstScenes.Size = new System.Drawing.Size(281, 82);
            this.lstScenes.TabIndex = 12;
            this.lstScenes.SelectedIndexChanged += new System.EventHandler(this.lstScenes_SelectedIndexChanged);
            // 
            // btnOnOff
            // 
            this.btnOnOff.BackgroundImage = global::PCHueController.Properties.Resources.On;
            this.btnOnOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOnOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnOnOff.ForeColor = System.Drawing.Color.White;
            this.btnOnOff.Location = new System.Drawing.Point(34, 74);
            this.btnOnOff.Name = "btnOnOff";
            this.btnOnOff.Size = new System.Drawing.Size(58, 99);
            this.btnOnOff.TabIndex = 13;
            this.btnOnOff.UseVisualStyleBackColor = true;
            this.btnOnOff.Click += new System.EventHandler(this.btnOnOff_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(34, 29);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(58, 39);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = "Refresh scenes";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstLights);
            this.groupBox2.Controls.Add(this.lblTitle3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(319, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 188);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lights";
            // 
            // lstLights
            // 
            this.lstLights.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lstLights.ForeColor = System.Drawing.Color.White;
            this.lstLights.FormattingEnabled = true;
            this.lstLights.Location = new System.Drawing.Point(14, 86);
            this.lstLights.Name = "lstLights";
            this.lstLights.Size = new System.Drawing.Size(251, 82);
            this.lstLights.TabIndex = 11;
            this.lstLights.SelectedIndexChanged += new System.EventHandler(this.lstLights_SelectedIndexChanged);
            // 
            // lblTitle3
            // 
            this.lblTitle3.AutoSize = true;
            this.lblTitle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTitle3.ForeColor = System.Drawing.Color.White;
            this.lblTitle3.Location = new System.Drawing.Point(10, 44);
            this.lblTitle3.Name = "lblTitle3";
            this.lblTitle3.Size = new System.Drawing.Size(124, 20);
            this.lblTitle3.TabIndex = 9;
            this.lblTitle3.Text = "3.Choose Lights";
            // 
            // grpExtra
            // 
            this.grpExtra.Controls.Add(this.btnRefresh);
            this.grpExtra.Controls.Add(this.btnOnOff);
            this.grpExtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.grpExtra.ForeColor = System.Drawing.Color.White;
            this.grpExtra.Location = new System.Drawing.Point(627, 206);
            this.grpExtra.Name = "grpExtra";
            this.grpExtra.Size = new System.Drawing.Size(98, 190);
            this.grpExtra.TabIndex = 15;
            this.grpExtra.TabStop = false;
            this.grpExtra.Text = "Extras";
            // 
            // PCHueController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 486);
            this.Controls.Add(this.grpExtra);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.lblCurrent);
            this.Controls.Add(this.pnlCurrentSwatch);
            this.Controls.Add(this.grpConnection);
            this.Controls.Add(this.grpColour);
            this.Name = "PCHueController";
            this.Text = "PCHueController";
            this.grpConnection.ResumeLayout(false);
            this.grpConnection.PerformLayout();
            this.grpColour.ResumeLayout(false);
            this.grpColour.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpExtra.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox txtInputKey;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.GroupBox grpConnection;
        private System.Windows.Forms.GroupBox grpColour;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTitle3;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ListBox lstLights;
        private System.Windows.Forms.ListBox lstScenes;
        private System.Windows.Forms.Button btnOnOff;
        private System.Windows.Forms.GroupBox grpExtra;
    }
}

