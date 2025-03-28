namespace ContactServiceApp.DAL
{
    public interface IDaoContract<T, TKey> where T : class
    {
        ICollection<T> GetAll();
        T? Get(TKey primaryKeyValue);
        bool Add(T item);
        bool Remove(TKey primaryKeyValue);
        bool Update(TKey primaryKeyValue, T updatedItem);
    }
}
