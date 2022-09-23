using StudenAdminPortal.API.DataModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudenAdminPortal.API.Repositories
{
    public interface IStudentRepo
    {
        Task<List<Student>> GetStudentsAsync();
    }
}
