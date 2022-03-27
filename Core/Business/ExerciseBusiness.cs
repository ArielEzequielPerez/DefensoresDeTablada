using defensoresCRUD.Core.Interfaces;
using defensoresCRUD.Core.Models.Dtos;
using defensoresCRUD.Data.Interfaces;
using System.Collections.Generic;

namespace defensoresCRUD.Core.Business
{
    public class ExerciseBusiness : IExerciseBusiness
    {
        private readonly IUnitOfWork _unitOfWork;
        public ExerciseBusiness(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<ExerciseDtoView> GetAllExercises()
        {
            var exercises = _unitOfWork.ExerciseRepository.GetAll();
            var exercisesDto = new List<ExerciseDtoView>();
            foreach (var exercise in exercises)
            {
                exercisesDto.Add();
            }

        }
    }
}
