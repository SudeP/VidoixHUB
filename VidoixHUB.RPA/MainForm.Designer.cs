
namespace VidoixHUB.RPA
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pList = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.nudErrorWaitTime = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudErrorWaitTime)).BeginInit();
            this.SuspendLayout();
            // 
            // pList
            // 
            this.pList.AutoScroll = true;
            this.pList.BackColor = System.Drawing.Color.Silver;
            this.pList.Location = new System.Drawing.Point(12, 44);
            this.pList.Name = "pList";
            this.pList.Size = new System.Drawing.Size(640, 451);
            this.pList.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 26);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // nudErrorWaitTime
            // 
            this.nudErrorWaitTime.Location = new System.Drawing.Point(573, 12);
            this.nudErrorWaitTime.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.nudErrorWaitTime.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudErrorWaitTime.Name = "nudErrorWaitTime";
            this.nudErrorWaitTime.Size = new System.Drawing.Size(73, 26);
            this.nudErrorWaitTime.TabIndex = 2;
            this.nudErrorWaitTime.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudErrorWaitTime.ValueChanged += new System.EventHandler(this.NudErrorWaitTime_ValueChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(658, 507);
            this.Controls.Add(this.nudErrorWaitTime);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pList);
            this.Font = new System.Drawing.Font("Consolas", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MainForm";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.nudErrorWaitTime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pList;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown nudErrorWaitTime;
    }
}