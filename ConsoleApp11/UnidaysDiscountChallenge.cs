using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class UnidaysDiscountChallenge
    {
        // list for each Item that is added which can be iterated later with IEnumerator
        List<Item> cart = new List<Item>();
        // global variable for the PricingRules which can be assigned when in the constructor
        PricingRules p;

        public UnidaysDiscountChallenge(PricingRules pricingRules)
        {
            p = pricingRules;
        }
        public void AddToBasket(Item item)
        {
            cart.Add(item);
        }

        public double CalculateTotalPrice()
        {

            //calculate total cost without discounts
            foreach (var cartItem in cart)
            {
                double priceOfItem = cartItem.Price;
                p.total += priceOfItem;
                
                p.applyPricingRules(priceOfItem);
            }

            // apply discounts
            if(p.count12 / 2 > 0)
            {
                for(int i = p.count12 / 2; i > -1; i-= 2)
                {
                    p.total -= 4;
                }
            }
            if(p.count4 / 3 > 0)
            {
                for(int i = p.count4 / 3; i > -1; i-= 3)
                {
                    p.total -= 2;
                }
            }
            if(p.count7 / 2 > 0)
            {
                for(int i = p.count7 / 2; i > -1; i-= 2)
                {
                    p.total -= 7;
                }
            }
            if(p.count5 / 3 > 0)
            {
                for(int i = p.count5 / 3; i > -1; i-= 3)
                {
                    p.total -= 5;
                }
            }

            // calculate the delivery charge
            if(p.total <= 50)
            {
                p.deliveryCharge = 7;
            }

            // return the total price with the discounts and the delivery charge (if any)
            return p.total + p.deliveryCharge;
        }

    }
}

