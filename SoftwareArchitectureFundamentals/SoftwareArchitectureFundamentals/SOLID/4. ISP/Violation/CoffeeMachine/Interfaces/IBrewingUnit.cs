namespace SoftwareArchitectureFundamentals.SOLID.ISP.Violation.CoffeeMachine
{
    public interface IBrewingUnit
    {
        CoffeeDrink Brew(IGroundCoffee groundCoffee, double quantityWater);
    }
}
