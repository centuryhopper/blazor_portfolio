namespace Portfolio.Interfaces;

public interface IBlogsDataRepository<T>
{
    IEnumerable<T> Sort(bool isNewest);
    IEnumerable<T> GetData();
    T GetById(string id);
}