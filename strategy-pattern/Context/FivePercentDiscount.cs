namespace strategy_pattern
{
    public class FivePercentDiscount : IDiscount
    {
        public int CalculateDiscount(int amount)
        {
            return amount * 5 / 100;
        }
    }
}
