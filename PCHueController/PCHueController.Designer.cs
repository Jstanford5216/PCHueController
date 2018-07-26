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
            this.lblTitle3 = new System.Windows.Forms.Label();
            this.txtInputKey = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.grpConnection = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnColorloop = new System.Windows.Forms.Button();
            this.btnOceanM = new System.Windows.Forms.Button();
            this.grpConnection.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCurrentSwatch
            // 
            this.pnlCurrentSwatch.BackColor = System.Drawing.Color.White;
            this.pnlCurrentSwatch.Location = new System.Drawing.Point(623, 35);
            this.pnlCurrentSwatch.Name = "pnlCurrentSwatch";
            this.pnlCurrentSwatch.Size = new System.Drawing.Size(86, 60);
            this.pnlCurrentSwatch.TabIndex = 0;
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCurrent.ForeColor = System.Drawing.Color.White;
            this.lblCurrent.Location = new System.Drawing.Point(609, 12);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(116, 20);
            this.lblCurrent.TabIndex = 0;
            this.lblCurrent.Text = "Current Colour:";
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(36, 282);
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
            this.lstHubs.Location = new System.Drawing.Point(16, 66);
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
            this.lblTitle1.Location = new System.Drawing.Point(32, 36);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(222, 20);
            this.lblTitle1.TabIndex = 4;
            this.lblTitle1.Text = "1.Discover and select a device";
            // 
            // btnNewColour
            // 
            this.btnNewColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnNewColour.ForeColor = System.Drawing.Color.White;
            this.btnNewColour.Location = new System.Drawing.Point(73, 66);
            this.btnNewColour.Name = "btnNewColour";
            this.btnNewColour.Size = new System.Drawing.Size(116, 23);
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
            this.lblTitle2.Location = new System.Drawing.Point(52, 187);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(190, 40);
            this.lblTitle2.TabIndex = 7;
            this.lblTitle2.Text = "2.Get API key or connect \r\nwith an existing key";
            // 
            // lblTitle3
            // 
            this.lblTitle3.AutoSize = true;
            this.lblTitle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTitle3.ForeColor = System.Drawing.Color.White;
            this.lblTitle3.Location = new System.Drawing.Point(43, 36);
            this.lblTitle3.Name = "lblTitle3";
            this.lblTitle3.Size = new System.Drawing.Size(174, 20);
            this.lblTitle3.TabIndex = 8;
            this.lblTitle3.Text = "3.Choose Colour/Effect";
            // 
            // txtInputKey
            // 
            this.txtInputKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtInputKey.ForeColor = System.Drawing.Color.White;
            this.txtInputKey.Location = new System.Drawing.Point(17, 236);
            this.txtInputKey.MaxLength = 50;
            this.txtInputKey.Multiline = true;
            this.txtInputKey.Name = "txtInputKey";
            this.txtInputKey.Size = new System.Drawing.Size(262, 32);
            this.txtInputKey.TabIndex = 9;
            this.txtInputKey.Text = "***REMOVED***";
            this.txtInputKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnConnect.ForeColor = System.Drawing.Color.White;
            this.btnConnect.Location = new System.Drawing.Point(161, 282);
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
            this.txtResults.Location = new System.Drawing.Point(178, 349);
            this.txtResults.MaxLength = 50;
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.ReadOnly = true;
            this.txtResults.Size = new System.Drawing.Size(262, 57);
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
            this.grpConnection.Size = new System.Drawing.Size(291, 331);
            this.grpConnection.TabIndex = 12;
            this.grpConnection.TabStop = false;
            this.grpConnection.Text = "Connection";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOceanM);
            this.groupBox1.Controls.Add(this.btnColorloop);
            this.groupBox1.Controls.Add(this.lblTitle3);
            this.groupBox1.Controls.Add(this.btnNewColour);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(317, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 331);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color";
            // 
            // btnColorloop
            // 
            this.btnColorloop.FlatAppearance.BorderSize = 0;
            this.btnColorloop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnColorloop.ForeColor = System.Drawing.Color.White;
            this.btnColorloop.Image = ((System.Drawing.Image)(resources.GetObject("btnColorloop.Image")));
            this.btnColorloop.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnColorloop.Location = new System.Drawing.Point(47, 107);
            this.btnColorloop.Name = "btnColorloop";
            this.btnColorloop.Size = new System.Drawing.Size(77, 39);
            this.btnColorloop.TabIndex = 9;
            this.btnColorloop.Text = "Colorloop";
            this.btnColorloop.UseVisualStyleBackColor = true;
            this.btnColorloop.Click += new System.EventHandler(this.btnColorloop_Click);
            // 
            // btnOceanM
            // 
            this.btnOceanM.FlatAppearance.BorderSize = 0;
            this.btnOceanM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnOceanM.ForeColor = System.Drawing.Color.White;
            this.btnOceanM.Image = ((System.Drawing.Image)(resources.GetObject("btnOceanM.Image")));
            this.btnOceanM.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnOceanM.Location = new System.Drawing.Point(149, 107);
            this.btnOceanM.Name = "btnOceanM";
            this.btnOceanM.Size = new System.Drawing.Size(77, 39);
            this.btnOceanM.TabIndex = 10;
            this.btnOceanM.Text = "Ocean Mist";
            this.btnOceanM.UseVisualStyleBackColor = true;
            this.btnOceanM.Click += new System.EventHandler(this.btnOceanM_Click);
            // 
            // PCHueController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 436);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.lblCurrent);
            this.Controls.Add(this.pnlCurrentSwatch);
            this.Controls.Add(this.grpConnection);
            this.Controls.Add(this.groupBox1);
            this.Name = "PCHueController";
            this.Text = "PCHueController";
            this.grpConnection.ResumeLayout(false);
            this.grpConnection.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Label lblTitle3;
        private System.Windows.Forms.TextBox txtInputKey;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.GroupBox grpConnection;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnColorloop;
        private System.Windows.Forms.Button btnOceanM;
    }
}

