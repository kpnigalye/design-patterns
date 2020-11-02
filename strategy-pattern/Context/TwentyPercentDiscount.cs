namespace strategy_pattern
{
    public class TwentyPercentDiscount : IDiscount
    {
        public int CalculateDiscount(int amount)
        {
            return amount * 20 / 100;
        }
    }
}
