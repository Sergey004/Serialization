using System;

namespace Serialization
{
    [Serializable]
    public class Student
    {
        public string Name { get; }
        public int  Age { get; }

        public Group Group { get; set; }

        public Student(string name, int age)
        {
            // Проверка входных парамитров

            Name = name;
            Age = age;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
