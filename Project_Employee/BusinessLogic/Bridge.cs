using System.Collections.Generic;

namespace BusinessLogic
{
    public class Bridge:IBridge
    {
        public  DataAccessLayer.ISqlServerAccess _content { get; set; }

        public Bridge(DataAccessLayer.ISqlServerAccess content)
        {
            _content = content;
        }

        public Bridge()
        {
        }

        public void AddEmployee(Common.Employee employee)
        {
            _content.AddEmployee(employee);
        }

        public void UpdateEmployee(Common.Employee employee)
        {
            _content.UpdateEmployee(employee);
        }

        public List<Common.Employee> GetFullEmployee()
        {
            return _content.GetFullEmployee();
        }

        public void DeleteEmployee(string mail)
        {
            _content.DeleteEmployee(mail);
        }

        public List<Common.Employee> GetNameSelect(string name)
        {
            return _content.GetNameSelect(name);
        }

        public List<Common.Employee> GetMidNameSelect(string midName)
        {
            return _content.GetMidNameSelect(midName);
        }

        public List<Common.Employee> GetLastNameSelect(string lastName)
        {
            return _content.GetLastNameSelect(lastName);
        }

        public List<Common.Employee> GetDepartmentSelect(string department)
        {
            return _content.GetDepartmentSelect(department);
        }

        public List<Common.Employee> GetStatusSelect(string status)
        {
            return _content.GetStatusSelect(status);
        }

        public List<Common.Employee> GetWorkPeriodSelect(string workPeriod)
        {
            return _content.GetWorkPeriodSelect(workPeriod);
        }

        public Common.Employee GetEmailSelect(string email)
        {
            return _content.GetEmailSelect(email);
        }
    }
}
