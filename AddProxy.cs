using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vkGroupWall
{
    public partial class AddProxyForm : Form
    {
        public AddProxyForm()
        {
            InitializeComponent();
        }

        public string proxyIP = "";
        public string proxyPort = "";
        public string proxyLogin = "";
        public string proxyPass = "";

        private void addProxy_btn_Click(object sender, EventArgs e)
        {
            if (proxyIP_TB.Text != "" && proxyPort_TB.Text != "")
            {
                proxyIP = proxyIP_TB.Text;
                proxyPort = proxyPort_TB.Text;
                proxyLogin = proxyLogin_TB.Text;
                proxyPass = proxyPass_TB.Text;
                this.Close();
            }
            else
            {
                MessageBox.Show("IP или Port не может быть пустым");
            }
        }
    }
}
