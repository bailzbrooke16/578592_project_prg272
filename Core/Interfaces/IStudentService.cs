using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IStudentService
    {
        public List<Student> getAllStudents();
        public Student? getStudent(int id);
        public Student createStudent(Student student);
        public Student updateStudent (Student student);
        public void deleteStudent (int id);
        public void linkModule(int id , int moduleId);
    }
}
