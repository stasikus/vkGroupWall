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
    public partial class InputCaptchaForm : Form
    {
        public Net netp;
        string result = "";
        bool clicked = false;
        public InputCaptchaForm(ref string refstring)
        {
            InitializeComponent();
            this.sidPic(refstring);
        }
        

        public void captcha_input_btn_Click(object sender, EventArgs e)
        {
            netp.captchaFromForm = captcha_input_TB.Text;
           // result = captcha_input_TB.Text;
            //clicked = true;
            this.Close();
        }

        public void sidPic(string sid)
        {
            string captchaNum = "";
            var request = WebRequest.Create("http://vk.com/captcha.php?sid=" + sid + "&s=1");

            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                captcha_input_pic.Image = Bitmap.FromStream(stream);
            }
            captchaNum = captcha_input_TB.Text;
        }

        private string InputCaptchaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            return "2";
        }             
    }
}
