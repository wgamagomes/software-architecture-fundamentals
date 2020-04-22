namespace SoftwareArchitectureFundamentals.SOLID.ISP.Violation.CoffeeMachine
{
    public interface IGroundCoffee
    {
        double QuantityGroundCoffee { get; }
        CoffeeType CoffeeType { get; }
        void SetQuantity(double quantity);
    }
}
