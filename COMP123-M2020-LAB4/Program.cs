using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_M2020_LAB4
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate object of type Person
            Person hussam = new Person("Hussam",38);

            //use SaysHello method with . accessor
            hussam.SaysHello();


            Console.ReadLine();
        }
    }
}
