using System.ComponentModel.DataAnnotations;

namespace DataAccess.EFCore.Response
{
    public class StudentsResonse
    {
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

        public int ManageId { get; set; }
        public string? ManageName { get; set; }
    }
}
