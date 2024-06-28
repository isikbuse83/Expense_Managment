using Expense_Managment.configuration;
using Expense_Managment.Data;
using Expense_Managment.Models;
using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;


namespace Expense_Managment.Controllers


{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {

        private readonly IUnitOfWork _unitOfWork;
        public UserController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var user = await _unitOfWork.User.All();
            return Ok(user);
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> GetUser(int id)
        {
            var item = await _unitOfWork.User.GetById(id);

            if (item == null)
                return NotFound();
            return Ok(item);

        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(User user)
        {
            if (ModelState.IsValid)
            {
                await _unitOfWork.User.Add(user);
                await _unitOfWork.CompleteAsync();

                return CreatedAtAction(nameof(GetUser), new { user.Id }, user);
            }
            return new JsonResult("something went wrong") { StatusCode = 500 };


        }
        [HttpDelete("{id}")]

        public async Task<IActionResult> DeleteUser(int id)
        {
            var item = await _unitOfWork.User.GetById(id);
            if(item==null)
                return BadRequest();

            await _unitOfWork.User.Delete(id);
            await _unitOfWork.CompleteAsync();

            return Ok(item);
        }
        
        
        

    }

}


