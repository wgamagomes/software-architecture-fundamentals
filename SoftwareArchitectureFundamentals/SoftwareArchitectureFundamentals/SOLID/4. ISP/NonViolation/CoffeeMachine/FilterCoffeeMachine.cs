namespace SoftwareArchitectureFundamentals.SOLID.ISP.NonViolation.CoffeeMachine
{
    public class FilterCoffeeMachine : IFilterCoffeeMachine
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
    }
}
