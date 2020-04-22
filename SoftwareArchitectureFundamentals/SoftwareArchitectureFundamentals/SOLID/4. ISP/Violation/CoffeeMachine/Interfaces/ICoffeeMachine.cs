namespace SoftwareArchitectureFundamentals.SOLID.ISP.Violation.CoffeeMachine
{
    public interface ICoffeeMachine
    {
        CoffeeDrink BrewFilterCoffee();
        CoffeeDrink BrewEspresso();      
    }
}