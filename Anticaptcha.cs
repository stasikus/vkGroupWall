using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vkGroupWall
{
    class Anticaptcha
    {
        static string PuthToPicture;

        public static string captchaPic(string sid)
        {
            PuthToPicture = Antigate.Download_Captcha("http://vk.com/captcha.php?sid=" + sid + "");
            if (PuthToPicture != "")
            {
                Antigate.Key = "2ce2be021b8bd05b8c210af8aaeeb3d1";
                string stringCaptcha = Antigate.Recognize(PuthToPicture);
                //MessageBox.Show("Captcha num = " +stringCaptcha);
                return stringCaptcha;
            }
            return null;
        }

        public static string Balance(string key)
        {
            string balance = "";
            balance = Antigate.Balance(key);
            return balance;
        }
    }
}
