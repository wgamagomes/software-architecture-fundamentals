namespace SoftwareArchitectureFundamentals.SOLID.ISP.Violation.CoffeeMachine
{
    public class FilterCoffeeMachine : ICoffeeMachine
    {
        private readonly IBrewingUnit _BrewingUnit;
        private readonly IGroundCoffee _groundCoffee;
        private readonly double _quantityWater;
        public FilterCoffeeMachine(IBrewingUnit brewingUnit, double quantityGroundCoffee, double quantityWater)
        {
            _BrewingUnit = brewingUnit;
            _groundCoffee = new BasicGroundCoffee(quantityGroundCoffee);
            _quantityWater = quantityWater;
        }

        public CoffeeDrink BrewFilterCoffee()
        {
            return _BrewingUnit.Brew(_groundCoffee, _quantityWater);
        }

        /// <summary>
        /// Interface Segregation principle
        /// Clients should not be forced to depend upon interfaces that they do not use
        /// </summary>       
        public CoffeeDrink BrewEspresso()
        {
            throw new CoffeeException("This machine only brews filter coffee.");
        }
    }
}
