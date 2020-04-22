namespace SoftwareArchitectureFundamentals.SOLID.ISP.Violation.CoffeeMachine
{
    public class EspressoCoffeeMachine : ICoffeeMachine
    {
        private readonly IBrewingUnit _BrewingUnit;
        private readonly IGroundCoffee _groundCoffee;
        private readonly double _quantityWater;

        public EspressoCoffeeMachine(IBrewingUnit brewingUnit , double quantityGroundCoffee, double quantityWater)
        {
            _BrewingUnit = brewingUnit;
            _groundCoffee = new EspressoGroundCoffee(quantityGroundCoffee);
            _quantityWater = quantityWater;
        }
         

        public CoffeeDrink BrewEspresso()
        {
            return _BrewingUnit.Brew(_groundCoffee, _quantityWater);
        }

        /// <summary>
        /// Interface Segregation principle
        /// Clients should not be forced to depend upon interfaces that they do not use
        /// </summary>        
        public CoffeeDrink BrewFilterCoffee()
        {
            throw new CoffeeException("This machine only brew espresso.");
        }
    }
}
