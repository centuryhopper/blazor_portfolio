// using Microsoft.AspNetCore.Components;
// using Portfolio.Interfaces;
// using Portfolio.Shared;

// namespace Portfolio.Client.Pages;

// public class ContactBase : ComponentBase
// {
//     [Inject]
//     protected IContactsDataRepository<ContactMeModel> ContactsRepo {get; set;}

//     protected ContactMeModel model = new();

//     protected async Task HandlePostContact()
//     {
//         System.Console.WriteLine($"posting model: {model}");
//         await ContactsRepo.PostDataAsync(model);
//     }


// }