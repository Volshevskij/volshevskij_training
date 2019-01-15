using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class SqlServerAccess
    {
        private const string connectionString = @"Data Source=АНАНАС\SQLEXPRESS;Initial Catalog=EmployeeDB_1;Integrated Security=True;Pooling=False";

        public SqlServerAccess()
        {
        }

        public void AddEmployee(Common.Employee employee)
        {
            string sqlExpression = "AddEmployeeEmail";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter emailParam = new SqlParameter
                {
                    ParameterName = "@Email",
                    Value = employee.Email
                };
                command.Parameters.Add(emailParam);

                SqlParameter nameParam = new SqlParameter
                {
                    ParameterName = "@Name",
                    Value = employee.Name
                };
                command.Parameters.Add(nameParam);

                SqlParameter midNameParam = new SqlParameter
                {
                    ParameterName = "@MidName",
                    Value = employee.MidName
                };
                command.Parameters.Add(midNameParam);

                SqlParameter lastNameParam = new SqlParameter
                {
                    ParameterName = "@LastName",
                    Value = employee.LastName
                };
                command.Parameters.Add(lastNameParam);

                SqlParameter DepartmentParam = new SqlParameter
                {
                    ParameterName = "@Department",
                    Value = employee.Department
                };
                command.Parameters.Add(DepartmentParam);

                SqlParameter depPhoneParam = new SqlParameter
                {
                    ParameterName = "@DepPhone",
                    Value = employee.DepPhone
                };
                command.Parameters.Add(depPhoneParam);

                SqlParameter depAdressParam = new SqlParameter
                {
                    ParameterName = "@DepAdress",
                    Value = employee.DepAdress
                };
                command.Parameters.Add(depAdressParam);

                SqlParameter depDescriptionParam = new SqlParameter
                {
                    ParameterName = "@DepDescription",
                    Value = employee.DepDescription
                };
                command.Parameters.Add(depDescriptionParam);

                SqlParameter phoneParam = new SqlParameter
                {
                    ParameterName = "@Phone",
                    Value = employee.Phone
                };
                command.Parameters.Add(phoneParam);

                SqlParameter adressParam = new SqlParameter
                {
                    ParameterName = "@Adress",
                    Value = employee.Adress
                };
                command.Parameters.Add(adressParam);

                SqlParameter statusParam = new SqlParameter
                {
                    ParameterName = "@Status",
                    Value = employee.Status
                };
                command.Parameters.Add(statusParam);

                SqlParameter photoParam = new SqlParameter
                {
                    ParameterName = "@Photo",
                    Value = employee.Photo
                };
                command.Parameters.Add(photoParam);

                SqlParameter workPeriodParam = new SqlParameter
                {
                    ParameterName = "@WorkPeriod",
                    Value = employee.WorkPeriod
                };
                command.Parameters.Add(workPeriodParam);

                SqlParameter maritalStatusParam = new SqlParameter
                {
                    ParameterName = "@MaritalStatus",
                    Value = employee.MaritalStatus
                };
                command.Parameters.Add(maritalStatusParam);
                try
                {
                    command.ExecuteNonQuery();
                }
                catch
                {
                    Console.WriteLine("МЫЛО!!!!!!!");
                }
            }
        }

        public void UpdateEmployee(Common.Employee employee)
        {
            string sqlExpression = "UpdateEmployee_Info";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter emailParam = new SqlParameter
                {
                    ParameterName = "@Email",
                    Value = employee.Email
                };
                command.Parameters.Add(emailParam);

                SqlParameter nameParam = new SqlParameter
                {
                    ParameterName = "@Name",
                    Value = employee.Name
                };
                command.Parameters.Add(nameParam);

                SqlParameter midNameParam = new SqlParameter
                {
                    ParameterName = "@MidName",
                    Value = employee.MidName
                };
                command.Parameters.Add(midNameParam);

                SqlParameter lastNameParam = new SqlParameter
                {
                    ParameterName = "@LastName",
                    Value = employee.LastName
                };
                command.Parameters.Add(lastNameParam);

                SqlParameter DepartmentParam = new SqlParameter
                {
                    ParameterName = "@Department",
                    Value = employee.Department
                };
                command.Parameters.Add(DepartmentParam);

                SqlParameter depPhoneParam = new SqlParameter
                {
                    ParameterName = "@DepPhone",
                    Value = employee.DepPhone
                };
                command.Parameters.Add(depPhoneParam);

                SqlParameter depAdressParam = new SqlParameter
                {
                    ParameterName = "@DepAdress",
                    Value = employee.DepAdress
                };
                command.Parameters.Add(depAdressParam);

                SqlParameter depDescriptionParam = new SqlParameter
                {
                    ParameterName = "@DepDescription",
                    Value = employee.DepDescription
                };
                command.Parameters.Add(depDescriptionParam);

                SqlParameter phoneParam = new SqlParameter
                {
                    ParameterName = "@Phone",
                    Value = employee.Phone
                };
                command.Parameters.Add(phoneParam);

                SqlParameter adressParam = new SqlParameter
                {
                    ParameterName = "@Adress",
                    Value = employee.Adress
                };
                command.Parameters.Add(adressParam);

                SqlParameter statusParam = new SqlParameter
                {
                    ParameterName = "@Status",
                    Value = employee.Status
                };
                command.Parameters.Add(statusParam);

                SqlParameter photoParam = new SqlParameter
                {
                    ParameterName = "@Photo",
                    Value = employee.Photo
                };
                command.Parameters.Add(photoParam);

                SqlParameter workPeriodParam = new SqlParameter
                {
                    ParameterName = "@WorkPeriod",
                    Value = employee.WorkPeriod
                };
                command.Parameters.Add(workPeriodParam);

                SqlParameter maritalStatusParam = new SqlParameter
                {
                    ParameterName = "@MaritalStatus",
                    Value = employee.MaritalStatus
                };
                command.Parameters.Add(maritalStatusParam);

                SqlParameter idParam = new SqlParameter
                {
                    ParameterName = "@Id",
                    Value = employee.Id
                };
                command.Parameters.Add(idParam);

                try
                {
                    command.ExecuteNonQuery();
                }
                catch
                {
                    //error
                }
            }
        }

        public List<Common.Employee> GetFullEmployee()
        {
            List<Common.Employee> workers = new List<Common.Employee>();
            string sqlExpression = "SummaryInfo";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Common.Employee worker = new Common.Employee();
                        worker.Email = reader.GetString(0);
                        worker.Name = reader.GetString(1);
                        worker.MidName = reader.GetString(2);
                        worker.LastName = reader.GetString(3);
                        worker.Department = reader.GetString(4);
                        worker.DepPhone = reader.GetString(5);
                        worker.DepAdress = reader.GetString(6);
                        worker.DepDescription = reader.GetString(7);
                        worker.Phone = reader.GetString(8);
                        worker.Adress = reader.GetString(9);
                        worker.Status = reader.GetString(10);
                        worker.Photo = (byte[])reader.GetValue(11);
                        worker.WorkPeriod = reader.GetString(12);
                        worker.MaritalStatus = reader.GetString(13);
                        worker.Id = reader.GetInt32(14);
                        workers.Add(worker);
                    }
                }
                reader.Close();
                connection.Close();
            }
            return workers;
        }

        public void DeleteEmployee(string mail)
        {
            string sqlExpression = "DeleteEmployeeEmail";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter emailParam = new SqlParameter
                {
                    ParameterName = "@email",
                    Value = mail
                };
                command.Parameters.Add(emailParam);

                command.ExecuteNonQuery();
            }
        }

        public List<Common.Employee> GetNameSelect(string name)
        {
            List<Common.Employee> workers = new List<Common.Employee>();

            string sqlExpression = "NameSelect";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter nameParam = new SqlParameter
                {
                    ParameterName = "@Name",
                    Value = name
                };
                command.Parameters.Add(nameParam);


                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        Common.Employee worker = new Common.Employee();
                        worker.Email = reader.GetString(0);
                        worker.Name = reader.GetString(1);
                        worker.MidName = reader.GetString(2);
                        worker.LastName = reader.GetString(3);
                        worker.Department = reader.GetString(4);
                        worker.DepPhone = reader.GetString(5);
                        worker.DepAdress = reader.GetString(6);
                        worker.DepDescription = reader.GetString(7);
                        worker.Phone = reader.GetString(8);
                        worker.Adress = reader.GetString(9);
                        worker.Status = reader.GetString(10);
                        worker.Photo = (byte[])reader.GetValue(11);
                        worker.WorkPeriod = reader.GetString(12);
                        worker.MaritalStatus = reader.GetString(13);
                        worker.Id = reader.GetInt32(14);
                        workers.Add(worker);
                    }
                }
                reader.Close();
            }
            return workers;
        }

        public List<Common.Employee> GetMidNameSelect(string midName)
        {
            List<Common.Employee> workers = new List<Common.Employee>();

            string sqlExpression = "MidNameSelect";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter midNameParam = new SqlParameter
                {
                    ParameterName = "@MidName",
                    Value = midName
                };
                command.Parameters.Add(midNameParam);


                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        Common.Employee worker = new Common.Employee();
                        worker.Email = reader.GetString(0);
                        worker.Name = reader.GetString(1);
                        worker.MidName = reader.GetString(2);
                        worker.LastName = reader.GetString(3);
                        worker.Department = reader.GetString(4);
                        worker.DepPhone = reader.GetString(5);
                        worker.DepAdress = reader.GetString(6);
                        worker.DepDescription = reader.GetString(7);
                        worker.Phone = reader.GetString(8);
                        worker.Adress = reader.GetString(9);
                        worker.Status = reader.GetString(10);
                        worker.Photo = (byte[])reader.GetValue(11);
                        worker.WorkPeriod = reader.GetString(12);
                        worker.MaritalStatus = reader.GetString(13);
                        worker.Id = reader.GetInt32(14);
                        workers.Add(worker);
                    }
                }
                reader.Close();
            }
            return workers;
        }

        public List<Common.Employee> GetLastNameSelect(string lastName)
        {
            List<Common.Employee> workers = new List<Common.Employee>();

            string sqlExpression = "LastNameSelect";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter lastNameParam = new SqlParameter
                {
                    ParameterName = "@LastName",
                    Value = lastName
                };
                command.Parameters.Add(lastNameParam);


                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        Common.Employee worker = new Common.Employee();
                        worker.Email = reader.GetString(0);
                        worker.Name = reader.GetString(1);
                        worker.MidName = reader.GetString(2);
                        worker.LastName = reader.GetString(3);
                        worker.Department = reader.GetString(4);
                        worker.DepPhone = reader.GetString(5);
                        worker.DepAdress = reader.GetString(6);
                        worker.DepDescription = reader.GetString(7);
                        worker.Phone = reader.GetString(8);
                        worker.Adress = reader.GetString(9);
                        worker.Status = reader.GetString(10);
                        worker.Photo = (byte[])reader.GetValue(11);
                        worker.WorkPeriod = reader.GetString(12);
                        worker.MaritalStatus = reader.GetString(13);
                        worker.Id = reader.GetInt32(14);
                        workers.Add(worker);
                    }
                }
                reader.Close();
            }
            return workers;
        }

        public List<Common.Employee> GetDepartmentSelect(string department)
        {
            List<Common.Employee> workers = new List<Common.Employee>();

            string sqlExpression = "DepartmentSelect";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter departmentParam = new SqlParameter
                {
                    ParameterName = "@Department",
                    Value = department
                };
                command.Parameters.Add(departmentParam);


                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        Common.Employee worker = new Common.Employee();
                        worker.Email = reader.GetString(0);
                        worker.Name = reader.GetString(1);
                        worker.MidName = reader.GetString(2);
                        worker.LastName = reader.GetString(3);
                        worker.Department = reader.GetString(4);
                        worker.DepPhone = reader.GetString(5);
                        worker.DepAdress = reader.GetString(6);
                        worker.DepDescription = reader.GetString(7);
                        worker.Phone = reader.GetString(8);
                        worker.Adress = reader.GetString(9);
                        worker.Status = reader.GetString(10);
                        worker.Photo = (byte[])reader.GetValue(11);
                        worker.WorkPeriod = reader.GetString(12);
                        worker.MaritalStatus = reader.GetString(13);
                        worker.Id = reader.GetInt32(14);
                        workers.Add(worker);
                    }
                }
                reader.Close();
            }
            return workers;
        }

        public List<Common.Employee> GetStatusSelect(string status)
        {
            List<Common.Employee> workers = new List<Common.Employee>();

            string sqlExpression = "StatusSelect";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter statusParam = new SqlParameter
                {
                    ParameterName = "@Status",
                    Value = status
                };
                command.Parameters.Add(statusParam);


                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        Common.Employee worker = new Common.Employee();
                        worker.Email = reader.GetString(0);
                        worker.Name = reader.GetString(1);
                        worker.MidName = reader.GetString(2);
                        worker.LastName = reader.GetString(3);
                        worker.Department = reader.GetString(4);
                        worker.DepPhone = reader.GetString(5);
                        worker.DepAdress = reader.GetString(6);
                        worker.DepDescription = reader.GetString(7);
                        worker.Phone = reader.GetString(8);
                        worker.Adress = reader.GetString(9);
                        worker.Status = reader.GetString(10);
                        worker.Photo = (byte[])reader.GetValue(11);
                        worker.WorkPeriod = reader.GetString(12);
                        worker.MaritalStatus = reader.GetString(13);
                        worker.Id = reader.GetInt32(14);
                        workers.Add(worker);
                    }
                }
                reader.Close();
            }
            return workers;
        }

        public Common.Employee GetEmailSelect(string email)
        {
            Common.Employee worker = new Common.Employee();

            string sqlExpression = "EmailSelect";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {                
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter emailParam = new SqlParameter
                {
                    ParameterName = "@Email",
                    Value = email
                };
                command.Parameters.Add(emailParam);


                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        worker.Email = reader.GetString(0);
                        worker.Name = reader.GetString(1);
                        worker.MidName = reader.GetString(2);
                        worker.LastName = reader.GetString(3);
                        worker.Department = reader.GetString(4);
                        worker.DepPhone = reader.GetString(5);
                        worker.DepAdress = reader.GetString(6);
                        worker.DepDescription = reader.GetString(7);
                        worker.Phone = reader.GetString(8);
                        worker.Adress = reader.GetString(9);
                        worker.Status = reader.GetString(10);
                        worker.Photo = (byte[])reader.GetValue(11);
                        worker.WorkPeriod = reader.GetString(12);
                        worker.MaritalStatus = reader.GetString(13);
                        worker.Id = reader.GetInt32(14);
                    }
                }
                reader.Close();
            }
            return worker;
        }
    }
}
