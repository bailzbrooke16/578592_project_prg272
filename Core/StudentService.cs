using Core.Interfaces;
using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class StudentService : IStudentService
    {
        private readonly DataAccess _dataAccess;
        public StudentService() { 
            _dataAccess = new DataAccess();
        }
        public Student createStudent(Student student)
        {
            return _dataAccess.createStudent(student);
        }

        public void deleteStudent(int id)
        {
            _dataAccess.deleteStudent(id);
        }

        public List<Student> getAllStudents()
        {
            return _dataAccess.getStudents();
        }

        public Student? getStudent(int id)
        {
            Student student = _dataAccess.getStudent(id);
            if(student == null)
            {
                return null;
            }
            else
            {
                return student;
            }
        }

        public void linkModule(int id, int moduleId)
        {
            throw new NotImplementedException();
        }

        public Student updateStudent(Student student)
        {
            return _dataAccess.updateStudent(student);
        }
    }
}
