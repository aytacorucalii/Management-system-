
using System;

namespace LibraryManagementSystem.Models
{
    public abstract class Person
    {
        public int Id { get; set; }
        private static int NextId = 1;
        public string Name { get; private set; }

        public Person(string name)
        {
            Name = name;
            Id = NextId++;
        }
    }
}
