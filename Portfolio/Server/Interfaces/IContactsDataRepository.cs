namespace Portfolio.Server.Interfaces;

public interface IContactsDataRepository<T>
{
    Task<string> PostDataAsync(T model);
}