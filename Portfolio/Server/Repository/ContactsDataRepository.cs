using Portfolio.Shared;
using Portfolio.Server.Interfaces;
using Portfolio.Server.Contexts;
using Dapper;

namespace Portfolio.Server.Repository;

public class ContactsDataRepository : IContactsDataRepository<ContactMeModel>
{
    private readonly DapperContext Context;

    public ContactsDataRepository(DapperContext Context)
    {
        this.Context = Context;
    }

    public async Task<string> PostDataAsync(ContactMeModel model)
    {
        using var Connection = Context.CreateConnection();
        // var query = "SELECT * FROM \"ContactDb\"";
        // var data = await Connection.QueryAsync<ContactMeModel>(query);
        var query = $"insert into \"ContactDb\" values ('{model.Id}','{model.Name}','{model.Email}','{model.Subject}','{model.Message}')";

        try
        {
            var response = await Connection.ExecuteAsync(query);
            return string.Join("\n", response);
        }
        catch (Exception e)
        {
            return e.Message;
        }
    }
}




