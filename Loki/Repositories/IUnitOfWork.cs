namespace Loki.Repositories
{
    public interface IUnitOfWork
    {
        IAnimalRepository Animals { get; }

        Task SaveChangesAsync();
    }
}