using System;

namespace USF_Library_Management
{
    public class Student : Person
    {
        private string _major;
        private int _gradYear;

        public Student(string name, string email, string id, string major, int gradYear)
            : base(name, email, id)
        {
            _major = major;
            _gradYear = gradYear;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
        }
    }
}
