using System;
using System.ComponentModel;

namespace Polymorphism__casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();
            Drink drink = new Drink();
            drink.Name = "Tequila";
            drink.Price = 50;

                try
                {
                    drink.AlcoholPercent = 120;
                }
                catch (AlcoPercentException ex)
                {

                    Console.WriteLine(ex.Message);
                }
   
           

            drink.ShowProducts();

            Dairy dairy = new Dairy();
            dairy.Name = "Milla";
            dairy._fatPercent = 80;
            dairy.Price= 1.5;
            dairy.ShowProducts();
            Product pr = new Product();
            pr.Name = "Azer cay";
            pr.Price = 5;
            pr.ShowProducts();
            store.Add(pr);
            

          
        }
    }
}

