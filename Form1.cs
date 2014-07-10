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
            string login = loginTextBox.Text;
            string password = passTextBox.Text;

            int status = vkLogin.Login(login, password, html, http); //Login
            statusLbl.Text = status.ToString();

            if (status == 1)
            {
                loadFromFile_btn.Enabled = true;
                if (LoadList.groups.Count > 0)
                {
                    postBtn.Enabled = true;
                    messageTB.Enabled = true;
                }
            }
            else
            {
                loadFromFile_btn.Enabled = false;
                postBtn.Enabled = false;
                messageTB.Enabled = false;
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

                // string captchaID = http.TestCaptch(html);
                string post = "Message=" + messageTB.Text + i.ToString() + "&act=post&al=1&facebook_export=&fixed=&friends_only=&from=&hash=" + hash + "&official=&signed=&status_export=&to_id=-" + idForPost + "&type=all";
                string htmlResp = http.PostMessage("https://vk.com/al_wall.php", groupList.Items[i].ToString(), post, messageTB.Text, hash, idForPost);
                //Thread.Sleep(1000);

                totalMessage_lbl.BeginInvoke((Action)delegate
                {
                    totalMessage_lbl.Text = (i + 1).ToString();
                });
            }
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
                if (statusLbl.Text == "1")
                {
                    postBtn.Enabled = true;
                    messageTB.Enabled = true;
                }
            }
        }

        private void clean_btn_Click(object sender, EventArgs e)
        {
            groupList.Items.Clear();
            clean_btn.Enabled = false;
        }

        private void check_balance_btn_Click(object sender, EventArgs e)
        {
            Thread tr = new Thread(checkBalance);
            tr.IsBackground = true;
            tr.Start();
        }

        void checkBalance()
        {
            balance_lbl.Text = null;
            try
            {
                balance_lbl.Text = Anticaptcha.Balance(antigateKey.Text) + " $";
            }
            catch (Exception)
            {
            }
                
        }

    }


}
