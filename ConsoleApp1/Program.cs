using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var db = new MasterEntities();
            var query = from b in db.tblUsers select b;
            foreach(var item in query)
            {
                Console.WriteLine(item.Name);
            }

            Console.ReadLine();
        }
    }
}
