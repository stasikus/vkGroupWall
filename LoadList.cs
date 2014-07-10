using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vkGroupWall
{
    class LoadList
    {
        public static List<string> groups = new List<string>();

        public static void loadList(string path)
        {
            groups = new List<string>();
            using (var sr = new StreamReader(path))
            {
                while (sr.Peek() >= 0)
                {
                    groups.Add(sr.ReadLine());
                    if (groups.Contains(""))
                    {
                        groups = groups.Where(s => !string.IsNullOrWhiteSpace(s)).Distinct().ToList();
                    }
                }
            }
        }
    }
}
