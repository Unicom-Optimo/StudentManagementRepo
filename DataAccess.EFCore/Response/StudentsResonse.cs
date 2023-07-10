using System.ComponentModel.DataAnnotations;

namespace DataAccess.EFCore.Response
{
    public class StudentsResonse
    {
        public int Id { get; set; }
        
        public int Number { get; set; }
      
        public string? RegisterNo { get; set; }
       
        public string? FirstName { get; set; }
        
        public string? LastName { get; set; }
      
        public string? Email { get; set; }
     
        public string? Dob { get; set; }
     
        public string? Phone { get; set; }

        public int? ManageId { get; set; }
        public string ManageName { get; set; }
    }
}
