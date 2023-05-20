

using Microsoft.AspNetCore.Components;
using Portfolio.Interfaces;
using Portfolio.Shared;

namespace Portfolio.Client.Pages;

public class BlogDetailsBase : ComponentBase
{
    [Parameter]
    public string Id {get; set;}

    [Inject]
    protected IBlogsDataRepository<BlogModel> BlogsRepo {get; set;}

    protected BlogModel Model {get; set;}

    protected override void OnInitialized()
    {
        Model = BlogsRepo.GetById(Id);
    }
}