using CoreAppApi.Entities;
using CoreAppApi.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreAppApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        ITodoRepository _todoRepository;
        public TodoController(ITodoRepository todoRepository)
        {
            _todoRepository = todoRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var todos= await _todoRepository.GetAll();
            return Ok(todos);
        }
        [HttpPost]
        [Route(template:"id")]
        public async Task<IActionResult> Create(Todo todo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var todos = await _todoRepository.Create(todo);
            return CreatedAtAction(nameof(GetById),new {id= todos.Id }, todos);
        }
        [HttpGet]
        [Route(template:"id")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var task = await _todoRepository.GetById(id);
            if (task == null) return NotFound($"{id} is not found");
            return Ok(task);
        }

        [HttpPut]
        [Route(template: "id")]
        public async Task<IActionResult> Update(Guid id, Todo todo)
        {
            if(!ModelState.IsValid) return BadRequest(ModelState); 
            var todoFromDb= await _todoRepository.GetById(id);
            if (todoFromDb == null) return NotFound($"{id} not found");
            var task = await _todoRepository.Update(todo);
            return Ok(task);
        }

    }
}
