namespace SoftwareArchitectureFundamentals.SOLID.ISP.NonViolation.CoffeeMachine
{
    public class BrewingUnit: IBrewingUnit
    {
        public CoffeeDrink Brew(IGroundCoffee groundCoffee, double quantityWater)
        {
            return new CoffeeDrink(groundCoffee, quantityWater);
        }
    }
}
