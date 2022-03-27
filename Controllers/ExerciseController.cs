using defensoresCRUD.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace defensoresCRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExerciseController : ControllerBase
    {
        private readonly IExerciseBusiness _exercise;

        public ExerciseController(IExerciseBusiness exercise)
        {
            _exercise = exercise;
        }
        [HttpGet]
        public IActionResult GetAllExercise()
        {
            return Ok(_exercise.GetAllExercises());
        }
    }
}
