namespace ProductServiceApp.Models.DAL
{
    public interface IDaoContract<T> where T : class
    {
        ICollection<T>? GetAll();
        T? Add(T item);
    }
}
