namespace SoftwareArchitectureFundamentals.SOLID.ISP.Violation.CoffeeMachine
{
    public class BrewingUnit: IBrewingUnit
    {
        public CoffeeDrink Brew(IGroundCoffee groundCoffee, double quantityWater)
        {
            return new CoffeeDrink(groundCoffee, quantityWater);
        }
    }
}
