using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace StudentManagement
{
    public class StudentServiceWithFile : IStudentService
    {
        private IList<Student> m_student;
        public StudentServiceWithFile()
        {
            var data = File.ReadAllText("Student_Data.json");
            m_student = JsonSerializer.Deserialize<List<Student>>(data);
        }
        public void DeleteStudentById(int id)
        {
            var deletedStudent = LoadStudentById(id);
            if (deletedStudent != null)
            {
                m_student.Remove(deletedStudent);
            }
        }
        public Student LoadStudentById(long id)
        {
            return m_student.FirstOrDefault(x => x.studentId == id);
        }

        public IList<Student> SearchStudent(string keyword, string hutechClass)
        {
            var result = m_student.Where(s => (s.Class == hutechClass || string.IsNullOrEmpty(hutechClass)) && (s.firstname == keyword || s.lastname == keyword || string.IsNullOrEmpty(keyword))).OrderBy(s => s.firstname).ToList();
            foreach (var s in result)
            {
                Console.WriteLine(s);
            }
            return result;
        }
        public void UpdateOrCreateStudent(Student student)
        {
            if (student.studentId > 0)
            {
                var updateStudent = LoadStudentById(student.studentId);
                updateStudent.lastname = student.lastname;
                updateStudent.firstname = student.firstname;
                updateStudent.Class = student.Class;
                updateStudent.email = student.email;
                updateStudent.gender = student.gender;
                updateStudent.studentId = student.studentId;
            }
            else
            {
                var newStudentId = m_student.Select(s => s.studentId).OrderByDescending(s => s).FirstOrDefault();
                student.studentId = newStudentId + 1;
                m_student.Add(student);
            }
        }
    }
}
