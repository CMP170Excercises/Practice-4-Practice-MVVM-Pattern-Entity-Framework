using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    public interface   IStudentService
    {
        IList<Student> SearchStudent(string keyword, string hutechClass);
        Student LoadStudentById(long id);
        void UpdateOrCreateStudent(Student student);
        void DeleteStudentById(int id);
    }
}
