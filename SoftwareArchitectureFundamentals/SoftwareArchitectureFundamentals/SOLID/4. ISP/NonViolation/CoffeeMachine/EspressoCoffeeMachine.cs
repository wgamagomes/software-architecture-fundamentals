namespace SoftwareArchitectureFundamentals.SOLID.ISP.NonViolation.CoffeeMachine
{
    public class EspressoCoffeeMachine : IEspressoCoffeeMachine
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
    }
}
