using MediatR;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Filters;
using Web.Api.Application.Commands;
using Web.Api.Application.Queries;
using Web.Api.CrossCutting;

namespace Web.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PeopleController(IMediator mediator) : ControllerBase
{
    [HttpPost]
    [SwaggerResponseExample(StatusCodes.Status200OK, typeof(PeopleCreateResponseDtoExamplesProvider))]
    [SwaggerRequestExample(typeof(PeopleCreateRequestDto), typeof(PeopleCreateRequestDtoExamplesProvider))]
    public async Task<IActionResult> Create([FromBody] PeopleCreateRequestDto peopleCreateRequestDto)
    {
        var result = await mediator.Send(new PeopleCreateCommand(peopleCreateRequestDto));
        return Ok(result);
    }

    [HttpGet("{Id}")]
    [SwaggerResponseExample(StatusCodes.Status200OK, typeof(PeopleQueryResponseDto))]
    public async Task<IActionResult> Query(Guid Id)
    {
        var result = await mediator.Send(new PessoaQuery(Id));
        return Ok(result);
    }
}
