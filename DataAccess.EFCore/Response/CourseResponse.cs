using System.ComponentModel.DataAnnotations;

namespace DataAccess.EFCore.Response
{
    public class CourseResponse
    {
        public int Id { get; set; }
        
        public int Number { get; set; }
        
        public string Name { get; set; }
      
        public string Duration { get; set; }
    
        public string Fees { get; set; }
        public int ManageId { get; set; }
        public string ManageName { get; set; }
    }
}
