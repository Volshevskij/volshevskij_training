using System.Collections.Generic;

namespace DataAccessLayer
{
    public interface ISqlServerAccess
    {
        void AddEmployee(Common.Employee employee);
        void UpdateEmployee(Common.Employee employee);
        List<Common.Employee> GetFullEmployee();
        void DeleteEmployee(string mail);
        List<Common.Employee> GetNameSelect(string name);
        List<Common.Employee> GetMidNameSelect(string midName);
        List<Common.Employee> GetLastNameSelect(string lastName);
        List<Common.Employee> GetDepartmentSelect(string department);
        List<Common.Employee> GetStatusSelect(string status);
        Common.Employee GetEmailSelect(string email);
    }
}
