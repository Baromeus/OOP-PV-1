using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PV {
    internal class Raum {
        int wert = 0;
        public Raum(int w) {
            this.wert = w;
        }
        public int getBelegung() {
            return wert;
        }
    }

    internal class Mitarbeiter {
        double wert = 0.0;
        public Mitarbeiter(double w) {
            this.wert = w;
        }
        public double getGehalt() {
            return wert;
        }
    }

    internal class PV_Algo1 {
        public static void run() {
            Raum[] raums = { new Raum(5), new Raum(3), new Raum(2), new Raum(1), new Raum(6), new Raum(4), new Raum(7) };
            Mitarbeiter[] mits = { new Mitarbeiter(152.25), new Mitarbeiter(122.50), new Mitarbeiter(255), new Mitarbeiter(50) };
            sort(raums, mits);
        }

        public static void sort(Raum[] raumArray, Mitarbeiter[] mitarbeiterArray) {
            List<Raum> list = raumArray.ToList();
            List<Mitarbeiter> list2 = mitarbeiterArray.ToList();

            foreach(Raum raum in list) {
                Console.WriteLine(raum.getBelegung());
            }

            genericTest<Raum>(list, vergleich);

            Console.WriteLine("----");
            foreach(Raum raum in list) {
                Console.WriteLine(raum.getBelegung());
            }

            Console.WriteLine("----");
            Console.WriteLine("----");

            foreach(Mitarbeiter mitarbeiter in list2) { 
                Console.WriteLine(mitarbeiter.getGehalt());
            }

            genericTest<Mitarbeiter>(list2, vergleich);

            Console.WriteLine("----");

            foreach(Mitarbeiter mitarbeiter in list2) {
                Console.WriteLine(mitarbeiter.getGehalt());
            }
        }

        public static int vergleich(Raum r1, Raum r2) {
            if(r1.getBelegung() > r2.getBelegung()) {
                return 1;
            }
            if(r1.getBelegung() < r2.getBelegung()) {
                return -1;
            }
            return 0;
        }

        public static int vergleich(Mitarbeiter m1, Mitarbeiter m2) {
            if(m1.getGehalt() > m2.getGehalt()) {
                return 1;
            }
            if(m1.getGehalt() < m2.getGehalt()) {
                return -1;
            }
            return 0;
        }

        public static void genericTest<T>(List<T> liste, Func<T,T,int> f) {
            bool getauscht;

            do {
                getauscht = false;
                for(int i = 0; i < liste.Count() - 1; i++) {
                    if(f(liste[i], liste[i + 1]) > 0) {
                        T temp = liste[i];
                        liste[i] = liste[i + 1];
                        liste[i + 1] = temp;
                        getauscht = true;
                    }
                }
            } while(getauscht);
        }
    }
}
