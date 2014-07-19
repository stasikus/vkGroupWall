using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vkGroupWall
{
    class TotalMessages
    {
        public static int SuccessNum;
        public static int FailNum;

        public static int SuccessMessages()
        {
            SuccessNum++;
            return SuccessNum;
        }

        public static int FailMessages()
        {
            FailNum++;
            return FailNum;
        }
    }
}
