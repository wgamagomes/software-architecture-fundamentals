namespace SoftwareArchitectureFundamentals.SOLID.ISP.NonViolation.CoffeeMachine
{
    public class CoffeeDrink
    {
        public CoffeeDrink(IGroundCoffee groundCoffee, double quantityWater)
        {
            CoffeeType = groundCoffee.CoffeeType;

            QuantityWater = quantityWater;

            QuantityGroundCoffee = groundCoffee.QuantityGroundCoffee;
        }

        public CoffeeType CoffeeType { get; }
        public double QuantityWater { get; }
        public double QuantityGroundCoffee { get; }
    }
}
