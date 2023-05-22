namespace Portfolio.Server.Interfaces;

public interface IBlogsDataRepository<T>
{
    IEnumerable<T> Sort(bool isNewest);
    Task<string> GetData();
    Task<string> GetById(string id);
}