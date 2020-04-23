namespace SoftwareArchitectureFundamentals.SOLID.ISP.NonViolation.CoffeeMachine
{
    public interface IBrewingUnit
    {
        CoffeeDrink Brew(IGroundCoffee groundCoffee, double quantityWater);
    }
}
