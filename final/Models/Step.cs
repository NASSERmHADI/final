using System.ComponentModel.DataAnnotations;

namespace final.Models
{
    public class Step
    {
        public int StepNumber { get; set; }
        [Key]
        public DateTime StepDate { get; set; }
    }
}
