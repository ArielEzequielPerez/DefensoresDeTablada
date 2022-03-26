using System;
using System.ComponentModel.DataAnnotations;

namespace defensoresCRUD.Models
{
    public class MaximumRep : EntityBase
    {
        [Required]
        public double WeightMax { get; set; }
        [Required]
        public double Reps { get; set; }

        public double RmGorostiaga { get; set; }
        
        /*
        public void CalculateRm()
        {
            RmGorostiaga = WeightMax / (1.0278 - (0.0278 * Reps));
        }*/
    }
}