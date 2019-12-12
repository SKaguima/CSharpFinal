using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
    {
    class Program
    { 
        public static void Main()
        {
            double weightInKilos = 80;
            double weightInPounds = Conversions.KilosToPounds(weightInKilos);
        }
        public static class Conversions
        {
            public static double PoundsToKilos(double pounds)
            {
                // Convert argument from pounds to kilograms
                double kilos = pounds * 0.4536;
                return kilos;
            }
            public static double KilosToPounds(double kilos)
            {
                // Convert argument from kilograms to pounds
                double pounds = kilos * 2.205;
                return pounds;
            }

        }
    }
}
