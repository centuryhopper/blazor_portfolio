namespace Portfolio.Interfaces;

public interface IProjectsDataRepository<T>
{
    IEnumerable<T> GetData();
    IEnumerable<T> Search(string searchTerm);
}
