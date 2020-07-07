using System.Collections.Generic;
using StaffStuff.Core.Models;

namespace StaffStuff.Core.Services
{
    public interface IStaffData
    {
        List<Employee> GetEmployees();
    }
}
