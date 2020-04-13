namespace SoftwareArchitectureFundamentals.OOP.CompositionOverInheritance
{
    public class UsageScenarios
    {
        public static void Inheritance()
        {
            var acount = new BankAcount();
            var repository = new AcountRepositoryInheritance();

            // Desired behavior
            repository.Add(acount);

            // Has high coupling and low encapsulation 
            // Understand that I don't wanna access the remove method :( 
            repository.Remove(acount);
        }

        public static void Composition()
        {
            var acount = new BankAcount();
            IGenericRepository<BankAcount> genericRepository = new GenericRepository<BankAcount>();

            // Program to interfaces, not implementations
            // Low coupling
            // Dependency injection The "injection" refers to the passing of a dependency (GenericRepository)
            // into the object (AcountRepositoryComposition) that would use it.
            var repository = new AcountRepositoryComposition(genericRepository);

            // Same desired behavior
            repository.Add(acount);

            // High encapsulation so, now I can't access the remove method here. =)
            //acountRepositoryComposition.Remove(acount);


            // Composition over inheritance (or composite reuse principle) in object-oriented programming (OOP) 
            // is the principle that classes should achieve polymorphic behavior and code reuse by their composition 
            // (by containing instances of other classes that implement the desired functionality) rather than inheritance 
            // from a base or parent class. This is an often-stated principle of OOP, such as in the influential book 
            // Design Patterns: Elements of Reusable Object-Oriented Software
            // https://en.wikipedia.org/wiki/Composition_over_inheritance
        }
    }
}
