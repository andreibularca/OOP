using System;

namespace OOP.Encapsulation
{
    public class Employee
    {
        private int _age;
        private string _name;

        public Employee()
        {
            Id = new Random().Next(1, 100);
        }

        public int Id { get; private set; }
        
        public void SetName(string name)
        {
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetAge(int age)
        {
            _age = age;
        }

        public int GetAge()
        {
            return _age;
        }
    }
}
