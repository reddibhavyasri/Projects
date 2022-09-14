using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StudentDataFromText
{
    public class Program
    {

        static void Main(string[] args)
        {
            string path = "E:\\Practice asnmnts\\StudentData.txt";
            string text = File.ReadAllText(path);
            Console.WriteLine(text);
            Console.ReadKey();
        }

    }
}
