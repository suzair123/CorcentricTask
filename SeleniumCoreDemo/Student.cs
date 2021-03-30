using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumCoreDemo
{
    class Student
    {
        private string _firstName;
        private string _lastName;
        private string _mobile;

        public static Student Create(string firstName, string lastName, string mobile) => new Student(firstName, lastName, mobile);

        private Student(string firstName,
                        string lastName,
                        string mobile)
        {
            _firstName = firstName;
            _lastName = lastName;
            _mobile = mobile;
        }
        public string FirstName => _firstName;
        public string LastName => _lastName;
        public string MobileNum => _mobile;
    }
}
