namespace Portfolio.Server.Interfaces;

public interface IProjectsDataRepository<T>
{
    Task<string> GetData();
    IEnumerable<T> Search(string searchTerm);
}
