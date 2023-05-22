using Microsoft.AspNetCore.Mvc;
using Portfolio.Server.Interfaces;
using Portfolio.Shared;

[Route("api/[controller]")]
[ApiController]
public class ContactsController : ControllerBase
{
    private readonly IContactsDataRepository<ContactMeModel> ContactRepo;
    private readonly ILogger<ContactsController> logger;

    public ContactsController(IContactsDataRepository<ContactMeModel> ContactRepo, ILogger<ContactsController> Logger)
    {
        this.ContactRepo = ContactRepo;
        logger = Logger;
    }

    [HttpGet]
    public IActionResult Test()
    {
        return Ok("endpoint works!");
    }

    [HttpPost]
    [Route("post-contact")]
    public async Task<IActionResult> PostAsync([FromBody] ContactMeModel model)
    {
        var data = await ContactRepo.PostDataAsync(model);
        // logger.LogWarning(data);
        return Ok(data);
    }
}