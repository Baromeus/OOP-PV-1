using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PV {
    internal class Emuster {
        public static void run() {
            List<ICalc> array = new List<ICalc>();
            array.Add(new Addition());
            array.Add(new Subtraction());

            int n1 = 10;
            int n2 = 5;

            foreach(ICalc c in array) {
                Console.WriteLine(n1 + " " + n2 + " -> " + c.calculate(n1,n2) );
            }

        }
    }
}
