using Microsoft.AspNetCore.Mvc;

namespace TaskApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TasksController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetTasks()
        {
            var tasks = new string[]
            {
                "Learn Angular",
                "Build .NET API",
                "Connect Frontend",
                "Deploy Project"
            };

            return Ok(tasks);
        }
    }
}