using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Utils
    {
        public static string GetFileSize(double byteCount)
        {
            double GB_SIZE = 1073741824.0;
            double MB_SIZE = 1048576.0;
            double KB_SIZE = 1024.0;
            string size = "0B";

            if (byteCount >= GB_SIZE)
            {
                size = String.Format("{0:##.##}", byteCount / GB_SIZE) + "GB";
            }
            else if (byteCount >= MB_SIZE)
            {
                size = String.Format("{0:##.##}", byteCount / MB_SIZE) + "MB";
            }
            else if (byteCount >= KB_SIZE)
            {
                size = String.Format("{0:##.##}", byteCount / KB_SIZE) + "KB";
            }
            else if (byteCount > 0 && byteCount < KB_SIZE)
            {
                size = byteCount.ToString() + "B";
            }
            return size;
        }
    }
}
