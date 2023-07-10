using System.ComponentModel.DataAnnotations;

namespace DataAccess.EFCore.Models
{
    public class Management
    {
        [Key]
        public int ManageId { get; set; }
        public string ManageName { get; set; }

        public virtual List<Student>? Students { get; set; }

        public virtual List<Course>? Courses { get; set; }
    }
}
