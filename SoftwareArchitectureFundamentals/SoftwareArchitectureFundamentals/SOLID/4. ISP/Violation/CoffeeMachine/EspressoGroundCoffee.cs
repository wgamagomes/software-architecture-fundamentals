namespace SoftwareArchitectureFundamentals.SOLID.ISP.Violation.CoffeeMachine
{

    public class EspressoGroundCoffee : IGroundCoffee
    {
        public EspressoGroundCoffee(double quantity)
        {
            QuantityGroundCoffee = quantity;
        }
        public double QuantityGroundCoffee { get; private set; }
        public CoffeeType CoffeeType => CoffeeType.Basic;

        public void SetQuantity(double quantity)
        {
            QuantityGroundCoffee = quantity;
        }
    }
}