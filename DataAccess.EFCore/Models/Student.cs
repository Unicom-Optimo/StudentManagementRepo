using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.EFCore.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Number { get; set; }
        [Required]
        public String? RegisterNo { get; set; }
        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? LastName { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? Dob { get; set; }
        [Required]
        public string? Phone { get; set; }

        [ForeignKey("Management")] public int? ManagementId { get; set; }
        public virtual Management? Management { get; set; }
    }
}
