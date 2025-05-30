﻿using Expense_Management.configuration;
using Microsoft.AspNetCore.Http;
using Expense_Management.Models;
using Microsoft.AspNetCore.Mvc;
using Expense_Management.Data;
using Microsoft.AspNetCore.Http.HttpResults;



namespace Expense_Managment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserExpenseController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;

        private IUnitOfWork _unitOfWork;

        public UserExpenseController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var expenses = await _unitOfWork.UserExpense.All();
            return Ok(expenses);
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> GetUser(int id )
        {
            var  item = await _unitOfWork.UserExpense.GetById(id);  

            if (item == null) 
            {
                return NotFound();
            }
            return Ok(item);
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(UserExpense userExpense)
        {
            if (ModelState.IsValid) 
            { 
                await _unitOfWork.UserExpense.Add(userExpense);
                await _unitOfWork.CompleteAsync();

                return CreatedAtAction(nameof(GetUser), new {userExpense.Id},userExpense);

            }
            return new JsonResult("something went wrong") { StatusCode = 500 };

        }
         
           



    }
    

}
