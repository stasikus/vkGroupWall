using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vkGroupWall
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Net http = new Net(); //Создаем объект
        string html = "";
        

        private void loginBtn_Click(object sender, EventArgs e)
        {
            loginBtn.BackColor = Color.WhiteSmoke;
            loginBtn.Enabled = false;
            
            string login = loginTextBox.Text;
            string password = passTextBox.Text;

            int status = vkLogin.Login(login, password, html, http); //Login
            statusLbl.Text = status.ToString();

            if (status == 1)
            {
                loginBtn.Enabled = false;
                loginBtn.BackColor = Color.WhiteSmoke;
                loadFromFile_btn.BackColor = Color.DarkGray;
                loadFromFile_btn.Enabled = true;
                logout_btn.Enabled = true;
                logout_btn.BackColor = Color.DarkGray;
                loginTextBox.Enabled = false;
                passTextBox.Enabled = false;
                if (LoadList.groups.Count > 0)
                {
                    postBtn.Enabled = true;
                    messageTB.Enabled = true;
                    postBtn.BackColor = Color.DarkGray;
                }
            }
            else
            {
                loginTextBox.Enabled = true;
                passTextBox.Enabled = true;
                logout_btn.Enabled = false;
                logout_btn.BackColor = Color.WhiteSmoke;
                loginBtn.BackColor = Color.DarkGray;
                loginBtn.Enabled = true;
                postBtn.BackColor = Color.WhiteSmoke;
                loadFromFile_btn.BackColor = Color.WhiteSmoke;
                loadFromFile_btn.Enabled = false;
                postBtn.Enabled = false;
                messageTB.Enabled = false;
                MessageBox.Show("Неверный пароль или аккаунт заблокирован");
            }
        }

        public void postWall()
        {
            Thread tr = new Thread(qwert);
            tr.IsBackground = true;
            tr.Start();
        }

        void qwert()
        {
            bool inputCaptchaType = true;
            if (captcha_manual.Checked != true)
                inputCaptchaType = false;

            for (int i = 0; i < groupList.Items.Count; i++)
            {
                string html = http.GetHtml("https://vk.com/" + groupList.Items[i].ToString(), "");

                string groupID = html.Remove(0, html.IndexOf("\"group_id\":") + 11);
                groupID = groupID.Substring(0, groupID.IndexOf(","));
                string publicID = html.Remove(0, html.IndexOf("\"public_id\":") + 12);
                publicID = publicID.Substring(0, publicID.IndexOf(","));
                string hash = html.Remove(0, html.IndexOf("\"post_hash\":") + 13);
                hash = hash.Substring(0, hash.IndexOf("\""));

                string idForPost;
                if (groupID.Length < 30)
                    idForPost = groupID;
                else
                    idForPost = publicID;

                string post = "Message=" + System.Web.HttpUtility.UrlEncode(messageTB.Text) + i.ToString() + "&act=post&al=1&facebook_export=&fixed=&friends_only=&from=&hash=" + hash + "&official=&signed=&status_export=&to_id=-" + idForPost + "&type=all";
                string htmlResp = http.PostMessage("https://vk.com/al_wall.php", groupList.Items[i].ToString(), post, messageTB.Text, hash, idForPost, inputCaptchaType, antigateKey_TB.Text);


                totalMessage_lbl.BeginInvoke((Action)delegate
                {
                    totalMessage_lbl.Text = (i + 1).ToString();
                });
            }
            MessageBox.Show("Все сообщения были отправлены");
        }

        private void postBtn_Click(object sender, EventArgs e)
        {
            if (messageTB.TextLength > 0)
            {
                postWall();
            }
            else
            {
                MessageBox.Show("Сообщение не может быть пустым");
            }
        }

        private void loadFromFile_btn_Click(object sender, EventArgs e)
        {
            string path;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                groupList.Items.Clear();
                path = openFileDialog.FileName;
                LoadList.loadList(path);
            }
            
            for (int i = 0; i < LoadList.groups.Count; i++)
            {
                groupList.Items.Add(LoadList.groups[i]);
            }

            if (LoadList.groups.Count > 0)
            {
                clean_btn.Enabled = true;
                clean_btn.BackColor = Color.DarkGray;
                if (statusLbl.Text == "1")
                {
                    postBtn.BackColor = Color.DarkGray;
                    postBtn.Enabled = true;
                    messageTB.Enabled = true;
                }
                else
                {
                    postBtn.BackColor = Color.WhiteSmoke;
                }
            }
        }

        private void clean_btn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(groupList.Items.Count + " " + LoadList.groups.Count);
            groupList.Items.Clear();
            clean_btn.Enabled = false;
            clean_btn.BackColor = Color.WhiteSmoke;
        }

        private void check_balance_btn_Click(object sender, EventArgs e)
        {
            balance_lbl.Text = "0";
            Thread tr = new Thread(checkBalance);
            tr.IsBackground = true;
            tr.Start();
        }

        void checkBalance()
        {
            try
            {
                balance_lbl.BeginInvoke((Action)delegate
                {
                    balance_lbl.Text = Anticaptcha.Balance(antigateKey_TB.Text) + " $";
                });
            }
            catch (Exception)
            {
                MessageBox.Show("Данный ключ не валидный");
            }
                
        }

        private void captcha_manual_CheckedChanged(object sender, EventArgs e)
        {
            if (captcha_manual.Checked == true)
            {
                antigateKey_TB.Enabled = false;
                check_balance_btn.Enabled = false;
                check_balance_btn.BackColor = Color.WhiteSmoke;
            }
            else
            {
                antigateKey_TB.Enabled = true;
                check_balance_btn.Enabled = true;
                check_balance_btn.BackColor = Color.DarkGray;
            }
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            loginTextBox.Enabled = true;
            passTextBox.Enabled = true;
            loginBtn.Enabled = true;
            loginBtn.BackColor = Color.DarkGray;
            logout_btn.Enabled = false;
            logout_btn.BackColor = Color.WhiteSmoke;
            loadFromFile_btn.Enabled = false;
            loadFromFile_btn.BackColor = Color.WhiteSmoke;
            clean_btn.Enabled = false;
            clean_btn.BackColor = Color.WhiteSmoke;
            messageTB.Enabled = false;
            postBtn.Enabled = false;
            postBtn.BackColor = Color.WhiteSmoke;

        }


    }


}
