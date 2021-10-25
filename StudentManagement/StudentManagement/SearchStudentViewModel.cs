using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Input;

namespace StudentManagement
{
    public class SearchStudentViewModel : BaseViewModel
    {
        private string m_searchKeyword;
        public string SearchKeyword
        {
            get => m_searchKeyword;
            set
            {
                m_searchKeyword = value;
                OnPropertyChanged(nameof(SearchKeyword));
            }
        }
        private string m_selectedClass;
        public string SelectedClass
        {
            get => m_selectedClass;
            set
            {
                m_selectedClass = value;
                OnPropertyChanged(nameof(SelectedClass));
            }
        }
        private Student m_selectedStudent;
        public Student SelectedStudent
        {
            get => m_selectedStudent;
            set
            {
                m_selectedStudent = value;
                OnPropertyChanged(nameof(SelectedStudent));
            }
        }
        public ObservableCollection<Student> Students { get; set; }
        public ICommand SearchCommand { get; set; }
        public ICommand ResetCommand { get; set; }
        public ICommand OpenDetailCommand { get; set; }

        private IStudentService m_studentSv;

        public SearchStudentViewModel()
        {
            m_studentSv = new StudentServiceWithFile();
            Students = new ObservableCollection<Student>(m_studentSv.SearchStudent(string.Empty, string.Empty));
            OpenDetailCommand = new ConditionalCommand(x => DoOpenDetail());
            SearchCommand = new ConditionalCommand(x => DoSearch());
            ResetCommand = new ConditionalCommand(x => DoReset());
        }

        private void DoSearch()
        {
            Students.Clear();
            var result = m_studentSv.SearchStudent(SearchKeyword, SelectedClass);
            foreach (var s in result)
            {
                Students.Add(s);
            }
        }

        private void DoReset()
        {
            SearchKeyword = null;
            SelectedClass = null;
        }

        public void DoOpenDetail()
        {
            var studentDetailViewModel = new StudentDetailViewModel(m_studentSv, SelectedStudent.studentId);
            StudentDetailWindow studentDetail = new StudentDetailWindow(studentDetailViewModel);
            studentDetail.DataContext = studentDetailViewModel;
            studentDetail.ShowDialog();
        }
    }
}
