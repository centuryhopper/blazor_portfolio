using Portfolio.Shared;
using Portfolio.Server.Interfaces;

namespace Portfolio.Server.Repository;


public class ContactsDataRepository : IContactsDataRepository<ContactMeModel>
{

    public ContactsDataRepository()
    {

    }

    public async Task<string> PostDataAsync(ContactMeModel model)
    {
        await Task.Run(()=>{});
        System.Console.WriteLine("Posting model to db");
        return "posted success!";
    }
}