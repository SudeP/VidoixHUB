
namespace VidoixHUB.Farmer.Forms
{
    partial class WebForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WebForm));
            this.pUI = new System.Windows.Forms.Panel();
            this.btnUIHide = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.tbxUserName = new System.Windows.Forms.TextBox();
            this.btnCloseDevTool = new System.Windows.Forms.Button();
            this.btnShowDevTool = new System.Windows.Forms.Button();
            this.lblHeight = new System.Windows.Forms.Label();
            this.nudHeigth = new System.Windows.Forms.NumericUpDown();
            this.lblWidth = new System.Windows.Forms.Label();
            this.nudWidth = new System.Windows.Forms.NumericUpDown();
            this.btnUIShow = new System.Windows.Forms.Button();
            this.pUI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeigth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // pUI
            // 
            this.pUI.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pUI.BackColor = System.Drawing.Color.White;
            this.pUI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pUI.Controls.Add(this.btnUIHide);
            this.pUI.Controls.Add(this.lblPassword);
            this.pUI.Controls.Add(this.lblUsername);
            this.pUI.Controls.Add(this.tbxPassword);
            this.pUI.Controls.Add(this.tbxUserName);
            this.pUI.Controls.Add(this.btnCloseDevTool);
            this.pUI.Controls.Add(this.btnShowDevTool);
            this.pUI.Controls.Add(this.lblHeight);
            this.pUI.Controls.Add(this.nudHeigth);
            this.pUI.Controls.Add(this.lblWidth);
            this.pUI.Controls.Add(this.nudWidth);
            this.pUI.Font = new System.Drawing.Font("Consolas", 12F);
            this.pUI.Location = new System.Drawing.Point(12, 128);
            this.pUI.Name = "pUI";
            this.pUI.Size = new System.Drawing.Size(535, 119);
            this.pUI.TabIndex = 0;
            this.pUI.Visible = false;
            // 
            // btnUIHide
            // 
            this.btnUIHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUIHide.Font = new System.Drawing.Font("Consolas", 8F);
            this.btnUIHide.Location = new System.Drawing.Point(439, 3);
            this.btnUIHide.Name = "btnUIHide";
            this.btnUIHide.Size = new System.Drawing.Size(91, 19);
            this.btnUIHide.TabIndex = 10;
            this.btnUIHide.Text = "Paneli Kapat";
            this.btnUIHide.UseVisualStyleBackColor = true;
            this.btnUIHide.Click += new System.EventHandler(this.BtnUIHide_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(361, 65);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(81, 19);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(191, 66);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(81, 19);
            this.lblUsername.TabIndex = 8;
            this.lblUsername.Text = "Username";
            // 
            // tbxPassword
            // 
            this.tbxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbxPassword.Location = new System.Drawing.Point(365, 87);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.ReadOnly = true;
            this.tbxPassword.Size = new System.Drawing.Size(164, 26);
            this.tbxPassword.TabIndex = 7;
            // 
            // tbxUserName
            // 
            this.tbxUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbxUserName.Location = new System.Drawing.Point(195, 87);
            this.tbxUserName.Name = "tbxUserName";
            this.tbxUserName.ReadOnly = true;
            this.tbxUserName.Size = new System.Drawing.Size(164, 26);
            this.tbxUserName.TabIndex = 6;
            // 
            // btnCloseDevTool
            // 
            this.btnCloseDevTool.Location = new System.Drawing.Point(140, 3);
            this.btnCloseDevTool.Name = "btnCloseDevTool";
            this.btnCloseDevTool.Size = new System.Drawing.Size(131, 48);
            this.btnCloseDevTool.TabIndex = 5;
            this.btnCloseDevTool.Text = "DevTool Kapa";
            this.btnCloseDevTool.UseVisualStyleBackColor = true;
            this.btnCloseDevTool.Click += new System.EventHandler(this.BtnCloseDevTool_Click);
            // 
            // btnShowDevTool
            // 
            this.btnShowDevTool.Location = new System.Drawing.Point(3, 3);
            this.btnShowDevTool.Name = "btnShowDevTool";
            this.btnShowDevTool.Size = new System.Drawing.Size(131, 48);
            this.btnShowDevTool.TabIndex = 4;
            this.btnShowDevTool.Text = "DevTool Aç";
            this.btnShowDevTool.UseVisualStyleBackColor = true;
            this.btnShowDevTool.Click += new System.EventHandler(this.BtnShowDevTool_Click);
            // 
            // lblHeight
            // 
            this.lblHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(99, 66);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(63, 19);
            this.lblHeight.TabIndex = 3;
            this.lblHeight.Text = "Heigth";
            // 
            // nudHeigth
            // 
            this.nudHeigth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudHeigth.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudHeigth.Location = new System.Drawing.Point(99, 88);
            this.nudHeigth.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudHeigth.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudHeigth.Name = "nudHeigth";
            this.nudHeigth.ReadOnly = true;
            this.nudHeigth.Size = new System.Drawing.Size(90, 26);
            this.nudHeigth.TabIndex = 2;
            this.nudHeigth.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudHeigth.ValueChanged += new System.EventHandler(this.NudHeigth_ValueChanged);
            // 
            // lblWidth
            // 
            this.lblWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(3, 66);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(54, 19);
            this.lblWidth.TabIndex = 1;
            this.lblWidth.Text = "Width";
            // 
            // nudWidth
            // 
            this.nudWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudWidth.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudWidth.Location = new System.Drawing.Point(3, 88);
            this.nudWidth.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudWidth.Minimum = new decimal(new int[] {
            575,
            0,
            0,
            0});
            this.nudWidth.Name = "nudWidth";
            this.nudWidth.ReadOnly = true;
            this.nudWidth.Size = new System.Drawing.Size(90, 26);
            this.nudWidth.TabIndex = 0;
            this.nudWidth.Value = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.nudWidth.ValueChanged += new System.EventHandler(this.NudWidth_ValueChanged);
            // 
            // btnUIShow
            // 
            this.btnUIShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUIShow.Font = new System.Drawing.Font("Consolas", 8F);
            this.btnUIShow.Location = new System.Drawing.Point(442, 221);
            this.btnUIShow.Name = "btnUIShow";
            this.btnUIShow.Size = new System.Drawing.Size(100, 20);
            this.btnUIShow.TabIndex = 1;
            this.btnUIShow.Text = "Paneli Aç";
            this.btnUIShow.UseVisualStyleBackColor = true;
            this.btnUIShow.Click += new System.EventHandler(this.BtnUIShow_Click);
            // 
            // WebForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 259);
            this.Controls.Add(this.pUI);
            this.Controls.Add(this.btnUIShow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WebForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Farmer";
            this.pUI.ResumeLayout(false);
            this.pUI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeigth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pUI;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.NumericUpDown nudWidth;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.NumericUpDown nudHeigth;
        private System.Windows.Forms.Button btnCloseDevTool;
        private System.Windows.Forms.Button btnShowDevTool;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.TextBox tbxUserName;
        private System.Windows.Forms.Button btnUIHide;
        private System.Windows.Forms.Button btnUIShow;
    }
}