using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using Portfolio.Shared;

namespace Portfolio.Client.Pages;


public class ProjectsBase : ComponentBase
{
    protected IEnumerable<ProjectCardModel>? Projects { get; set; }
    protected string? SearchTerm { get; set; }
    [Inject]
    private IHttpClientFactory? httpClientFactory { get; set; }

    protected override async Task OnInitializedAsync()
    {
        // TODO: later on will use repository pattern and dapper context from database
        var client = httpClientFactory.CreateClient("API");
        var response = await client.GetAsync("/api/Projects/get-projects");

        if (response.IsSuccessStatusCode)
        {
            var data = await response.Content.ReadAsStringAsync();

            var dto = JsonConvert.DeserializeObject<IEnumerable<ProjectCardModel>>(data);

            foreach (var o in dto)
            {
                System.Console.WriteLine(o);
            }

            Projects = dto;
        }

    }

    protected void HandleSearchFilter(ChangeEventArgs e)
    {
        SearchTerm = e?.Value?.ToString();
        if (string.IsNullOrEmpty(SearchTerm))
        {
            return;
        }

        Projects = Projects?.Where(project => project.title!.ToLower().Contains(SearchTerm.ToLower()));
    }
}