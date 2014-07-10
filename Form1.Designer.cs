namespace vkGroupWall
{
    partial class Form1
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
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.statusLbl = new System.Windows.Forms.Label();
            this.postBtn = new System.Windows.Forms.Button();
            this.messageTB = new System.Windows.Forms.TextBox();
            this.groupList = new System.Windows.Forms.ListBox();
            this.groupListBox = new System.Windows.Forms.GroupBox();
            this.clean_btn = new System.Windows.Forms.Button();
            this.loadFromFile_btn = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.totalMessage_lbl = new System.Windows.Forms.Label();
            this.groupListBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(12, 12);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(100, 20);
            this.loginTextBox.TabIndex = 0;
            this.loginTextBox.Text = "staslk@ukr.net";
            // 
            // passTextBox
            // 
            this.passTextBox.Location = new System.Drawing.Point(12, 47);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.PasswordChar = '*';
            this.passTextBox.Size = new System.Drawing.Size(100, 20);
            this.passTextBox.TabIndex = 1;
            this.passTextBox.Text = "S83v11875";
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(12, 86);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(100, 23);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // statusLbl
            // 
            this.statusLbl.AutoSize = true;
            this.statusLbl.Location = new System.Drawing.Point(57, 135);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(0, 13);
            this.statusLbl.TabIndex = 3;
            // 
            // postBtn
            // 
            this.postBtn.Enabled = false;
            this.postBtn.Location = new System.Drawing.Point(342, 222);
            this.postBtn.Name = "postBtn";
            this.postBtn.Size = new System.Drawing.Size(283, 23);
            this.postBtn.TabIndex = 4;
            this.postBtn.Text = "Отправить данное сообщения на стены";
            this.postBtn.UseVisualStyleBackColor = true;
            this.postBtn.Click += new System.EventHandler(this.postBtn_Click);
            // 
            // messageTB
            // 
            this.messageTB.Enabled = false;
            this.messageTB.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.messageTB.Location = new System.Drawing.Point(6, 19);
            this.messageTB.Multiline = true;
            this.messageTB.Name = "messageTB";
            this.messageTB.Size = new System.Drawing.Size(283, 178);
            this.messageTB.TabIndex = 5;
            // 
            // groupList
            // 
            this.groupList.BackColor = System.Drawing.SystemColors.Control;
            this.groupList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupList.FormattingEnabled = true;
            this.groupList.ItemHeight = 15;
            this.groupList.Location = new System.Drawing.Point(7, 17);
            this.groupList.Name = "groupList";
            this.groupList.Size = new System.Drawing.Size(188, 229);
            this.groupList.TabIndex = 7;
            // 
            // groupListBox
            // 
            this.groupListBox.Controls.Add(this.clean_btn);
            this.groupListBox.Controls.Add(this.groupList);
            this.groupListBox.Controls.Add(this.loadFromFile_btn);
            this.groupListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupListBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupListBox.Location = new System.Drawing.Point(129, 9);
            this.groupListBox.Name = "groupListBox";
            this.groupListBox.Size = new System.Drawing.Size(200, 281);
            this.groupListBox.TabIndex = 8;
            this.groupListBox.TabStop = false;
            this.groupListBox.Text = "Список групп";
            // 
            // clean_btn
            // 
            this.clean_btn.Enabled = false;
            this.clean_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clean_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.clean_btn.Location = new System.Drawing.Point(125, 252);
            this.clean_btn.Name = "clean_btn";
            this.clean_btn.Size = new System.Drawing.Size(70, 23);
            this.clean_btn.TabIndex = 10;
            this.clean_btn.Text = "Очистить";
            this.clean_btn.UseVisualStyleBackColor = true;
            this.clean_btn.Click += new System.EventHandler(this.clean_btn_Click);
            // 
            // loadFromFile_btn
            // 
            this.loadFromFile_btn.Enabled = false;
            this.loadFromFile_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loadFromFile_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.loadFromFile_btn.Location = new System.Drawing.Point(6, 252);
            this.loadFromFile_btn.Name = "loadFromFile_btn";
            this.loadFromFile_btn.Size = new System.Drawing.Size(120, 23);
            this.loadFromFile_btn.TabIndex = 9;
            this.loadFromFile_btn.Text = "Загрузить с файла";
            this.loadFromFile_btn.UseVisualStyleBackColor = true;
            this.loadFromFile_btn.Click += new System.EventHandler(this.loadFromFile_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.messageTB);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(336, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 203);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сообщение";
            // 
            // label1
            // 
            this.label1.AccessibleName = "count_lbl";
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(339, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Отправленно сообщений: ";
            // 
            // totalMessage_lbl
            // 
            this.totalMessage_lbl.AccessibleName = "count_lbl";
            this.totalMessage_lbl.AutoSize = true;
            this.totalMessage_lbl.Location = new System.Drawing.Point(485, 259);
            this.totalMessage_lbl.Name = "totalMessage_lbl";
            this.totalMessage_lbl.Size = new System.Drawing.Size(0, 13);
            this.totalMessage_lbl.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(682, 327);
            this.Controls.Add(this.totalMessage_lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupListBox);
            this.Controls.Add(this.postBtn);
            this.Controls.Add(this.statusLbl);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Name = "Form1";
            this.Text = "VK";
            this.groupListBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.Button postBtn;
        private System.Windows.Forms.TextBox messageTB;
        private System.Windows.Forms.ListBox groupList;
        private System.Windows.Forms.GroupBox groupListBox;
        private System.Windows.Forms.Button loadFromFile_btn;
        private System.Windows.Forms.Button clean_btn;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalMessage_lbl;
    }
}

