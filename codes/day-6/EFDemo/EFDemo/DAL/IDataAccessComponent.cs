using EFDemo.Repository;

namespace EFDemo.DAL
{
    public interface IDataAccessComponent<T> where T : class
    {
        IReadOnlyCollection<T> GetAll();
    }
}