using Microsoft.AspNetCore.Mvc;
using Portfolio.Server.Interfaces;
using Portfolio.Shared;

[Route("api/[controller]")]
[ApiController]
public class ProjectsController : ControllerBase
{
    private readonly IProjectsDataRepository<ProjectCardModel> ProjectRepo;

    public ProjectsController(IProjectsDataRepository<ProjectCardModel> ProjectRepo)
    {
        this.ProjectRepo = ProjectRepo;
    }

    [HttpGet]
    public IActionResult Test()
    {
        return Ok("endpoint works!");
    }

    [HttpGet]
    [Route("get-projects")]
    public async Task<IActionResult> GetAsync()
    {
        var data = await ProjectRepo.GetData();

        return Ok(data);
    }
}