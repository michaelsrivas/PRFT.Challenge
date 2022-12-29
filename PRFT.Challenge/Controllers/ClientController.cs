using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PRFT.Challenge.Application.Clients.Commands.CreateClient;
using PRFT.Challenge.Contracts.Clients;

namespace PRFT.Challenge.Api.Controllers;

[Route("api/[controller]")]
public class ClientController : ApiController
{
    private readonly IMapper _mapper;
    private readonly ISender _mediator;

    public ClientController(IMapper mapper, ISender mediator)
    {
        _mapper = mapper;
        _mediator = mediator;
    }

    // GET: api/<BranchController>
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(Array.Empty<string>());
    }

    // GET api/<BranchController>/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return "value";
    }

    // POST api/<BranchController>
    [HttpPost]
    public async Task <IActionResult> Post(
        CreateClientRequest request)
    {
        var command = _mapper.Map<CreateClientCommand>(request);
        var createClientResult = await _mediator.Send(command);
        return createClientResult.Match(
            client => Ok(_mapper.Map<ClientResponse>(client)),
            errors => Problem(errors));
    }

    // PUT api/<BranchController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/<BranchController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}
