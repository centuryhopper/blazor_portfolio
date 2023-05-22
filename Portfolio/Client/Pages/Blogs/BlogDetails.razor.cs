using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using Portfolio.Shared;

namespace Portfolio.Client.Pages;

public class BlogDetailsBase : ComponentBase
{
    [Parameter]
    public string Id {get; set;}

    protected BlogModel? Model {get; set;}
    [Inject]
    private IHttpClientFactory httpClientFactory {get; set;}

    protected override async Task OnInitializedAsync()
    {
        var client = httpClientFactory.CreateClient("API");
        var response = await client.GetAsync($"/api/Blogs/{Id}");
        if (response.IsSuccessStatusCode)
        {
            var data = await response.Content.ReadAsStringAsync();

            var dto = JsonConvert.DeserializeObject<BlogModel>(data);

            System.Console.WriteLine(dto);

            Model = dto;
        }
    }
}
