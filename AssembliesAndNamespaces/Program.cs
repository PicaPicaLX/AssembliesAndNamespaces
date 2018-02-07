using System; // 这句话表示现在使用到了System命名空间中的类
using System.Collections.Generic;// 这行比上行淡化表示目前还没使用到System.Collections.Generic命名空间中的类，下同
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace AssembliesAndNamespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //string text = "We want to write this to our file.";
            //File.WriteAllText(@"C:\Users\lx389\Documents\WriteText.txt", text);


            WebClient client = new WebClient(); // DownloadString()是一个下载网页的方法，位于System.Net命名空间的WebClient类中
            string reply = client.DownloadString("http://msdn.microsoft.com");
            Console.WriteLine(reply);


            System.Console.WriteLine("Hello World!");
            File.WriteAllText(@"C:\Users\lx389\Documents\reply.txt", reply);
            Console.ReadLine();
        }
        /*Console类其实属于System命名空间，但是并没有使用System.Console是因为
         * 文件开头已经用using System;来表示使用命名空间了,因此可以省略命名空间
         * 若类的名称发生冲突,只需补类的全称，比如System.Console.WriteLine();
         */

    }
}
