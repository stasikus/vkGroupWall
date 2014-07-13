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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.check_balance_btn = new System.Windows.Forms.Button();
            this.balance_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.antigateKey_TB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.captcha_manual = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.logout_btn = new System.Windows.Forms.Button();
            this.groupListBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginTextBox
            // 
            this.loginTextBox.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginTextBox.Location = new System.Drawing.Point(158, 9);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(150, 22);
            this.loginTextBox.TabIndex = 0;
            this.loginTextBox.Text = "staslk@ukr.net";
            // 
            // passTextBox
            // 
            this.passTextBox.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passTextBox.Location = new System.Drawing.Point(158, 48);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.PasswordChar = '*';
            this.passTextBox.Size = new System.Drawing.Size(150, 22);
            this.passTextBox.TabIndex = 1;
            this.passTextBox.Text = "S83v11875";
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.DarkGray;
            this.loginBtn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginBtn.Location = new System.Drawing.Point(13, 82);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(199, 23);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // statusLbl
            // 
            this.statusLbl.AutoSize = true;
            this.statusLbl.Location = new System.Drawing.Point(0, 0);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(0, 13);
            this.statusLbl.TabIndex = 3;
            // 
            // postBtn
            // 
            this.postBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.postBtn.Enabled = false;
            this.postBtn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.postBtn.Location = new System.Drawing.Point(12, 470);
            this.postBtn.Name = "postBtn";
            this.postBtn.Size = new System.Drawing.Size(295, 23);
            this.postBtn.TabIndex = 4;
            this.postBtn.Text = "Отправить данное сообщения на стены";
            this.postBtn.UseVisualStyleBackColor = false;
            this.postBtn.Click += new System.EventHandler(this.postBtn_Click);
            // 
            // messageTB
            // 
            this.messageTB.Enabled = false;
            this.messageTB.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.groupList.Location = new System.Drawing.Point(6, 21);
            this.groupList.Name = "groupList";
            this.groupList.Size = new System.Drawing.Size(188, 469);
            this.groupList.TabIndex = 7;
            // 
            // groupListBox
            // 
            this.groupListBox.Controls.Add(this.clean_btn);
            this.groupListBox.Controls.Add(this.groupList);
            this.groupListBox.Controls.Add(this.loadFromFile_btn);
            this.groupListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupListBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupListBox.Location = new System.Drawing.Point(324, 2);
            this.groupListBox.Name = "groupListBox";
            this.groupListBox.Size = new System.Drawing.Size(200, 520);
            this.groupListBox.TabIndex = 8;
            this.groupListBox.TabStop = false;
            this.groupListBox.Text = "Список групп";
            // 
            // clean_btn
            // 
            this.clean_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.clean_btn.Enabled = false;
            this.clean_btn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clean_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.clean_btn.Location = new System.Drawing.Point(125, 493);
            this.clean_btn.Name = "clean_btn";
            this.clean_btn.Size = new System.Drawing.Size(70, 23);
            this.clean_btn.TabIndex = 10;
            this.clean_btn.Text = "Очистить";
            this.clean_btn.UseVisualStyleBackColor = false;
            this.clean_btn.Click += new System.EventHandler(this.clean_btn_Click);
            // 
            // loadFromFile_btn
            // 
            this.loadFromFile_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.loadFromFile_btn.Enabled = false;
            this.loadFromFile_btn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loadFromFile_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.loadFromFile_btn.Location = new System.Drawing.Point(6, 493);
            this.loadFromFile_btn.Name = "loadFromFile_btn";
            this.loadFromFile_btn.Size = new System.Drawing.Size(120, 23);
            this.loadFromFile_btn.TabIndex = 9;
            this.loadFromFile_btn.Text = "Загрузить с файла";
            this.loadFromFile_btn.UseVisualStyleBackColor = false;
            this.loadFromFile_btn.Click += new System.EventHandler(this.loadFromFile_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.messageTB);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 258);
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 507);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Отправленно сообщений: ";
            // 
            // totalMessage_lbl
            // 
            this.totalMessage_lbl.AccessibleName = "count_lbl";
            this.totalMessage_lbl.AutoSize = true;
            this.totalMessage_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalMessage_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.totalMessage_lbl.Location = new System.Drawing.Point(200, 507);
            this.totalMessage_lbl.Name = "totalMessage_lbl";
            this.totalMessage_lbl.Size = new System.Drawing.Size(0, 15);
            this.totalMessage_lbl.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.check_balance_btn);
            this.groupBox2.Controls.Add(this.balance_lbl);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.antigateKey_TB);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.captcha_manual);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(12, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(295, 135);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Капча";
            // 
            // check_balance_btn
            // 
            this.check_balance_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.check_balance_btn.Enabled = false;
            this.check_balance_btn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.check_balance_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.check_balance_btn.Location = new System.Drawing.Point(219, 107);
            this.check_balance_btn.Name = "check_balance_btn";
            this.check_balance_btn.Size = new System.Drawing.Size(70, 23);
            this.check_balance_btn.TabIndex = 14;
            this.check_balance_btn.Text = "Проверка";
            this.check_balance_btn.UseVisualStyleBackColor = false;
            this.check_balance_btn.Click += new System.EventHandler(this.check_balance_btn_Click);
            // 
            // balance_lbl
            // 
            this.balance_lbl.AutoSize = true;
            this.balance_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.balance_lbl.Location = new System.Drawing.Point(70, 111);
            this.balance_lbl.Name = "balance_lbl";
            this.balance_lbl.Size = new System.Drawing.Size(0, 15);
            this.balance_lbl.TabIndex = 19;
            this.balance_lbl.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Ключ Antigate";
            // 
            // antigateKey_TB
            // 
            this.antigateKey_TB.Enabled = false;
            this.antigateKey_TB.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.antigateKey_TB.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.antigateKey_TB.Location = new System.Drawing.Point(6, 79);
            this.antigateKey_TB.Name = "antigateKey_TB";
            this.antigateKey_TB.Size = new System.Drawing.Size(283, 22);
            this.antigateKey_TB.TabIndex = 16;
            this.antigateKey_TB.Text = "2ce2be021b8bd05b8c210af8aaeeb3d1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "Баланс: ";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 38);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(83, 20);
            this.radioButton2.TabIndex = 15;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Antigate";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // captcha_manual
            // 
            this.captcha_manual.AutoSize = true;
            this.captcha_manual.Checked = true;
            this.captcha_manual.Location = new System.Drawing.Point(6, 19);
            this.captcha_manual.Name = "captcha_manual";
            this.captcha_manual.Size = new System.Drawing.Size(194, 20);
            this.captcha_manual.TabIndex = 14;
            this.captcha_manual.TabStop = true;
            this.captcha_manual.Text = "Вводить капчу руками";
            this.captcha_manual.UseVisualStyleBackColor = true;
            this.captcha_manual.CheckedChanged += new System.EventHandler(this.captcha_manual_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AccessibleName = "count_lbl";
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(9, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Телефон или Email ";
            // 
            // label5
            // 
            this.label5.AccessibleName = "count_lbl";
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.GrayText;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(12, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Пароль";
            // 
            // logout_btn
            // 
            this.logout_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.logout_btn.Enabled = false;
            this.logout_btn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logout_btn.Location = new System.Drawing.Point(218, 82);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(89, 23);
            this.logout_btn.TabIndex = 16;
            this.logout_btn.Text = "Log out";
            this.logout_btn.UseVisualStyleBackColor = false;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(540, 536);
            this.Controls.Add(this.logout_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.totalMessage_lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupListBox);
            this.Controls.Add(this.postBtn);
            this.Controls.Add(this.statusLbl);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.groupListBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button check_balance_btn;
        private System.Windows.Forms.Label balance_lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox antigateKey_TB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton captcha_manual;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button logout_btn;
    }
}

