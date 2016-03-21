using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustDo.Utility
{
    public  class Tool
    {
        //获取根地址
        public static string GetBaseDirPath()
        {
            return System.Environment.CurrentDirectory;
        }

        //获取资源地址
        public static string GetResoucePath(string path)
        {
            return string.Concat(GetBaseDirPath(),path);
        }
    }
}
