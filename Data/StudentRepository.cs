using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TP4.Models;
using TP4.Models.Data;

namespace TP4.Data
{
    public class StudentRepository
    {
        private readonly UniversityContext context;

        public StudentRepository()
        {
            this.context = UniversityContext.Context;
        }

        public Student Get(int id)
        {
            return context.Student.Find(id);
        }

        public IEnumerable<Student> GetAll()
        {
            return context.Student.ToList();
        }

        public bool AddStudent(Student s)
        {
            try
            {
                context.Student.Add(s);
                return true;

            }catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<string> GetAllCourses()
        {
            return context.Student.Select(s => s.course).Distinct().ToList();
        }

        public IEnumerable<Student> GetStudentsByCourse(string course)
        {
            List<Student> students = new List<Student>();
            try
            {
                students = context.Student.Where(s => s.course.ToLower() == course.ToLower()).ToList();
            } catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
            }
            return students;
        }
    }
}
