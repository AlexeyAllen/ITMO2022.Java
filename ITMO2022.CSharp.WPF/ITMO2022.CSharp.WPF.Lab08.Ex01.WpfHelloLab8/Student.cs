using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;
using System.Globalization;


namespace ITMO2022.CSharp.WPF.Lab01.Ex01.WpfHello
{
    public class Student
    {
        public string StudentName { get; set; }
        public bool IsEnrolled { get; set; }

        public Student(string name, bool ch)
        {
            StudentName = name;
            IsEnrolled = ch;
        }

        public string FullStudentData
        {
            get { return StudentName + "\t" + IsEnrolled; }
        }
    }

    public class StudentList : ObservableCollection<Student>
    {
        public StudentList()
        {
            Add(new Student("Lorin Kanev", true));
            Add(new Student("Ivan Petrov", true));
            Add(new Student("Sergey Masov", false));
            Add(new Student("Tais Frolova", true));
            Add(new Student("Elena Diva", false));
        }
    }

    [ValueConversion(typeof(bool), typeof(Brush))]
    public class BoolToBrushConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter,
       CultureInfo culture)
        {
            Brush b = null;
            if (value != null &&
            value.GetType() == typeof(bool))
            {
                b = (bool)value ? Brushes.Green : Brushes.Red;
            }
            return b;
        }
        public object ConvertBack(object value, Type targetType, object
       parameter, CultureInfo culture)
        {
            return null;
        }
    }

}
