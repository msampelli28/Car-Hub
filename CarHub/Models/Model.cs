using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarHub.Models
{
     [Table("Models")] //not a good practice to use data annotations
    public class Model
    {       
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public Make Make{ get; set; }

        public int MakeID { get; set; }

    }
}