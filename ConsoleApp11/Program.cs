using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            PricingRules pricingRules = new PricingRules();
            UnidaysDiscountChallenge example = new UnidaysDiscountChallenge(pricingRules);

            // creating items from Item class, I've created them in a logical way so that you can comment out items being added in order
            Item item1 = new Item("Soap", 4);
            Item item2 = new Item("Cereal", 4);
            Item item3 = new Item("Bar", 4);
            Item item4 = new Item("Potatoes", 5);
            Item item5 = new Item("Frying Pan", 5);
            Item item6 = new Item("Cake", 5);
            Item item7 = new Item("Jar of Jam", 7);
            Item item8 = new Item("Pasta", 7);
            Item item9 = new Item("Video game", 12);
            Item item10 = new Item("CD", 12);
            Item item11 = new Item("Phone charger", 8);

            // adding items using the AddToBasket method
            example.AddToBasket(item1);
            example.AddToBasket(item2);
            example.AddToBasket(item3);
            example.AddToBasket(item4);
            example.AddToBasket(item5);
            example.AddToBasket(item6);
            example.AddToBasket(item7);
            example.AddToBasket(item8);
            example.AddToBasket(item9);
            example.AddToBasket(item10);
            example.AddToBasket(item11);

            // get the overall total as a return of the CalculateTotalPrice method
            double overalTotal = example.CalculateTotalPrice();
            // get the total price from the pricingRules class
            double totalPrice = pricingRules.total;
            // get the delivery charge from the pricing rules class
            double deliveryCharge = pricingRules.deliveryCharge;

            //print out the results
            Console.WriteLine($"total price = {totalPrice}\t|\tdelivery charge = {deliveryCharge}\t|\toverall total = {overalTotal}");
            
            // if application is started with debugging it will stop it from closing
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
