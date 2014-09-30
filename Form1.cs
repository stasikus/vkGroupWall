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
        int accsTypes;
        public static Dictionary<string, string> activeUsersList = new Dictionary<string, string>();
        public int messageCounter = 0;

        public void loginBtn_Click(object sender, EventArgs e)
        {
            TotalCounter.Invalid = 0;
            TotalCounter.Valid = 0;
            validAccs_lbl.Text = "0";
            notValidAccs_lbl.Text = "0";

            Random random = new Random();
            int j = proxyList.Items.Count;

            if (LoadUsers.users.Count > 0) //если юзеров много (с файла)
            {
                accsTypes = 0;
                for (int i = 0; i < LoadUsers.users.Count; i++)
                {
                    Thread tr = new Thread(() => loginFunc(LoadUsers.userDictionary.ElementAt(i).Key, LoadUsers.userDictionary.ElementAt(i).Value, accsTypes, proxyList.Items[(random.Next(1, j)) - 1].ToString()));
                    Thread tr1 = new Thread(() => loginFunc(LoadUsers.userDictionary.ElementAt(i).Key, LoadUsers.userDictionary.ElementAt(i).Value, accsTypes, ""));
                    if (proxyList.Items.Count != 0) //если есть прокси
                    {
                        tr.IsBackground = true;
                        tr.Start();
                        Thread.Sleep(1000);
                    }
                    else //если нет прокси
                    {
                        tr1.IsBackground = true;
                        tr1.Start();
                        Thread.Sleep(1000);
                    }
                }
            }
            else
            {
                accsTypes = 1;
                Thread tr = new Thread(() => loginFunc(loginTextBox.Text, passTextBox.Text, accsTypes, proxyList.Items[0].ToString()));
                Thread tr1 = new Thread(() => loginFunc(loginTextBox.Text, passTextBox.Text, accsTypes, ""));
                if (proxyList.Items.Count != 0)
                {
                    tr.IsBackground = true;
                    tr.Start();
                }
                else
                {
                    tr1.IsBackground = true;
                    tr1.Start();
                }
            }
        }

        public void loginFunc(string login, string pass, int accsType, string proxys)
        {
            loginBtn.BeginInvoke((Action)delegate
            {
              //  loginBtn.BackColor = Color.WhiteSmoke;
              //  loginBtn.Enabled = false;
            });

            int status = vkLogin.Login(login, pass, html, http, proxys); //Login

            if (status == 1) // валидный акк
            {
                if (accsType == 0)
                {
                    validAccs_lbl.BeginInvoke((Action)delegate
                    {
                        validAccs_lbl.Text = TotalCounter.ValidAccs().ToString();

                    });
                    activeUsersList.Add(login, pass);

                    
                }

                panel1.BeginInvoke((Action)delegate
                {
                    /* loginBtn.Enabled = false;
                     loginBtn.BackColor = Color.WhiteSmoke;
                     loadFromFile_btn.BackColor = Color.DarkGray;
                     loadFromFile_btn.Enabled = true;
                     logout_btn.Enabled = true;
                     logout_btn.BackColor = Color.DarkGray;
                     loginTextBox.Enabled = false;
                     passTextBox.Enabled = false;
                     loadAccFromFile.Enabled = false;
                     loadAccFromFile.BackColor = Color.WhiteSmoke;
                     cleanUser_btn.Enabled = false;
                     cleanUser_btn.BackColor = Color.WhiteSmoke; */
                     if (LoadList.groups.Count > 0)
                     {
                          /* postBtn.Enabled = true;
                         messageTB.Enabled = true;
                         postBtn.BackColor = Color.DarkGray;*/
                     }
                 });
             }
             else
             {
                 panel1.BeginInvoke((Action)delegate
                 {
                  /*   loginTextBox.Enabled = true;
                     passTextBox.Enabled = true;
                     logout_btn.Enabled = false;
                     logout_btn.BackColor = Color.WhiteSmoke;
                     loginBtn.BackColor = Color.DarkGray;
                     loginBtn.Enabled = true;
                     postBtn.BackColor = Color.WhiteSmoke;
                     loadFromFile_btn.BackColor = Color.WhiteSmoke;
                   //  loadFromFile_btn.Enabled = false;
                     postBtn.Enabled = false;
                     messageTB.Enabled = false;
                     loadAccFromFile.Enabled = true;
                     loadAccFromFile.BackColor = Color.DarkGray;
                     if (LoadUsers.users.Count > 0)
                     {
                         cleanUser_btn.Enabled = true;
                         cleanUser_btn.BackColor = Color.DarkGray;
                     }
                     else
                     {
                         cleanUser_btn.Enabled = false;
                         cleanUser_btn.BackColor = Color.WhiteSmoke;
                     }*/
                });

                if (accsType == 1)
                    MessageBox.Show("Неверный пароль или аккаунт заблокирован");
                else
                {
                    notValidAccs_lbl.BeginInvoke((Action)delegate
                    {
                        notValidAccs_lbl.Text = TotalCounter.InvalidAccs().ToString();
                    });
                }
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

           // for (messageCounter; messageCounter < groupList.Items.Count; messageCounter++)
            //{
            while(messageCounter < groupList.Items.Count)
            {
                string html = http.GetHtml("https://vk.com/" + groupList.Items[messageCounter].ToString(), "", "");

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

                string post = "Message=" + System.Web.HttpUtility.UrlEncode(messageTB.Text) + "&act=post&al=1&facebook_export=&fixed=&friends_only=&from=&hash=" + hash + "&official=&signed=&status_export=&to_id=-" + idForPost + "&type=all";
                string htmlResp = http.PostMessage("https://vk.com/al_wall.php", groupList.Items[messageCounter].ToString(), post, messageTB.Text, hash, idForPost, inputCaptchaType, antigateKey_TB.Text);

                int errorHtml = htmlResp.IndexOf("<!>8<!>");

                if (errorHtml == -1) // сообщений отправленно
                {
                    totalMessage_lbl.BeginInvoke((Action)delegate
                    {
                        totalMessage_lbl.Text = TotalCounter.SuccessMessages().ToString();
                    });
                }
                else // сообщений не отправленно
                {

                    totalErrorMsg_lbl.BeginInvoke((Action)delegate
                    {
                        totalErrorMsg_lbl.Text = TotalCounter.FailMessages().ToString();
                    });
                }

                messageCounter++;
            }
              
          /*  MessageBox.Show("Все сообщения были отправлены");
            panel1.BeginInvoke((Action)delegate
            {
                panel1.Enabled = true;
                postActive();
            });*/
        }

        private void postBtn_Click(object sender, EventArgs e)
        {
            if (messageTB.TextLength > 0)
            {
                postNotActive();
                postWall();
                panel1.Enabled = false;
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
                LoadList.loadGroupList(path);
            }
            
            for (int i = 0; i < LoadList.groups.Count; i++)
            {
                groupList.Items.Add(LoadList.groups[i]);
            }

            if (LoadList.groups.Count > 0)
            {
              //  clean_btn.Enabled = true;
              //  clean_btn.BackColor = Color.DarkGray;
                if (statusLbl.Text == "1")
                {
               //     postBtn.BackColor = Color.DarkGray;
               //     postBtn.Enabled = true;
               //     messageTB.Enabled = true;
                }
                else
                {
              //      postBtn.BackColor = Color.WhiteSmoke;
                }
            }
        }

        private void clean_btn_Click(object sender, EventArgs e)
        {
            groupList.Items.Clear();
           // clean_btn.Enabled = false;
           // clean_btn.BackColor = Color.WhiteSmoke;
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
           //     antigateKey_TB.Enabled = false;
           //     check_balance_btn.Enabled = false;
           //     check_balance_btn.BackColor = Color.WhiteSmoke;
            }
            else
            {
             //   antigateKey_TB.Enabled = true;
             //   check_balance_btn.Enabled = true;
             //   check_balance_btn.BackColor = Color.DarkGray;
            }
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            /*    loginTextBox.Enabled = true;
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
                loadAccFromFile.Enabled = true;
                loadAccFromFile.BackColor = Color.DarkGray;
                if (LoadUsers.users.Count > 0)
                {
                    cleanUser_btn.Enabled = true;
                    cleanUser_btn.BackColor = Color.DarkGray;
                }
                else
                {
                    cleanUser_btn.Enabled = false;
                    cleanUser_btn.BackColor = Color.WhiteSmoke;
                }*/
        }

        public void postNotActive()
        {
            //postBtn.BackColor = Color.WhiteSmoke;
            //logout_btn.BackColor = Color.WhiteSmoke;
            //loadFromFile_btn.BackColor = Color.WhiteSmoke;
            //clean_btn.BackColor = Color.WhiteSmoke;
            //check_balance_btn.BackColor = Color.WhiteSmoke;
        }

        public void postActive()
        {
            //postBtn.BackColor = Color.DarkGray;
            //logout_btn.BackColor = Color.DarkGray;
            //loadFromFile_btn.BackColor = Color.DarkGray;
            //clean_btn.BackColor = Color.DarkGray;

            //if(captcha_antigate.Checked == true)
            //    check_balance_btn.BackColor = Color.DarkGray;
        } 

        private void loadAccFromFile_Click(object sender, EventArgs e)
        {
            string path;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                groupList.Items.Clear();
                path = openFileDialog.FileName;
                LoadUsers.loadList(path);
            }
            if (LoadUsers.users.Count != 0)
            {
                loadAccs_lbl.Text = LoadUsers.users.Count.ToString();
           //     cleanUser_btn.Enabled = true;
           //     cleanUser_btn.BackColor = Color.DarkGray;
           //     loginTextBox.Enabled = false;
            //    passTextBox.Enabled = false;
            }
            else
            {
           //     cleanUser_btn.Enabled = false;
          //      cleanUser_btn.BackColor = Color.WhiteSmoke;
          //      loginTextBox.Enabled = true;
          //      passTextBox.Enabled = true;
                MessageBox.Show("В файле не найдено юзеров");
            }
        }

        private void cleanUser_btn_Click(object sender, EventArgs e)
        {
            LoadUsers.users.Clear();
            LoadUsers.userDictionary.Clear();
     //       cleanUser_btn.Enabled = false;
     //       cleanUser_btn.BackColor = Color.WhiteSmoke;
     //       loginTextBox.Enabled = true;
      //      passTextBox.Enabled = true;
            loadAccs_lbl.Text = "0";
            TotalCounter.Invalid = 0;
            TotalCounter.Valid = 0;
            validAccs_lbl.Text = "0";
            notValidAccs_lbl.Text = "0";
        }

        private void loadProxy_btn_Click(object sender, EventArgs e)
        {
            string path;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                proxyList.Items.Clear();
                path = openFileDialog.FileName;
                LoadList.loadProxyList(path);
            }

            for (int i = 0; i < LoadList.proxys.Count; i++)
            {
                proxyList.Items.Add(LoadList.proxys[i]);
            }

            if (LoadList.proxys.Count > 0)
            {
       //         cleanProxy_btn.Enabled = true;
       //         cleanProxy_btn.BackColor = Color.DarkGray;
            }
        }

        private void addProxy_btn_Click(object sender, EventArgs e)
        {
            string str;
            AddProxyForm APF = new AddProxyForm();
            APF.ShowDialog();

            if (APF.proxyLogin != "" && APF.proxyPass != "")
                str = APF.proxyIP+":"+APF.proxyPort+"/"+APF.proxyLogin+","+APF.proxyPass;
            else
                str = APF.proxyIP + ":" + APF.proxyPort;


            proxyList.Items.Add(str);
            LoadList.proxys.Add(str);

            if (proxyList.Items.Count > 0)
            {
         //       cleanProxy_btn.Enabled = true;
         //       cleanProxy_btn.BackColor = Color.DarkGray;
            }
        }

        private void cleanProxy_btn_Click(object sender, EventArgs e)
        {
            proxyList.Items.Clear();
       //     cleanProxy_btn.Enabled = false;
       //     cleanProxy_btn.BackColor = Color.WhiteSmoke;
        }
    }
}
