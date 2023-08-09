namespace YSKUdemy.BankApp.Data.Repositories
{
    public interface IGenericRepository<T> where T : class, new()
    {
        List<T> GetAll();
        T GetById(object id);
        void Create(T entity);
        void Remove(T entity);
        void Update(T entity);

    }
}
