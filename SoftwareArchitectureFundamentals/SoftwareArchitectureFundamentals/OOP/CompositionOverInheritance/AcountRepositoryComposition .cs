namespace SoftwareArchitectureFundamentals.OOP.CompositionOverInheritance
{
    public class AcountRepositoryComposition: IAcountRepository
    {
        private readonly IGenericRepository<BankAcount> _repository;
        public AcountRepositoryComposition(IGenericRepository<BankAcount> repository)
        {
            _repository = repository;
        }

        public void Add(BankAcount acount)
        {
            _repository.Add(acount);
        }
    }
}
