 
using System.ComponentModel.DataAnnotations;
  

namespace back.Models
{
    
    public class Task
    {
         [Key]
        public int ID { get; set; }

        [Required]
   
        public string TaskName { get; set; }

        [Required]
        public bool State { get; set; }
    }
}
