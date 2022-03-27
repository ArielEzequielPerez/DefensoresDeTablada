using System.ComponentModel.DataAnnotations;

namespace defensoresCRUD.Core.Models.Dtos
{
    public class ExerciseDtoView
    {
        [Display(Name = "Name")]
        public string  Name { get; set; }
        [Required(ErrorMessage = "You must enter a value for weight")]
        [Display(Name = "Weight")]
        public double Weight { get; set; }
        [Required(ErrorMessage = "You must enter a value for reps")]
        [Display(Name = "Reps")]
        public int Reps { get; set; }
        [Required(ErrorMessage = "You must enter a value for sets")]
        [Display(Name = "Set")]
        public int Sets { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
        public string Image { get; set; }
        [Url]
        public string videoLink { get; set; }

    }
}
