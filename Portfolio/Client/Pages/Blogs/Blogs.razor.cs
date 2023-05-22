using System.Net.Http.Json;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using Portfolio.Shared;
namespace Portfolio.Client.Pages;

public class BlogsBase : ComponentBase
{
    protected IEnumerable<BlogModel>? BlogCards;

    [Inject]
    private IHttpClientFactory httpClientFactory {get; set;}

    protected bool IsNewest = false;

    protected override async Task OnInitializedAsync()
    {
        // TODO: later on will use repository pattern and dapper context from database
        var client = httpClientFactory.CreateClient("API");
        var response = await client.GetAsync("/api/Blogs/get-blogs");

        if (response.IsSuccessStatusCode)
        {
            var data = await response.Content.ReadAsStringAsync();

            var dto = JsonConvert.DeserializeObject<IEnumerable<BlogModel>>(data);

            // foreach (var o in dto)
            // {
            //     System.Console.WriteLine(o);
            // }

            BlogCards = dto;
        }

    }

    protected void HandleSort()
    {
        if (IsNewest)
        {
            BlogCards = BlogCards?.OrderBy(x => x.date);
        }
        else
        {
            BlogCards = BlogCards?.OrderByDescending(x => x.date);
        }
        IsNewest = !IsNewest;
    }
}