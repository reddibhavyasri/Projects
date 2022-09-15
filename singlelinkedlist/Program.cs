using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace singlelinkedlist
{
    public  class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }

        public static void runApp()
        {
            singlelinkedlistdata list = new singlelinkedlistdata();
            node n = new node();
            n.Data = "root";
            list.add(n);
            for (int i = 0; i < 10; i++)
            {
                node node = new node();
                node.Data = Convert.ToString(i);
                list.add(node);
            }

            Console.WriteLine("length of singly linked list=" + list.getLengthOfList());

            n = list.getRoot();
            while (n != null)
            {
                Console.WriteLine(n.Data);
                n = list.getNext();
            }
            Console.ReadLine();
        }

    }

}
