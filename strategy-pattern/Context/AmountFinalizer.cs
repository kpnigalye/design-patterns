namespace strategy_pattern
{
    // Context which decides the strategy to use at runtime
    // Client has no idea about how discounts are applied
    public class AmountFinalizer
    {
        private IDiscount discount;

        public int GetBillingAmount(int amount)
        {
            // strategy to choose type of discount
            int billingAmount;

            if (amount >= 2000)
            {
                discount = new TwentyPercentDiscount();
                billingAmount = discount.CalculateDiscount(amount);
            }
            else if (amount > 1000)
            {
                discount = new TenPercentDiscount();
                billingAmount = discount.CalculateDiscount(amount);
            }
            else
            {
                discount = new FivePercentDiscount();
                billingAmount = discount.CalculateDiscount(amount);
            }

            return amount - billingAmount;
        }
    }
}
