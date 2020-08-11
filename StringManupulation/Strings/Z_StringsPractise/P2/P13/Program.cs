using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "http://www.cnn.com/video";
            int protocolEndIndex = str.IndexOf("://");
            string protocol = str.Substring(0, protocolEndIndex + 1-1);
            int serverEndIndex = str.IndexOf("/",protocolEndIndex+4);
            string server = str.Substring(protocolEndIndex + 3, serverEndIndex + 1 - protocolEndIndex - 3 - 1);
            string resource = str.Substring(serverEndIndex);
            Console.WriteLine("[protocol]=\""+protocol+"\"\n[server]=\""+server+"\"\n"+"[resource]=\""+resource+"\"");
            Console.ReadKey();
        }
    }
}
