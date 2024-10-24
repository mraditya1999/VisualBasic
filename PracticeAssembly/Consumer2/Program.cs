using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consumer2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Consumer 2");
            CA ca = new CA();
            ca.Show();
        }
    }
}
