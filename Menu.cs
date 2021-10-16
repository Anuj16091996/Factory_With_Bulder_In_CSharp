using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavtoryWithBuilder
{
    public static class Menu
    {
        public static string NoteOrder()
        {
            string Type_Order = "";

            bool statuss = true;
            while (statuss)
            {
                try
                {
                    Console.WriteLine("Please Select What you will like to have-: ");
                    Console.WriteLine("Press 1 For Pizza");
                    Console.WriteLine("Press 2 for Sandwhich");
                    statuss = false;
                    int value;
                    value = int.Parse(Console.ReadLine());
                    bool status = true;
                    while (status)
                    {
                        if (value == 1)
                        {
                            Type_Order = "Pizza";
                            status = false;
                        }
                        else if (value == 2)
                        {
                            Type_Order = "Sandwhich";
                            status = false;

                        }
                        else
                        {
                            Console.WriteLine("Invalid Input");
                            Console.WriteLine("Try Again");
                            status = true;
                            value = int.Parse(Console.ReadLine());
                        }
                    }

                }
                catch (Exception )
                {
                    Console.WriteLine("Exception caught.");
                    Console.WriteLine("Try Again");
                    statuss = true;
                }
            }




            return Type_Order;
        }
        public static string GetTypeFromClient(string Type)
        {
            string Type_Order = "";

            if (Type == "Pizza")
            {
                bool statuss = true;
                while (statuss)
                {
                    try
                    {
                        Console.WriteLine("Which Pizza Would you like to Have-: ");
                        Console.WriteLine("Press 1 For Hawain Pizza");
                        Console.WriteLine("Press 2 for Meat Pizza");
                        Console.WriteLine("Press 3 for Veg Pizza");

                        statuss = false;
                        int value;
                        value = int.Parse(Console.ReadLine());
                        bool status = true;
                        while (status)
                        {
                            if (value == 1)
                            {
                                Type_Order = "Hawain";
                                status = false;
                            }
                            else if (value == 2)
                            {
                                Type_Order = "Meat";
                                status = false;

                            }

                            else if (value==3)
                            {
                                Type_Order = "Veggy";
                                status = false;
                            }
                            else
                            {
                                Console.WriteLine("Invalid Input");
                                Console.WriteLine("Try Again");
                                status = true;
                                value = int.Parse(Console.ReadLine());
                            }
                        }

                    }
                    catch (Exception )
                    {
                        Console.WriteLine("Exception caught.");
                        Console.WriteLine("Try Again");
                        statuss = true;
                    }
                }
            }

            else
            {
                bool statuss = true;
                while (statuss)
                {
                    try
                    {
                        Console.WriteLine("Which Sandwhich Would you like to Have-: ");
                        Console.WriteLine("Press 1 For Veggy Burger");
                        Console.WriteLine("Press 2 for Health Burger");
                        Console.WriteLine("Press 3 for Chicken Burger");
                        Console.WriteLine("Press 4 for Ham Burger");


                        statuss = false;
                        int value;
                        value = int.Parse(Console.ReadLine());
                        bool status = true;
                        while (status)
                        {
                            if (value == 1)
                            {
                                Type_Order = "Veggy";
                                status = false;
                            }
                            else if (value == 2)
                            {
                                Type_Order = "Health";
                                status = false;

                            }

                            else if (value == 3)
                            {
                                Type_Order = "Chicken";
                                status = false;
                            }
                            else if (value == 4)
                            {
                                Type_Order = "Ham";
                                status = false;
                            }
                            else
                            {
                                Console.WriteLine("Invalid Input");
                                Console.WriteLine("Try Again");
                                status = true;
                                value = int.Parse(Console.ReadLine());
                            }
                        }

                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Exception caught.");
                        Console.WriteLine("Try Again");
                        statuss = true;
                    }
                }
            }

            return Type_Order;
        }

       
        public static int MorOder()
        {
            int more=0;

            bool statuss = true;
            while (statuss)
            {
                try
                {
                   
                    Console.WriteLine("DO You Want To Order More\n Press 1 For Yes\n Press 2 for No");


                    statuss = false;
                    int value;
                    value = int.Parse(Console.ReadLine());
                    bool status = true;
                    while (status)
                    {
                        if (value == 1)
                        {
                            more = 1;
                            status = false;
                        }
                        else if (value == 2)
                        {
                            more = 2;
                            status = false;

                        }

                        
                        else
                        {
                            Console.WriteLine("Invalid Input");
                            Console.WriteLine("Try Again");
                            status = true;
                            value = int.Parse(Console.ReadLine());
                        }
                    }

                }
                catch (Exception )
                {
                    Console.WriteLine("Exception caught.");
                    Console.WriteLine("Try Again");
                    statuss = true;
                }
            }


            return more;
        }


    }



    
    

}
