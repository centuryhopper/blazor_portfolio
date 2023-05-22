using Microsoft.AspNetCore.Mvc;
using Portfolio.Server.Interfaces;
using Portfolio.Shared;

[Route("api/[controller]")]
[ApiController]
public class BlogsController : ControllerBase
{
    private readonly IBlogsDataRepository<BlogModel> BlogDataRepo;

    public BlogsController(IBlogsDataRepository<BlogModel> BlogDataRepo)
    {
        this.BlogDataRepo = BlogDataRepo;
    }

    [HttpGet]
    public IActionResult Test()
    {
        return Ok("endpoint works!");
    }

    [HttpGet]
    [Route("get-blogs")]
    public async Task<IActionResult> GetAsync()
    {
        var data = await BlogDataRepo.GetData();

        return Ok(data);
    }

    [HttpGet]
    [Route("{id}")]
    public async Task<IActionResult> GetAsync(string id)
    {
        var data = await BlogDataRepo.GetById(id);

        return Ok(data);
    }
}