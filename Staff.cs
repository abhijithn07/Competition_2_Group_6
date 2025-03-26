namespace USF_Library_Management
{
    public class Staff : Person
    {
        private string _position;
        private string _department;

        public Staff(string name, string email, string id, string position, string department)
            : base(name, email, id)
        {
            _position = position;
            _department = department;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
        }
    }
}
