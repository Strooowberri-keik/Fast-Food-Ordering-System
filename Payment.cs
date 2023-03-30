using System;
using System.Collections.Generic;
using System.Text;

namespace MCDOLIBEE_FASTFOOD_FINAL_PROJECT
{
    class Payment
    {
        public void MagbabayadNaAko()
        {
            long bayad = 10000;
            Payment h = new Payment();

            try
            {
                Console.WriteLine("Enter the exact amount: ");
                bayad = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception w)
            {
                Console.WriteLine(w.Message);
                Console.WriteLine("Invalid Input!");
                Console.WriteLine();
                h.MagbabayadNaAko();
            }
            if (bayad <= 500)
            {
                Console.WriteLine("You cannot proceed with insufficient amount");
                Console.WriteLine();
                h.MagbabayadNaAko();
            }
            else if (bayad >= 500)
            {
                Console.WriteLine("Here is your Order");
                Console.WriteLine();
            }
                
        }
    }
}
