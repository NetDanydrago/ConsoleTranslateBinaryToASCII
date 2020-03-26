using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTranslate
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string line;

            // Read the file and display it line by line.  
            List<Byte> ByteD = new List<byte>();
            System.IO.StreamReader file =
                new System.IO.StreamReader(@"c:\pp\HelloTextbin.txt");
            while ((line = file.ReadLine()) != null)
            {
                var Split = line.Split(" ");
                for(int i = 0; i < 8; i++)
                {
                    int INT = Convert.ToInt32(Split[i].ToString(),2);
                    Byte Binary = Convert.ToByte(INT);
                    ByteD.Add(Binary);
                }
            }
            string P = Encoding.ASCII.GetString(ByteD.ToArray());
            var a = Encoding.ASCII.GetBytes("Hello World");
            var c = Convert.ToString(a[8], 2);
            /*              System.Console.WriteLine(line);*/
            
            System.Console.WriteLine();
            counter++;
            ByteD.Clear();

            file.Close();
            System.Console.WriteLine("There were {0} lines.", counter);
            // Suspend the screen.  
            System.Console.ReadLine();

            //var value = Convert.ToInt32("01011010", 2);
            //byte[] ByteArray;
            //List<Byte> Byte = new List<byte>()
            //{
            //    Convert.ToByte(value), Convert.ToByte(value), Convert.ToByte(value), Convert.ToByte(value), Convert.ToByte(value), Convert.ToByte(value), Convert.ToByte(value), Convert.ToByte(value), Convert.ToByte(value), Convert.ToByte(value), Convert.ToByte(value)
            //};
            //string s = Encoding.ASCII.GetString(Byte.ToArray() );
            //Console.WriteLine(s);
            //Console.WriteLine($"Hello World! {value}");
            //Console.ReadLine();
        }
    }
}
