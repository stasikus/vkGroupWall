namespace vkGroupWall
{
    partial class AddProxyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProxyForm));
            this.proxyIP_TB = new System.Windows.Forms.TextBox();
            this.addProxy_btn = new System.Windows.Forms.Button();
            this.proxyPort_TB = new System.Windows.Forms.TextBox();
            this.proxyLogin_TB = new System.Windows.Forms.TextBox();
            this.proxyPass_TB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // proxyIP_TB
            // 
            this.proxyIP_TB.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.proxyIP_TB.Location = new System.Drawing.Point(61, 8);
            this.proxyIP_TB.Name = "proxyIP_TB";
            this.proxyIP_TB.Size = new System.Drawing.Size(140, 22);
            this.proxyIP_TB.TabIndex = 1;
            // 
            // addProxy_btn
            // 
            this.addProxy_btn.BackColor = System.Drawing.Color.DarkGray;
            this.addProxy_btn.Location = new System.Drawing.Point(66, 122);
            this.addProxy_btn.Name = "addProxy_btn";
            this.addProxy_btn.Size = new System.Drawing.Size(75, 23);
            this.addProxy_btn.TabIndex = 2;
            this.addProxy_btn.Text = "OK";
            this.addProxy_btn.UseVisualStyleBackColor = false;
            this.addProxy_btn.Click += new System.EventHandler(this.addProxy_btn_Click);
            // 
            // proxyPort_TB
            // 
            this.proxyPort_TB.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.proxyPort_TB.Location = new System.Drawing.Point(61, 36);
            this.proxyPort_TB.Name = "proxyPort_TB";
            this.proxyPort_TB.Size = new System.Drawing.Size(70, 22);
            this.proxyPort_TB.TabIndex = 3;
            // 
            // proxyLogin_TB
            // 
            this.proxyLogin_TB.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.proxyLogin_TB.Location = new System.Drawing.Point(61, 63);
            this.proxyLogin_TB.Name = "proxyLogin_TB";
            this.proxyLogin_TB.Size = new System.Drawing.Size(140, 22);
            this.proxyLogin_TB.TabIndex = 4;
            // 
            // proxyPass_TB
            // 
            this.proxyPass_TB.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.proxyPass_TB.Location = new System.Drawing.Point(61, 91);
            this.proxyPass_TB.Name = "proxyPass_TB";
            this.proxyPass_TB.Size = new System.Drawing.Size(140, 22);
            this.proxyPass_TB.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(2, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(2, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Pass";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(3, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "IP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(3, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Port";
            // 
            // AddProxyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(209, 152);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.proxyPass_TB);
            this.Controls.Add(this.proxyLogin_TB);
            this.Controls.Add(this.proxyPort_TB);
            this.Controls.Add(this.addProxy_btn);
            this.Controls.Add(this.proxyIP_TB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(225, 190);
            this.MinimumSize = new System.Drawing.Size(225, 190);
            this.Name = "AddProxyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox proxyIP_TB;
        private System.Windows.Forms.Button addProxy_btn;
        private System.Windows.Forms.TextBox proxyPort_TB;
        private System.Windows.Forms.TextBox proxyLogin_TB;
        private System.Windows.Forms.TextBox proxyPass_TB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}