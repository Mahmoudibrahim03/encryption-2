using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = "0";
            for (int i = 0; i < key.Length; i++)
            {
                while (key.Length != 10 && key.Contains(key[i]))
                {
                        Console.Out.WriteLine("Enter a key ");
                        Console.Out.WriteLine("The key have to be 10 numbers and not deblicated");
                        key = Console.In.ReadLine(); //["123"]
                }
            }
            Console.Out.WriteLine("Enter your data ");
            string data = Console.In.ReadLine();
            string enc = "";
            //Console.Out.WriteLine(enc[0]);

            for (int j=0; j < data.Length; j++)
            {
                int index = data[j];
                //Console.Out.Write((char)index);
                string x = (char)index;
                int y = (int)x;
                Console.Out.Write(int.Parse(x));

                //enc += key[(char)index];
            }
            Console.Out.WriteLine(enc);



        }
    }
}
