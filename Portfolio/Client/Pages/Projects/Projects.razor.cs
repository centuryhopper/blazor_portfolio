

using Microsoft.AspNetCore.Components;
using Portfolio.Interfaces;
using Portfolio.Shared;

namespace Portfolio.Client.Pages;


public class ProjectsBase : ComponentBase
{
    protected IEnumerable<ProjectCardModel> projects {get; set;}
    protected string SearchTerm {get; set;}

    [Inject]
    IProjectsDataRepository<ProjectCardModel> ProjectsDataRepo {get; set;}

    protected override void OnInitialized()
    {
        projects = ProjectsDataRepo.GetData();
    }

    protected void HandleSearchFilter()
    {
        projects = ProjectsDataRepo.Search(SearchTerm);
    }
}