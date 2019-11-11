namespace ConsoleApp11
{
    internal class PricingRules
    {
        public int count12 { get; set; }
        public int count4 { get; set; }
        public int count7 { get; set; }
        public int count5 { get; set; }
        public double total { get; set; }
        public int deliveryCharge { get; set; }

        public void applyPricingRules(double priceOfItem)
        {
            // each pricing rule has a count, which will be handled in the CalculatePrice method
            switch (priceOfItem)
            {
                case 12:
                    count12++;
                    break;
                case 4:
                    count4++;
                    break;
                case 7:
                    count7++;
                    break;
                case 5:
                    count5++;
                    break;
                default:
                    break;
            }
           
        }

    }
}