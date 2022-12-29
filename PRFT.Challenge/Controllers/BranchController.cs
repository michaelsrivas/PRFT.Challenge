using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PRFT.Challenge.Application.Branches.Commands.CreateBranch;
using PRFT.Challenge.Contracts.Branches;

namespace PRFT.Challenge.Api.Controllers
{
    [Route("api/clients/{clientId}/[controller]")]    
    public class BranchController : ApiController
    {
        private readonly IMapper _mapper;
        private readonly ISender _mediator;

        public BranchController(IMapper mapper, ISender mediator)
        {
            _mapper = mapper;
            _mediator = mediator;
        }

        // GET: api/<BranchController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<BranchController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<BranchController>
        [HttpPost]
        public async Task<IActionResult> Post(CreateBranchRequest request, string clientId)
        {
            var command = _mapper.Map<CreateBranchCommand>((request, clientId));
            var createBranchResuls = await _mediator.Send(command);
            return createBranchResuls.Match(
                branch => Ok(_mapper.Map<BranchResponse>(branch)),
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
}
