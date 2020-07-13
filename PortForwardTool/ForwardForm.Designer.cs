namespace PortForwardTool
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.generalInfo = new System.Windows.Forms.GroupBox();
            this.forwardingType = new System.Windows.Forms.Label();
            this.forwardingTypeLabel = new System.Windows.Forms.Label();
            this.publicIp = new System.Windows.Forms.Label();
            this.ipLabel = new System.Windows.Forms.Label();
            this.portLabel = new System.Windows.Forms.Label();
            this.forwardButton = new System.Windows.Forms.Button();
            this.portInput = new System.Windows.Forms.NumericUpDown();
            this.successLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.portListContainer = new System.Windows.Forms.GroupBox();
            this.portList = new System.Windows.Forms.CheckedListBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.createFirewallRule = new System.Windows.Forms.CheckBox();
            this.generalInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portInput)).BeginInit();
            this.portListContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // generalInfo
            // 
            this.generalInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.generalInfo.AutoSize = true;
            this.generalInfo.Controls.Add(this.forwardingType);
            this.generalInfo.Controls.Add(this.forwardingTypeLabel);
            this.generalInfo.Controls.Add(this.publicIp);
            this.generalInfo.Controls.Add(this.ipLabel);
            this.generalInfo.Location = new System.Drawing.Point(12, 12);
            this.generalInfo.Name = "generalInfo";
            this.generalInfo.Size = new System.Drawing.Size(341, 83);
            this.generalInfo.TabIndex = 1;
            this.generalInfo.TabStop = false;
            this.generalInfo.Text = "General information";
            // 
            // forwardingType
            // 
            this.forwardingType.AutoSize = true;
            this.forwardingType.Location = new System.Drawing.Point(137, 48);
            this.forwardingType.Name = "forwardingType";
            this.forwardingType.Size = new System.Drawing.Size(66, 17);
            this.forwardingType.TabIndex = 3;
            this.forwardingType.Text = "Unknown";
            // 
            // forwardingTypeLabel
            // 
            this.forwardingTypeLabel.AutoSize = true;
            this.forwardingTypeLabel.Location = new System.Drawing.Point(6, 48);
            this.forwardingTypeLabel.Name = "forwardingTypeLabel";
            this.forwardingTypeLabel.Size = new System.Drawing.Size(113, 17);
            this.forwardingTypeLabel.TabIndex = 2;
            this.forwardingTypeLabel.Text = "Forwarding type:";
            // 
            // publicIp
            // 
            this.publicIp.AutoSize = true;
            this.publicIp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(130)))), ((int)(((byte)(190)))));
            this.publicIp.Location = new System.Drawing.Point(137, 27);
            this.publicIp.Name = "publicIp";
            this.publicIp.Size = new System.Drawing.Size(52, 17);
            this.publicIp.TabIndex = 1;
            this.publicIp.Text = "0.0.0.0";
            this.toolTip1.SetToolTip(this.publicIp, "Double click to copy");
            // 
            // ipLabel
            // 
            this.ipLabel.AutoSize = true;
            this.ipLabel.Location = new System.Drawing.Point(6, 27);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(125, 17);
            this.ipLabel.TabIndex = 0;
            this.ipLabel.Text = "Public IP address: ";
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(12, 99);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(101, 17);
            this.portLabel.TabIndex = 3;
            this.portLabel.Text = "Port to forward";
            // 
            // forwardButton
            // 
            this.forwardButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.forwardButton.Location = new System.Drawing.Point(125, 170);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(110, 36);
            this.forwardButton.TabIndex = 4;
            this.forwardButton.Text = "Forward";
            this.toolTip1.SetToolTip(this.forwardButton, "All forwarded ports are closed when this application gets closed");
            this.forwardButton.UseVisualStyleBackColor = true;
            this.forwardButton.Click += new System.EventHandler(this.Forward_click);
            // 
            // portInput
            // 
            this.portInput.Location = new System.Drawing.Point(15, 119);
            this.portInput.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.portInput.Name = "portInput";
            this.portInput.Size = new System.Drawing.Size(120, 22);
            this.portInput.TabIndex = 5;
            this.toolTip1.SetToolTip(this.portInput, "Forwarded ports are kept until the application is closed");
            this.portInput.Value = new decimal(new int[] {
            25565,
            0,
            0,
            0});
            this.portInput.ValueChanged += new System.EventHandler(this.OnPortValueChanged);
            // 
            // successLabel
            // 
            this.successLabel.AutoSize = true;
            this.successLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.successLabel.Location = new System.Drawing.Point(241, 180);
            this.successLabel.Name = "successLabel";
            this.successLabel.Size = new System.Drawing.Size(75, 17);
            this.successLabel.TabIndex = 6;
            this.successLabel.Text = "Forwarded";
            this.successLabel.Visible = false;
            // 
            // portListContainer
            // 
            this.portListContainer.Controls.Add(this.portList);
            this.portListContainer.Location = new System.Drawing.Point(21, 216);
            this.portListContainer.Name = "portListContainer";
            this.portListContainer.Size = new System.Drawing.Size(332, 155);
            this.portListContainer.TabIndex = 7;
            this.portListContainer.TabStop = false;
            this.portListContainer.Text = "Forwarded ports";
            // 
            // portList
            // 
            this.portList.CheckOnClick = true;
            this.portList.FormattingEnabled = true;
            this.portList.Location = new System.Drawing.Point(7, 22);
            this.portList.Name = "portList";
            this.portList.ScrollAlwaysVisible = true;
            this.portList.Size = new System.Drawing.Size(319, 123);
            this.portList.TabIndex = 0;
            this.portList.SelectedIndexChanged += new System.EventHandler(this.OnPortItemSelectionChange);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.OrangeRed;
            this.deleteButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(125, 377);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(110, 38);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Close ports";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Visible = false;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // createFirewallRule
            // 
            this.createFirewallRule.AutoSize = true;
            this.createFirewallRule.Checked = true;
            this.createFirewallRule.CheckState = System.Windows.Forms.CheckState.Checked;
            this.createFirewallRule.Location = new System.Drawing.Point(15, 147);
            this.createFirewallRule.Name = "createFirewallRule";
            this.createFirewallRule.Size = new System.Drawing.Size(147, 21);
            this.createFirewallRule.TabIndex = 10;
            this.createFirewallRule.Text = "Create firewall rule";
            this.createFirewallRule.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(371, 427);
            this.Controls.Add(this.createFirewallRule);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.portListContainer);
            this.Controls.Add(this.successLabel);
            this.Controls.Add(this.portInput);
            this.Controls.Add(this.forwardButton);
            this.Controls.Add(this.portLabel);
            this.Controls.Add(this.generalInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(389, 245);
            this.Name = "MainWindow";
            this.Text = "Forwarding tool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.generalInfo.ResumeLayout(false);
            this.generalInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portInput)).EndInit();
            this.portListContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox generalInfo;
        private System.Windows.Forms.Label ipLabel;
        private System.Windows.Forms.Label publicIp;
        private System.Windows.Forms.Label forwardingTypeLabel;
        private System.Windows.Forms.Label forwardingType;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.Button forwardButton;
        private System.Windows.Forms.NumericUpDown portInput;
        private System.Windows.Forms.Label successLabel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox portListContainer;
        private System.Windows.Forms.CheckedListBox portList;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.CheckBox createFirewallRule;
    }
}

