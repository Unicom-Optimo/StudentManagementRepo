using DataAccess.EFCore.Models;

namespace DataAccess.EFCore.Interfaces
{
    public interface ManagementInterface
    {
        public Task<Management> Add(Management managementObj);
        public IEnumerable<Management> GetAll();
        public Management GetById(int id);
    }
}
