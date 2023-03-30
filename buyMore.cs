using System;
using System.Collections.Generic;
using System.Text;

namespace MCDOLIBEE_FASTFOOD_FINAL_PROJECT
{
    class buyMore
    {
        public void pabili()
        {
            string choice = "";

            choice = Convert.ToString(Console.ReadLine());

            if (string.Equals(choice, "YES", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine();
            }
            if (string.Equals(choice, "NO", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Thank You and Come Again!");
                Environment.Exit(0);
            }
        }
    }
}
