namespace strategy_pattern
{
    // Family of 'Discount' algorithms
    // algorithms are interchangable based on the amount
    // type of discount is selected at runtime
    public interface IDiscount
    {
        int CalculateDiscount(int amount);
    }
}
