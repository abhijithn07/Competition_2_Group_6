using System;

namespace USF_Library_Management
{
    public class Person
    {
        protected string _name;
        protected string _email;
        protected string _id;

        public Person(string name, string email, string id)
        {
            _name = name;
            _email = email;
            _id = id;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {_name}, ID: {_id}");
        }

        public string GetName() => _name;
    }
}