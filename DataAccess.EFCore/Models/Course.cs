using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.EFCore.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        
        public int Number { get; set; }
        
        public string ?Name { get; set; }
        
        public string ?Duration { get; set; }
        
        public string ?Fees { get; set; }

        [ForeignKey("Management")] public int? ManagementId { get; set; }
        public virtual Management Management { get; set; }
    }
}
