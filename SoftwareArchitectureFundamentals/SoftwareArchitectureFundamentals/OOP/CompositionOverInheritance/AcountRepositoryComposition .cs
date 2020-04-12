namespace SoftwareArchitectureFundamentals.OOP.CompositionOverInheritance
{
    public class AcountRepositoryComposition: IAcountRepository
    {
        private readonly IGenericRepository<Acount> _repository;
        public AcountRepositoryComposition(IGenericRepository<Acount> repository)
        {
            _repository = repository;
        }

        public void Add(Acount acount)
        {
            _repository.Add(acount);
        }
    }
}
