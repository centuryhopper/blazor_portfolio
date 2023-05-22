using System.Net.Http.Json;
using Microsoft.AspNetCore.Components;
using Portfolio.Shared;

namespace Portfolio.Client.Pages;

public class ContactBase : ComponentBase
{
    [Inject]
    private IHttpClientFactory httpClientFactory { get; set; }

    protected ContactMeModel Model = new();

    protected async Task HandlePostContact()
    {
        System.Console.WriteLine($"posting model: {Model}");
        var client = httpClientFactory.CreateClient("API");
        var response = await client.PostAsJsonAsync("/api/Contacts/post-contact", Model);
        if (response.IsSuccessStatusCode)
        {
            Console.WriteLine(response.Content.ReadAsStringAsync());
            Model = new();
        }
    }


}