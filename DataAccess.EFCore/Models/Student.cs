using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.EFCore.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
    
        public int Number { get; set; }
   
        public string? RegisterNo { get; set; }
                     
        public string? FirstName { get; set; }
                     
        public string? LastName { get; set; }
                     
        public string? Email { get; set; }
                     
        public string? Dob { get; set; }
                     
        public string? Phone { get; set; }

        [ForeignKey("Management")] 
        public int? ManagementId { get; set; }
        public virtual Management Management { get; set; }
    }
}
