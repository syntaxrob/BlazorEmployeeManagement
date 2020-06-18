using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Api.Models
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly AppDbContext _appDbContext;

        public DepartmentRepository(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }
        
        public async Task<Department> GetDepartment(int departmentId)
        {
            return await _appDbContext.Departments.FirstOrDefaultAsync(d => d.DepartmentId == departmentId);
        }

        public async Task<IEnumerable<Department>> GetDepartments()
        {
            return await _appDbContext.Departments.ToListAsync();
        }
    }
}
