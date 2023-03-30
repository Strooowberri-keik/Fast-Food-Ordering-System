using System;
using System.Collections.Generic;
using System.Text;

namespace MCDOLIBEE_FASTFOOD_FINAL_PROJECT
{
    class MenuListandPrice
    {
        public void myMenulist()
        {
            int order = 0;
            int numDeals = 0;
            int numAttempts = 0;

            Payment p = new Payment();
            buyMore yesno = new buyMore();
            MenuListandPrice naaw = new MenuListandPrice();

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("                                     WELCOME TO MCDOLIBEE                                  ");
            Console.WriteLine("-------------------------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                                          MENU                                             ");
            Console.WriteLine("(1)      MCBee Cheeseburger                                                           90php");
            Console.WriteLine("(2)      Potato Wedges Cut                                                            75php");
            Console.WriteLine("(3)      MCBee French Fries (Small)                                                   45php");
            Console.WriteLine("(4)      MCBee French Fries (Medium)                                                  90php");
            Console.WriteLine("(5)      MCBee French Fries (Large)                                                  105php");
            Console.WriteLine("(6)      2pcs Crispy Fried Chicken with Rice                                         145php");
            Console.WriteLine("(7)      Spaghetti Family Pan                                                        350php");
            Console.WriteLine("(8)      Burger Steak Family Pan                                                     375php");
            Console.WriteLine("(9)      2pc McBee Muffins                                                            50php");
            Console.WriteLine("(10)     Dolly Hotdog                                                                 35php");
            Console.WriteLine("(11)     MCBee Pancakes with Maple Syrup                                              50php");
            Console.WriteLine("(12)     MCBee Onion Rings                                                            35php");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                                     DRINKS & DESSERT                                      ");
            Console.WriteLine("-------------------------------------------------------------------------------------------");
            Console.WriteLine("(13)     MCBee Coke Float                                                             35php");
            Console.WriteLine("(14)     Sprite                                                                       25php");
            Console.WriteLine("(15)     Orange Juice with lime zest                                                  35php");
            Console.WriteLine("(16)     Bottled Water                                                                15php");
            Console.WriteLine("(17)     Halo-Halo                                                                    55php");
            Console.WriteLine("(18)     Ice Cream                                                                    25php");
            Console.WriteLine("(19)     MCBee Milktea 12 oz                                                          25php");
            Console.WriteLine("(20)     MCBee Milktea 17 oz                                                          45php");
            Console.WriteLine("(21)     MCBee Milktea 21 oz                                                          55php");
            Console.WriteLine();
            Console.WriteLine();
            do
            {
                try
                {
                    Console.WriteLine("Please choose the food/drink/dessert number: ");
                    order = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("Please enter the number of deals: ");
                    numDeals = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                switch (order)
                {
                    case 1:
                        Console.WriteLine("MCBee Cheeseburger");
                        Console.WriteLine("Quantity: " + numDeals);
                        Console.WriteLine("Price: 90php");
                        Console.WriteLine("Total Price: " + 90 * numDeals);
                        break;
                    case 2:
                        Console.WriteLine("Potato Wedges Cut");
                        Console.WriteLine("Quantity: " + numDeals);
                        Console.WriteLine("Price: 75php");
                        Console.WriteLine("Total Price: " + 75 * numDeals);
                        break;
                    case 3:
                        Console.WriteLine("MCBee French Fries (Small)");
                        Console.WriteLine("Quantity: " + numDeals);
                        Console.WriteLine("Price: 45php");
                        Console.WriteLine("Total Price: " + 45 * numDeals);
                        break;
                    case 4:
                        Console.WriteLine("MCBee French Fries (Medium)");
                        Console.WriteLine("Quantity: " + numDeals);
                        Console.WriteLine("Price: 90php");
                        Console.WriteLine("Total Price: " + 90 * numDeals);
                        break;
                    case 5:
                        Console.WriteLine("MCBee French Fries (Large)");
                        Console.WriteLine("Quantity: " + numDeals);
                        Console.WriteLine("Price: 105php");
                        Console.WriteLine("Total Price: " + 105 * numDeals);
                        break;
                    case 6:
                        Console.WriteLine("2pcs Crispy Fried Chicken with Rice");
                        Console.WriteLine("Quantity: " + numDeals);
                        Console.WriteLine("Price: 145php");
                        Console.WriteLine("Total Price: " + 145 * numDeals);
                        break;
                    case 7:
                        Console.WriteLine("Spaghetti Family Pan");
                        Console.WriteLine("Quantity: " + numDeals);
                        Console.WriteLine("Price: 350php");
                        Console.WriteLine("Total Price: " + 350 * numDeals);
                        break;
                    case 8:
                        Console.WriteLine("Burger Steak Family Pan");
                        Console.WriteLine("Quantity: " + numDeals);
                        Console.WriteLine("Price: 375php");
                        Console.WriteLine("Total Price: " + 375 * numDeals);
                        break;
                    case 9:
                        Console.WriteLine("2pc McBee Muffins");
                        Console.WriteLine("Quantity: " + numDeals);
                        Console.WriteLine("Price: 50php");
                        Console.WriteLine("Total Price: " + 50 * numDeals);
                        break;
                    case 10:
                        Console.WriteLine("Dolly Hotdog");
                        Console.WriteLine("Quantity: " + numDeals);
                        Console.WriteLine("Price: 35php");
                        Console.WriteLine("Total Price: " + 45 * numDeals);
                        break;
                    case 11:
                        Console.WriteLine("MCBee Pancakes with Maple Syrup");
                        Console.WriteLine("Quantity: " + numDeals);
                        Console.WriteLine("Price: 50php");
                        Console.WriteLine("Total Price: " + 50 * numDeals);
                        break;
                    case 12:
                        Console.WriteLine("MCBee Onion Rings");
                        Console.WriteLine("Quantity: " + numDeals);
                        Console.WriteLine("Price: 35php");
                        Console.WriteLine("Total Price: " + 35 * numDeals);
                        break;
                    case 13:
                        Console.WriteLine("MCBee Coke Float");
                        Console.WriteLine("Quantity: " + numDeals);
                        Console.WriteLine("Price: 35php");
                        Console.WriteLine("Total Price: " + 35 * numDeals);
                        break;
                    case 14:
                        Console.WriteLine("Sprite");
                        Console.WriteLine("Quantity: " + numDeals);
                        Console.WriteLine("Price: 25php");
                        Console.WriteLine("Total Price: " + 25 * numDeals);
                        break;
                    case 15:
                        Console.WriteLine("Orange Juice with lime zest");
                        Console.WriteLine("Quantity: " + numDeals);
                        Console.WriteLine("Price: 35php");
                        Console.WriteLine("Total Price: " + 35 * numDeals);
                        break;
                    case 16:
                        Console.WriteLine("Bottled Water");
                        Console.WriteLine("Quantity: " + numDeals);
                        Console.WriteLine("Price: 15php");
                        Console.WriteLine("Total Price: " + 15 * numDeals);
                        break;
                    case 17:
                        Console.WriteLine("Halo-Halo");
                        Console.WriteLine("Quantity: " + numDeals);
                        Console.WriteLine("Price: 55php");
                        Console.WriteLine("Total Price: " + 55 * numDeals);
                        break;
                    case 18:
                        Console.WriteLine("Ice Cream");
                        Console.WriteLine("Quantity: " + numDeals);
                        Console.WriteLine("Price: 25php");
                        Console.WriteLine("Total Price: " + 25 * numDeals);
                        break;
                    case 19:
                        Console.WriteLine("MCBee Milktea 12 oz");
                        Console.WriteLine("Quantity: " + numDeals);
                        Console.WriteLine("Price: 25php");
                        Console.WriteLine("Total Price: " + 25 * numDeals);
                        break;
                    case 20:
                        Console.WriteLine("MCBee Milktea 17 oz");
                        Console.WriteLine("Quantity: " + numDeals);
                        Console.WriteLine("Price: 45php");
                        Console.WriteLine("Total Price: " + 45 * numDeals);
                        break;
                    case 21:
                        Console.WriteLine("MCBee Milktea 21 oz");
                        Console.WriteLine("Quantity: " + numDeals);
                        Console.WriteLine("Price: 55php");
                        Console.WriteLine("Total Price: " + 55 * numDeals);
                        break;
                }
                numAttempts++;
            } while (order != 15 && numAttempts < 3);
            Console.WriteLine();
            p.MagbabayadNaAko();
            Console.WriteLine("Do you want to buy again? Enter YES/yes to order —————— Enter NO/no to exit");
            Console.WriteLine();
            yesno.pabili();
            Console.WriteLine();
            naaw.myMenulist();

        }
    }
}
