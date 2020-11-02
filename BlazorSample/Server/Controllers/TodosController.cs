using System.Collections.Generic;
using BlazorSample.Shared;
using Microsoft.AspNetCore.Mvc;

namespace BlazorSample.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TodosController : ControllerBase
    {
        private readonly List<Todo> _todos = new List<Todo>();

        public TodosController()
        {
            _todos.Add(new Todo {Status = TodoStatus.Ready, Title = "Try Blazor"});
        }

        [HttpPost]
        public void Create(Todo todo)
        {
            _todos.Add(todo);
        }
        
        [HttpGet]
        public List<Todo> Get()
        {
            return _todos;
        }
    }
}