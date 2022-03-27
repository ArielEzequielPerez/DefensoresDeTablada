using defensoresCRUD.Core.Interfaces;
using defensoresCRUD.Core.Models.Dtos;
using defensoresCRUD.Data.Interfaces;
using System.Collections.Generic;

namespace defensoresCRUD.Core.Business
{
    public class ExerciseBusiness : IExerciseBusiness
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public ExerciseBusiness(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public IEnumerable<ExerciseDtoView> GetAllExercises()
        {
            var exercises = _unitOfWork.ExerciseRepository.GetAll();
            var exercisesDto = new List<ExerciseDtoView>();
            foreach (var exercise in exercises)
            {
                exercisesDto.Add(_mapper.Map<ExerciseDtoView>(exercise));
            }
        }
    }
}
