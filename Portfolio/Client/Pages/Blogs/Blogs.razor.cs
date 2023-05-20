using Microsoft.AspNetCore.Components;
using Portfolio.Interfaces;
using Portfolio.Shared;
namespace Portfolio.Client.Pages;

public class BlogsBase : ComponentBase
{
    protected IEnumerable<BlogModel> BlogCards;

    [Inject]
    protected IBlogsDataRepository<BlogModel> BlogsRepo {get; set;}

    protected bool IsNewest = false;

    protected override async Task OnInitializedAsync()
    {
        // TODO: later on will use repository pattern and dapper context from database
        BlogCards = BlogsRepo.GetData();
        await Task.Run(()=>{});
    }

    protected void HandleSort()
    {
        BlogCards = BlogsRepo.Sort(IsNewest);
        IsNewest = !IsNewest;
    }
}