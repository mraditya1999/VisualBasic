using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consumer1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Consumer 1");
            CA ca = new CA();
            ca.Show();

        }
    }
}
