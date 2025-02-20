using Library.Communication.Requests;
using Library.Communication.Responses;
using Microsoft.AspNetCore.Mvc;
using nwl.useCases.Users.Register;

namespace nwl.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(ResponseRegisteredUserJson), StatusCodes.Status201Created)]
        public IActionResult Create(RequestUserJson request)
        {
            var useCase = new RegisterUserUseCase();
            var response = useCase.Execute(request);
            
            return Created(string.Empty, response);
        }

    }
}
