using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Movie_Methods_and_Variables
    {
        #region Costs
        public double totalCost;
        public static double taxRate = 0.08;
        public int noOfTix = 0;
        public int childTix = 0;
        public int adultTix = 0;
        //Matinee Prices
        public static double ticketChildMat = 3.99;
        public static double ticketAdultMat = 5.99;
        public static double ticketSeniorMat = 4.50;
        //Evening Prices
        public static double ticketChildEve = 6.99;
        public static double ticketAdultEve = 10.99;
        public static double ticketSeniorEve = 8.50;
        //Concession Stand
        public static double smallSoda = 3.50;
        public static double largeSoda = 5.99;
        public static double hotDog = 3.99;
        public static double popcorn = 4.50;
        public static double candy = 1.99;
        #endregion

        #region Movie Methods
        public void TicketQty()
        {
            
            int qty = 0;
            bool valid = false;
            while (valid == false)
            {
                System.Console.WriteLine("How many tickets would you like to purchase?");
                System.Console.WriteLine("1");
                System.Console.WriteLine("2");
                System.Console.WriteLine("3");
                System.Console.WriteLine("4");
                System.Console.WriteLine("...");

                try
                {
                    qty = int.Parse(System.Console.ReadLine());
                    if (qty<=1 || qty>=4)
                    {
                        valid = true;
                        qty = noOfTix;
                        break;
                    }
                   else
                    {
                        valid = false;
                        continue;
                    }
                }
                catch (System.FormatException qtyError)
                {
                    System.Console.WriteLine(qtyError.Message);
                    System.Console.WriteLine("Please enter a valid quantity...");
                    valid = false;
                    continue;
                }
            }
        }

        public void TicketType()
        {
            if(noOfTix == 1)
            {
                System.Console.WriteLine("Will that be 1 child or one adult?");
                Console.WriteLine();
            } 
            else
            {
                int qtySplitSelection = 0;
                bool qtySplitValid = false;
                while (qtySplitValid == false)
                {

                    System.Console.WriteLine("Will that be " + noOfTix + "Adult tickets or " + noOfTix + "Child tickets or both?");
                    System.Console.WriteLine("1) " + noOfTix + "Adult Tickets");
                    System.Console.WriteLine("2) " + noOfTix + "Child Tickets");
                    System.Console.WriteLine("3) Both Adult and Childrens Tickets");
                    
                    try
                    {
                        qtySplitSelection= int.Parse(System.Console.ReadLine());
                        if (qtySplitSelection != 1 || qtySplitSelection != 2 || qtySplitSelection != 3)
                        {
                            System.Console.WriteLine("Please make a valid selection.");
                            qtySplitValid = false;
                            continue;
                        }
                        else
                        {
                            if(qtySplitSelection == 1)
                            {
                                adultTix = noOfTix;
                                qtySplitValid = true;
                                break;                                
                            }
                            if (qtySplitSelection == 2)
                            {
                                childTix = noOfTix;
                                qtySplitValid = true;
                                break;
                            }
                            if (qtySplitSelection == 3)
                            {
                                ///////////////////
                                //////////////////
                                /////////////////
                                ///////////
                                /////////////
                                ////////////
                                ///////////
                                //////
                                ////////
                                ///////
                                //////
                                ///
                                //
                                adultTix = noOfTix;
                                break;
                            }
                        }
                    }
                    catch (Exception)
                    {
                        System.Console.WriteLine("Please make a valid selection.");
                        qtySplitValid = false;
                        continue;
                    }
                }

            }
            
        }
        #endregion

        #region Movies

        #endregion

        #region Print Box
        #endregion
    }
}
