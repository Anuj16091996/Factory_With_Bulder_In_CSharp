using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
    using System.Threading.Tasks;

namespace FavtoryWithBuilder
{ 
  public  class ReduceCodeOfMain
    {
        public static void StartOrder()
        {
            double finalbill=0;
        ArrayList Invoice = new ArrayList();
            

            bool status = true;
            while (status)
            {
                string Order = Menu.NoteOrder();
                string Type = Menu.GetTypeFromClient(Order);
                if (Type == "Veggy" || Type == "Health")
                {
                    AbstractFactory factory = AbstractFactory.GetFactory(Client.Veggy);
                    if (Order == "Pizza")
                    {
                        Pizza pizza = factory.CreatePizza();
                        finalbill = finalbill + pizza.price;
                        Invoice.Add(pizza);
                        int More_order = Menu.MorOder();
                        if(More_order==1)
                        {
                            status = true;
                        }
                        else
                        {
                            status = false;
                        }
                        
                       
                    }

                    else
                    {
                        Sandwhich sandwhich = factory.CreateSandwhich(Type);
                        finalbill = finalbill + sandwhich.price;
                        Invoice.Add(sandwhich);
                        int More_order = Menu.MorOder();
                        if (More_order == 1)
                        {
                            status = true;
                        }
                        else
                        {
                            status = false;
                        }
                    }

                }

                else if (Type == "Chicken" || Type == "Meat")
                {
                    AbstractFactory factory = AbstractFactory.GetFactory(Client.Meat);
                    if (Order == "Pizza")
                    {
                        Pizza pizza = factory.CreatePizza();
                        finalbill = finalbill + pizza.price;
                        Invoice.Add(pizza);
                        int More_order = Menu.MorOder();
                        if (More_order == 1)
                        {
                            status = true;
                        }
                        else
                        {
                            status = false;
                        }
                    }

                    else
                    {
                        Sandwhich sandwhich = factory.CreateSandwhich(Type);
                        finalbill = finalbill + sandwhich.price;
                        Invoice.Add(sandwhich);
                        int More_order = Menu.MorOder();
                        if (More_order == 1)
                        {
                            status = true;
                        }
                        else
                        {
                            status = false;
                        }
                    }
                }
                else
                {
                    AbstractFactory factory = AbstractFactory.GetFactory(Client.Meat);
                    if (Order == "Pizza")
                    {
                        Pizza pizza = factory.CreatePizza();
                        finalbill = finalbill + pizza.price;
                        Invoice.Add(pizza);
                        int More_order = Menu.MorOder();
                        if (More_order == 1)
                        {
                            status = true;
                        }
                        else
                        {
                            status = false;
                        }
                    }

                    else
                    {
                        Sandwhich sandwhich = factory.CreateSandwhich(Type);
                        finalbill = finalbill + sandwhich.price;
                        Invoice.Add(sandwhich);
                        int More_order = Menu.MorOder();
                        if (More_order == 1)
                        {
                            status = true;
                        }
                        else
                        {
                            status = false;
                        }
                    }
                }

            }

            for (int i=0;i<Invoice.Count;i++)
            {
                Console.WriteLine(Invoice[i].ToString()) ;
            }

            Console.WriteLine("Final Bill is {0}",finalbill);



        }
    }
}
