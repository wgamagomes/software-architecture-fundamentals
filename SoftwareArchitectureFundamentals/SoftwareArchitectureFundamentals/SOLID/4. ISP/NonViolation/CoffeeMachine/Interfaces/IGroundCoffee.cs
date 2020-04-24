namespace SoftwareArchitectureFundamentals.SOLID.ISP.NonViolation.CoffeeMachine
{
    public interface IGroundCoffee
    {
        double QuantityGroundCoffee { get; }
        CoffeeType CoffeeType { get; }
        void SetQuantity(double quantity);
    }
}
