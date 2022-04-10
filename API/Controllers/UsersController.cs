
using Microsoft.AspNetCore.Mvc;
using MediatR;
using System.Threading.Tasks;
using System.Collections.Generic;
using Domain;
using Application.Users;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase {
        private readonly IMediator _mediator;

        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<User>>> List() 
        {
            return await _mediator.Send(new ListRequest.Query());
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> Details(int id) 
        {
            return await _mediator.Send(new DetailsRequest.Query{Id = id});
        }
    }
}




// I Clean Architecture separerer man api kaldet fra controller, hvor her bliver det behandlet i API, som så kalder application.
// Hvorfor: For at løskoble og senere kan nemt udskifter sin database med en ny. 