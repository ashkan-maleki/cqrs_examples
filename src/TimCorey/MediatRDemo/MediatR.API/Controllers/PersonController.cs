using MediatR.Lib.Commands;
using MediatR.Lib.Models;
using MediatR.Lib.Queries;
using Microsoft.AspNetCore.Mvc;

namespace MediatR.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PersonController : ControllerBase
{
    private readonly IMediator _mediator;
    // GET
    public PersonController(IMediator mediator)
    {
        _mediator = mediator;
    }
    
    [HttpGet]
    public async Task<List<PersonModel>> Index() => await _mediator.Send(new GetPersonListQuery());
    
    [HttpGet ("{id}")]
    public async Task<PersonModel> Index(int id) => 
        await _mediator.Send(new GetPersonByIdQuery(id));


    [HttpPost]
    public async Task<PersonModel> Post([FromBody] PersonModel value) 
        => await _mediator.Send(new InsertPersonCommand(value.FirstName, value.LastName));
}