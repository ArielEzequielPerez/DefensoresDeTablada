using defensoresCRUD.Core.Models.Dtos;
using System.Collections.Generic;

namespace defensoresCRUD.Core.Interfaces
{
    public interface IExerciseBusiness
    {
        IEnumerable<ExerciseDtoView> GetAllExercises();
    }
}
