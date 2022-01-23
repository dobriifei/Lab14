using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    class Program
    {
        static void Main(string[] args)
        {
             {
                Dog dog = new Dog ("Шарик");
                dog.ShowInfo();
                Cat cat = new Cat("Маруся");
                cat.ShowInfo();
                Console.ReadKey();
             }
        }
    }
}
