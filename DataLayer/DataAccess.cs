using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DataAccess
    {
        private readonly string connectionString = "Server=localhost;Database=student_manager;Trusted_Connection=True;"
            + "Integrated Security=true";
        public List<Student> getStudents()
        {
            List<Student> students = new List<Student>();

            string query = "SELECT [number], [first_name], [last_name], [phone], [gender], [address], [DOB], [image] FROM [dbo].[student]";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Student student = new Student
                            {
                                number = reader.GetInt32(0),
                                first_name = reader.GetString(1),
                                last_name = reader.GetString(2),
                                phone = reader.IsDBNull(3) ? null : reader.GetString(3),
                                gender = reader.IsDBNull(4) ? null : reader.GetString(4),
                                address = reader.IsDBNull(5) ? null : reader.GetString(5),
                                DOB = reader.IsDBNull(6) ? default : DateOnly.FromDateTime(reader.GetDateTime(6)),
                                image = reader.IsDBNull(7) ? null : (byte[])reader["image"]
                            };

                            students.Add(student);
                        }
                    }
                }
            }

            return students;
        }

        public void deleteStudent(int id)
        {
            string query = "DELETE FROM [dbo].[student] WHERE [number] = @Number";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Number", id);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                }
            }
        }

        public Student? getStudent(int id)
        {
            string query = "SELECT [number], [first_name], [last_name], [phone], [gender], [address], [DOB], [image] FROM [dbo].[student] WHERE [number] = @Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Student
                            {
                                number = reader.GetInt32(0),
                                first_name = reader.GetString(1),
                                last_name = reader.GetString(2),
                                phone = reader.IsDBNull(3) ? null : reader.GetString(3),
                                gender = reader.IsDBNull(4) ? null : reader.GetString(4),
                                address = reader.IsDBNull(5) ? null : reader.GetString(5),
                                DOB = reader.IsDBNull(6) ? default : DateOnly.FromDateTime(reader.GetDateTime(6)),
                                image = reader.IsDBNull(7) ? null : (byte[])reader["image"]
                            };
                        }
                        else
                        {
                            return null; // Return null if no matching student is found
                        }
                    }
                }
            }
        }

        public Student createStudent(Student student)
        {
            string query = @"
        INSERT INTO [dbo].[student] 
        ([number], [first_name], [last_name], [phone], [gender], [address], [DOB], [image]) 
        VALUES (@Number, @FirstName, @LastName, @Phone, @Gender, @Address, @DOB, @Image)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to prevent SQL injection
                    command.Parameters.AddWithValue("@Number", student.number);
                    command.Parameters.AddWithValue("@FirstName", student.first_name);
                    command.Parameters.AddWithValue("@LastName", student.last_name);
                    command.Parameters.AddWithValue("@Phone", string.IsNullOrEmpty(student.phone) ? (object)DBNull.Value : student.phone);
                    command.Parameters.AddWithValue("@Gender", string.IsNullOrEmpty(student.gender) ? (object)DBNull.Value : student.gender);
                    command.Parameters.AddWithValue("@Address", string.IsNullOrEmpty(student.address) ? (object)DBNull.Value : student.address);
                    command.Parameters.AddWithValue("@DOB", student.DOB == default ? (object)DBNull.Value : student.DOB.ToDateTime(new TimeOnly(0, 0)));
                    command.Parameters.AddWithValue("@Image", student.image ?? (object)DBNull.Value);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

            return student;
        }

        public Student updateStudent(Student student)
        {
            string query = @"
        UPDATE [dbo].[student]
        SET 
            [first_name] = @FirstName,
            [last_name] = @LastName,
            [phone] = @Phone,
            [gender] = @Gender,
            [address] = @Address,
            [DOB] = @DOB,
            [image] = @Image
        WHERE 
            [number] = @Number";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to prevent SQL injection
                    command.Parameters.AddWithValue("@Number", student.number);
                    command.Parameters.AddWithValue("@FirstName", student.first_name);
                    command.Parameters.AddWithValue("@LastName", student.last_name);
                    command.Parameters.AddWithValue("@Phone", string.IsNullOrEmpty(student.phone) ? (object)DBNull.Value : student.phone);
                    command.Parameters.AddWithValue("@Gender", string.IsNullOrEmpty(student.gender) ? (object)DBNull.Value : student.gender);
                    command.Parameters.AddWithValue("@Address", string.IsNullOrEmpty(student.address) ? (object)DBNull.Value : student.address);
                    command.Parameters.AddWithValue("@DOB", student.DOB == default ? (object)DBNull.Value : student.DOB.ToDateTime(new TimeOnly(0, 0)));
                    command.Parameters.AddWithValue("@Image", student.image ?? (object)DBNull.Value);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        throw new Exception("No student found with the specified ID.");
                    }
                }
            }

            return student;
        }

        public List<Module> getAllModules()
        {
            List<Module> modules = new List<Module>();

            string query = "SELECT [code], [name], [description], [links] FROM [dbo].[module]";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Module module = new Module
                            {
                                code = reader.GetInt32(0),
                                name = reader.IsDBNull(1) ? null : reader.GetString(1),
                                description = reader.IsDBNull(2) ? null : reader.GetString(2),
                                links = reader.IsDBNull(3) ? null : reader.GetString(3)
                            };

                            modules.Add(module);
                        }
                    }
                }
            }

            return modules;
        }

        public Module? getModule(int moduleId)
        {
            string query = "SELECT [code], [name], [description], [links] FROM [dbo].[module] WHERE [code] = @code";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@code", moduleId);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Module
                            {
                                code = reader.GetInt32(0),
                                name = reader.IsDBNull(1) ? null : reader.GetString(1),
                                description = reader.IsDBNull(2) ? null : reader.GetString(2),
                                links = reader.IsDBNull(3) ? null : reader.GetString(3)
                            };
                        }
                        else
                        {
                            return null; // Return null if no matching module is found
                        }
                    }
                }
            }
        }

        public Module updateModule(Module module)
        {
            string query = @"
        UPDATE [dbo].[module]
        SET 
            [name] = @Name,
            [description] = @Description,
            [links] = @Links
        WHERE 
            [code] = @Code";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Code", module.code);
                    command.Parameters.AddWithValue("@Name", string.IsNullOrEmpty(module.name) ? (object)DBNull.Value : module.name);
                    command.Parameters.AddWithValue("@Description", string.IsNullOrEmpty(module.description) ? (object)DBNull.Value : module.description);
                    command.Parameters.AddWithValue("@Links", string.IsNullOrEmpty(module.links) ? (object)DBNull.Value : module.links);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        throw new Exception("No module found with the specified ID.");
                    }
                }
            }

            return module;
        }

        public void deleteModule(int moduleId)
        {
            string query = "DELETE FROM [dbo].[module] WHERE [code] = @code";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@code", moduleId);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        throw new Exception("No module found with the specified ID.");
                    }
                }
            }
        }

        public Module createModule(Module module)
        {
            string query = @"
        INSERT INTO [dbo].[module] 
        ([code], [name], [description], [links]) 
        VALUES (@Code, @Name, @Description, @Links)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Code", module.code);
                    command.Parameters.AddWithValue("@Name", string.IsNullOrEmpty(module.name) ? (object)DBNull.Value : module.name);
                    command.Parameters.AddWithValue("@Description", string.IsNullOrEmpty(module.description) ? (object)DBNull.Value : module.description);
                    command.Parameters.AddWithValue("@Links", string.IsNullOrEmpty(module.links) ? (object)DBNull.Value : module.links);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

            return module;
        }

        public List<LinkModule> getLinkedModules(int studentNumber)
        {
            List<LinkModule> linkedModules = new List<LinkModule>();

            string query = "SELECT [linkId], [moduleId], [studentNumber] FROM [dbo].[moduleLinks] WHERE [studentNumber] = @StudentNumber";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add the parameter to the SQL command
                    command.Parameters.AddWithValue("@StudentNumber", studentNumber);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            LinkModule linkModule = new LinkModule
                            {
                                linkId = reader.GetInt32(0),
                                moduleId = reader.GetInt32(1),
                                studentNumber = reader.GetInt32(2)
                            };

                            linkedModules.Add(linkModule);
                        }
                    }
                }
            }

            return linkedModules;
        }

        public void addLinkModule(LinkModule linkModule)
        {
            string query = @"
        INSERT INTO [dbo].[moduleLinks] 
        ([linkId], [moduleId], [studentNumber]) 
        VALUES (@LinkId, @ModuleId, @StudentNumber)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LinkId", linkModule.linkId);
                    command.Parameters.AddWithValue("@ModuleId", linkModule.moduleId);
                    command.Parameters.AddWithValue("@StudentNumber", linkModule.studentNumber);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        public void removeLinkModule(LinkModule linkModule)
        {
            string query = "DELETE FROM [dbo].[moduleLinks] WHERE [linkId] = @LinkId AND [moduleId] = @ModuleId AND [studentNumber] = @StudentNumber";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LinkId", linkModule.linkId);
                    command.Parameters.AddWithValue("@ModuleId", linkModule.moduleId);
                    command.Parameters.AddWithValue("@StudentNumber", linkModule.studentNumber);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }




    }
}
