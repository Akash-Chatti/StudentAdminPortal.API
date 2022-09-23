using Microsoft.EntityFrameworkCore;
using StudenAdminPortal.API.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudenAdminPortal.API.Repositories
{
    public class SqlStudentRepo : IStudentRepo
    {
        public readonly StudentAdminContext Context;
        public SqlStudentRepo(StudentAdminContext cont)
        {
            Context = cont;
        }


        public async Task<List<Student>> GetStudentsAsync()
        {
            return await Context.Student.Include(nameof(Gender)).Include(nameof(Address)).ToListAsync();
        }
    }
}
