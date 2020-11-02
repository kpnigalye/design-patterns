namespace strategy_pattern
{
    public class TenPercentDiscount : IDiscount
    {
        public int CalculateDiscount(int amount)
        {
            return amount * 10 / 100;
        }
    }
}
