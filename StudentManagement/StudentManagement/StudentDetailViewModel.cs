using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using static StudentManagement.SearchStudentViewModel;
using System.Windows.Input;

namespace StudentManagement
{
    class StudentDetailViewModel : BaseViewModel,ICloseable
    {
        private bool ismale;
        private int IdDetail;
        private string firstnameDetail;
        private string lastnameDetail;
        private string genderDetail;
        private string classDetail;
        private string emailDetail;
        private decimal gpaDetail1;
        private readonly IStudentService m_studentService;

        public int StudentIdDetail
        {
            get => IdDetail; set
            {
                IdDetail = value;
                OnPropertyChanged(nameof(IdDetail));
            }
        }
        public String FirstnameDetail
        {
            get => firstnameDetail; set
            {
                firstnameDetail = value;
                OnPropertyChanged(nameof(firstnameDetail));
            }
        }
        public String LastnameDetail
        {
            get => lastnameDetail; set
            {
                lastnameDetail = value;
                OnPropertyChanged(nameof(lastnameDetail));
            }
        }
        public String GenderDetail
        {
            get => genderDetail; set => genderDetail = value;
        }
        public String ClassDetail
        {
            get => classDetail; set
            {
                classDetail = value;
                OnPropertyChanged(nameof(classDetail));
            }
        }
        public String EmailDetail
        {
            get => emailDetail; set
            {
                emailDetail = value;
                OnPropertyChanged(nameof(emailDetail));
            }
        }
        public decimal gpaDetail
        {
            get => gpaDetail1; set
            {
                gpaDetail1 = value;
                OnPropertyChanged(nameof(gpaDetail));
            }
        }

        public Boolean isMale
        {
            get => ismale; set
            {
                ismale = value;
                OnPropertyChanged(nameof(isMale));
            }
        }
        public Boolean isFemale
        {
            get => !ismale; set
            {
                ismale = !value;
                OnPropertyChanged(nameof(isFemale));
            }
        }

        public ICommand SaveCommand { get; set; }
        public ICommand CancelCommand { get; set; }
        public StudentDetailViewModel(IStudentService studentService, int studentId)
        {
            m_studentService = studentService;
            m_student = m_studentService.LoadStudentById(studentId);
            StudentIdDetail = m_student.studentId;
            FirstnameDetail = m_student.firstname;
            LastnameDetail = m_student.lastname;
            GenderDetail = m_student.gender;
            ClassDetail = m_student.Class;
            EmailDetail = m_student.email;
            gpaDetail = m_student.gpa;
            isMale = (GenderDetail == "Male");
            SaveCommand = new ConditionalCommand(x => DoSave());
            CancelCommand = new ConditionalCommand(x => DoCancel());

        }
        public event EventHandler CloseRequest;
        private void DoCancel()
        {
            var handler = CloseRequest;
            if (handler != null) handler(this, EventArgs.Empty);
        }
        Student m_student;
        private void DoSave()
        {
            m_student.studentId = StudentIdDetail;
            m_student.firstname = FirstnameDetail;
            m_student.lastname = LastnameDetail;
            m_student.gender = GenderDetail;
            m_student.Class = ClassDetail;
            m_student.email = EmailDetail;
            m_studentService.UpdateOrCreateStudent(m_student);
        }
    }
}