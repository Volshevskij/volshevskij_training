using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Bridge
    {
        DataAccessLayer.SqlServerAccess content = new DataAccessLayer.SqlServerAccess();

        public Bridge()
        {
        }

        public void AddEmployee(Common.Employee employee)
        {
            content.AddEmployee(employee);
        }

        public void UpdateEmployee(Common.Employee employee)
        {
            content.UpdateEmployee(employee);
        }

        public List<Common.Employee> GetFullEmployee()
        {
            return content.GetFullEmployee();
        }

        public void DeleteEmployee(string mail)
        {
            content.DeleteEmployee(mail);
        }

        public List<Common.Employee> GetNameSelect(string name)
        {
            return content.GetNameSelect(name);
        }

        public List<Common.Employee> GetMidNameSelect(string midName)
        {
            return content.GetMidNameSelect(midName);
        }

        public List<Common.Employee> GetLastNameSelect(string lastName)
        {
            return content.GetLastNameSelect(lastName);
        }

        public List<Common.Employee> GetDepartmentSelect(string department)
        {
            return content.GetDepartmentSelect(department);
        }

        public List<Common.Employee> GetStatusSelect(string status)
        {
            return content.GetStatusSelect(status);
        }

        public Common.Employee GetEmailSelect(string email)
        {
            return content.GetEmailSelect(email);
        }
    }
}
