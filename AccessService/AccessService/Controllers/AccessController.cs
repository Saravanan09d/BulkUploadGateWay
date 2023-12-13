using Microsoft.AspNetCore.Mvc;
using AccessService.Models.DTO;
using AccessService.Services;
using AccessService.Model.DTO;
using System.Threading.Tasks;

namespace AccessService.Controllers
{
    public class AccessController : Controller
    {
        private readonly AccessesService _accessService;

        // Fix the parameter type to AccessesService
        public AccessController(AccessesService accessService)
        {
            _accessService = accessService; // Fix the assignment here
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginViewModelDTO model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var userDetailsDTO = await _accessService.AuthenticateAsync(model.Email, model.Password);
            if (userDetailsDTO != null)
            {
                return Ok(userDetailsDTO);
            }
            else
            {
                return BadRequest("Invalid credentials");
            }
        }

        [HttpPost("createUser")]
        public async Task<IActionResult> CreateUser([FromBody] UserTableModelDTO userModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var createdUser = await _accessService.CreateUserAsync(userModel);
            if (createdUser != null)
            {
                return Ok(createdUser);
            }
            else
            {
                return BadRequest("Failed to create user. Check role details.");
            }
        }
    }
}
