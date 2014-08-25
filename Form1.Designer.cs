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
            this.captcha_antigate = new System.Windows.Forms.RadioButton();
            this.captcha_manual = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.logout_btn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.totalErrorMsg_lbl = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cleanUser_btn = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.loadAccs_lbl = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.notValidAccs_lbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.validAccs_lbl = new System.Windows.Forms.Label();
            this.loadAccFromFile = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cleanProxy_btn = new System.Windows.Forms.Button();
            this.addProxy_btn = new System.Windows.Forms.Button();
            this.loadProxy_btn = new System.Windows.Forms.Button();
            this.proxyList = new System.Windows.Forms.ListBox();
            this.groupListBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginTextBox
            // 
            this.loginTextBox.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginTextBox.Location = new System.Drawing.Point(134, 11);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(150, 22);
            this.loginTextBox.TabIndex = 0;
            this.loginTextBox.Text = "staslk@ukr.net";
            // 
            // passTextBox
            // 
            this.passTextBox.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passTextBox.Location = new System.Drawing.Point(134, 50);
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
            this.loginBtn.Location = new System.Drawing.Point(7, 132);
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
            this.postBtn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.postBtn.Location = new System.Drawing.Point(6, 516);
            this.postBtn.Name = "postBtn";
            this.postBtn.Size = new System.Drawing.Size(295, 23);
            this.postBtn.TabIndex = 4;
            this.postBtn.Text = "Отправить данное сообщения на стены";
            this.postBtn.UseVisualStyleBackColor = false;
            this.postBtn.Click += new System.EventHandler(this.postBtn_Click);
            // 
            // messageTB
            // 
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
            this.groupList.Location = new System.Drawing.Point(6, 19);
            this.groupList.Name = "groupList";
            this.groupList.Size = new System.Drawing.Size(188, 529);
            this.groupList.TabIndex = 7;
            // 
            // groupListBox
            // 
            this.groupListBox.Controls.Add(this.clean_btn);
            this.groupListBox.Controls.Add(this.groupList);
            this.groupListBox.Controls.Add(this.loadFromFile_btn);
            this.groupListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupListBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupListBox.Location = new System.Drawing.Point(312, 3);
            this.groupListBox.Name = "groupListBox";
            this.groupListBox.Size = new System.Drawing.Size(200, 577);
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
            this.clean_btn.Location = new System.Drawing.Point(125, 550);
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
            this.loadFromFile_btn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loadFromFile_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.loadFromFile_btn.Location = new System.Drawing.Point(6, 550);
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
            this.groupBox1.Location = new System.Drawing.Point(6, 304);
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
            this.label1.Location = new System.Drawing.Point(6, 542);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Сообщений отправленно:";
            // 
            // totalMessage_lbl
            // 
            this.totalMessage_lbl.AccessibleName = "count_lbl";
            this.totalMessage_lbl.AutoSize = true;
            this.totalMessage_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalMessage_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.totalMessage_lbl.Location = new System.Drawing.Point(209, 542);
            this.totalMessage_lbl.Name = "totalMessage_lbl";
            this.totalMessage_lbl.Size = new System.Drawing.Size(15, 15);
            this.totalMessage_lbl.TabIndex = 11;
            this.totalMessage_lbl.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.check_balance_btn);
            this.groupBox2.Controls.Add(this.balance_lbl);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.antigateKey_TB);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.captcha_antigate);
            this.groupBox2.Controls.Add(this.captcha_manual);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(6, 159);
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
            this.balance_lbl.Size = new System.Drawing.Size(14, 15);
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
            // captcha_antigate
            // 
            this.captcha_antigate.AutoSize = true;
            this.captcha_antigate.Location = new System.Drawing.Point(6, 38);
            this.captcha_antigate.Name = "captcha_antigate";
            this.captcha_antigate.Size = new System.Drawing.Size(83, 20);
            this.captcha_antigate.TabIndex = 15;
            this.captcha_antigate.TabStop = true;
            this.captcha_antigate.Text = "Antigate";
            this.captcha_antigate.UseVisualStyleBackColor = true;
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
            this.label4.BackColor = System.Drawing.SystemColors.GrayText;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(-2, 14);
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
            this.label5.Location = new System.Drawing.Point(-1, 51);
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
            this.logout_btn.Location = new System.Drawing.Point(212, 132);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(89, 23);
            this.logout_btn.TabIndex = 16;
            this.logout_btn.Text = "Log out";
            this.logout_btn.UseVisualStyleBackColor = false;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GrayText;
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(7, 575);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(296, 53);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Контакты";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Orange;
            this.label6.Location = new System.Drawing.Point(8, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(281, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "skype: wmwork              ICQ: 216 871 447";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Orange;
            this.label7.Location = new System.Drawing.Point(495, 601);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "staslkus";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Orange;
            this.label8.Location = new System.Drawing.Point(482, 603);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "©";
            // 
            // totalErrorMsg_lbl
            // 
            this.totalErrorMsg_lbl.AccessibleName = "count_lbl";
            this.totalErrorMsg_lbl.AutoSize = true;
            this.totalErrorMsg_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalErrorMsg_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.totalErrorMsg_lbl.Location = new System.Drawing.Point(209, 558);
            this.totalErrorMsg_lbl.Name = "totalErrorMsg_lbl";
            this.totalErrorMsg_lbl.Size = new System.Drawing.Size(15, 15);
            this.totalErrorMsg_lbl.TabIndex = 21;
            this.totalErrorMsg_lbl.Text = "0";
            // 
            // label10
            // 
            this.label10.AccessibleName = "count_lbl";
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(5, 558);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(198, 15);
            this.label10.TabIndex = 20;
            this.label10.Text = "Сообщений не отправленно:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.groupListBox);
            this.panel1.Controls.Add(this.totalErrorMsg_lbl);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.loginBtn);
            this.panel1.Controls.Add(this.postBtn);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.logout_btn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.totalMessage_lbl);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 630);
            this.panel1.TabIndex = 22;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(9, 14);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(294, 112);
            this.tabControl1.TabIndex = 23;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.GrayText;
            this.tabPage1.Controls.Add(this.loginTextBox);
            this.tabPage1.Controls.Add(this.passTextBox);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(286, 86);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Один акк";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.GrayText;
            this.tabPage2.Controls.Add(this.cleanUser_btn);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.loadAccs_lbl);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.notValidAccs_lbl);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.validAccs_lbl);
            this.tabPage2.Controls.Add(this.loadAccFromFile);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(286, 86);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Мульти акк";
            // 
            // cleanUser_btn
            // 
            this.cleanUser_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cleanUser_btn.Enabled = false;
            this.cleanUser_btn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cleanUser_btn.Location = new System.Drawing.Point(215, 9);
            this.cleanUser_btn.Name = "cleanUser_btn";
            this.cleanUser_btn.Size = new System.Drawing.Size(65, 71);
            this.cleanUser_btn.TabIndex = 18;
            this.cleanUser_btn.Text = "Очистить";
            this.cleanUser_btn.UseVisualStyleBackColor = false;
            this.cleanUser_btn.Click += new System.EventHandler(this.cleanUser_btn_Click);
            // 
            // label14
            // 
            this.label14.AccessibleName = "count_lbl";
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(6, 34);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(162, 15);
            this.label14.TabIndex = 16;
            this.label14.Text = "Загруженно аккаунтов:";
            // 
            // loadAccs_lbl
            // 
            this.loadAccs_lbl.AccessibleName = "count_lbl";
            this.loadAccs_lbl.AutoSize = true;
            this.loadAccs_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loadAccs_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.loadAccs_lbl.Location = new System.Drawing.Point(194, 34);
            this.loadAccs_lbl.Name = "loadAccs_lbl";
            this.loadAccs_lbl.Size = new System.Drawing.Size(15, 15);
            this.loadAccs_lbl.TabIndex = 17;
            this.loadAccs_lbl.Text = "0";
            // 
            // label12
            // 
            this.label12.AccessibleName = "count_lbl";
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(6, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(170, 15);
            this.label12.TabIndex = 14;
            this.label12.Text = "Не валидных аккаунтов:";
            // 
            // notValidAccs_lbl
            // 
            this.notValidAccs_lbl.AccessibleName = "count_lbl";
            this.notValidAccs_lbl.AutoSize = true;
            this.notValidAccs_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.notValidAccs_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.notValidAccs_lbl.Location = new System.Drawing.Point(194, 66);
            this.notValidAccs_lbl.Name = "notValidAccs_lbl";
            this.notValidAccs_lbl.Size = new System.Drawing.Size(15, 15);
            this.notValidAccs_lbl.TabIndex = 15;
            this.notValidAccs_lbl.Text = "0";
            // 
            // label9
            // 
            this.label9.AccessibleName = "count_lbl";
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(6, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 15);
            this.label9.TabIndex = 12;
            this.label9.Text = "Валидных аккаунтов:";
            // 
            // validAccs_lbl
            // 
            this.validAccs_lbl.AccessibleName = "count_lbl";
            this.validAccs_lbl.AutoSize = true;
            this.validAccs_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.validAccs_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.validAccs_lbl.Location = new System.Drawing.Point(194, 50);
            this.validAccs_lbl.Name = "validAccs_lbl";
            this.validAccs_lbl.Size = new System.Drawing.Size(15, 15);
            this.validAccs_lbl.TabIndex = 13;
            this.validAccs_lbl.Text = "0";
            // 
            // loadAccFromFile
            // 
            this.loadAccFromFile.BackColor = System.Drawing.Color.DarkGray;
            this.loadAccFromFile.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loadAccFromFile.Location = new System.Drawing.Point(6, 9);
            this.loadAccFromFile.Name = "loadAccFromFile";
            this.loadAccFromFile.Size = new System.Drawing.Size(205, 23);
            this.loadAccFromFile.TabIndex = 3;
            this.loadAccFromFile.Text = "Загрузить аккаунты с файла";
            this.loadAccFromFile.UseVisualStyleBackColor = false;
            this.loadAccFromFile.Click += new System.EventHandler(this.loadAccFromFile_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cleanProxy_btn);
            this.groupBox4.Controls.Add(this.addProxy_btn);
            this.groupBox4.Controls.Add(this.loadProxy_btn);
            this.groupBox4.Controls.Add(this.proxyList);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox4.Location = new System.Drawing.Point(523, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 577);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Proxy";
            // 
            // cleanProxy_btn
            // 
            this.cleanProxy_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cleanProxy_btn.Enabled = false;
            this.cleanProxy_btn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cleanProxy_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cleanProxy_btn.Location = new System.Drawing.Point(6, 548);
            this.cleanProxy_btn.Name = "cleanProxy_btn";
            this.cleanProxy_btn.Size = new System.Drawing.Size(188, 23);
            this.cleanProxy_btn.TabIndex = 13;
            this.cleanProxy_btn.Text = "Очистить";
            this.cleanProxy_btn.UseVisualStyleBackColor = false;
            this.cleanProxy_btn.Click += new System.EventHandler(this.cleanProxy_btn_Click);
            // 
            // addProxy_btn
            // 
            this.addProxy_btn.BackColor = System.Drawing.Color.DarkGray;
            this.addProxy_btn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addProxy_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addProxy_btn.Location = new System.Drawing.Point(100, 523);
            this.addProxy_btn.Name = "addProxy_btn";
            this.addProxy_btn.Size = new System.Drawing.Size(94, 23);
            this.addProxy_btn.TabIndex = 12;
            this.addProxy_btn.Text = "Добавить";
            this.addProxy_btn.UseVisualStyleBackColor = false;
            this.addProxy_btn.Click += new System.EventHandler(this.addProxy_btn_Click);
            // 
            // loadProxy_btn
            // 
            this.loadProxy_btn.BackColor = System.Drawing.Color.DarkGray;
            this.loadProxy_btn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loadProxy_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.loadProxy_btn.Location = new System.Drawing.Point(6, 523);
            this.loadProxy_btn.Name = "loadProxy_btn";
            this.loadProxy_btn.Size = new System.Drawing.Size(94, 23);
            this.loadProxy_btn.TabIndex = 11;
            this.loadProxy_btn.Text = "Загрузить";
            this.loadProxy_btn.UseVisualStyleBackColor = false;
            this.loadProxy_btn.Click += new System.EventHandler(this.loadProxy_btn_Click);
            // 
            // proxyList
            // 
            this.proxyList.BackColor = System.Drawing.SystemColors.Control;
            this.proxyList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.proxyList.FormattingEnabled = true;
            this.proxyList.ItemHeight = 15;
            this.proxyList.Location = new System.Drawing.Point(6, 19);
            this.proxyList.MaximumSize = new System.Drawing.Size(188, 505);
            this.proxyList.MinimumSize = new System.Drawing.Size(188, 505);
            this.proxyList.Name = "proxyList";
            this.proxyList.Size = new System.Drawing.Size(188, 499);
            this.proxyList.TabIndex = 100;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(745, 632);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.groupListBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
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
        private System.Windows.Forms.RadioButton captcha_antigate;
        private System.Windows.Forms.RadioButton captcha_manual;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label totalErrorMsg_lbl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button cleanProxy_btn;
        private System.Windows.Forms.Button addProxy_btn;
        private System.Windows.Forms.Button loadProxy_btn;
        private System.Windows.Forms.ListBox proxyList;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label notValidAccs_lbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label validAccs_lbl;
        private System.Windows.Forms.Button loadAccFromFile;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label loadAccs_lbl;
        private System.Windows.Forms.Button cleanUser_btn;
    }
}

