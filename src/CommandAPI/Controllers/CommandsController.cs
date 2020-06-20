using System.Collections.Generic;
using CommandAPI.Data;
using CommandAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CommandAPI.Controllers
{
    [Route("api/[controller]")] 
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICommanderRepo _repository;
        public CommandsController(ICommanderRepo repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Command>> Get() 
        {
            var commands = _repository.GetAllCommands();

            return Ok(commands);
        }
        //Get api/commands/{id}
        [HttpGet("{id}")]
        public ActionResult<Command> GetCommandById(int Id)
        {
            var command = _repository.GetCommandById(Id);
            
            return Ok(command);
        }
    }

}