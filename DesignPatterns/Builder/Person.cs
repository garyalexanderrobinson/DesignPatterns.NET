using System;
namespace DesignPatterns
{
    public class Person
    {
        // Thread-safe and immutable with lack of setters/getters
        readonly int age;
        readonly string firstName;
        readonly string lastName;

        public Person(int age, string firstName, string lastName)
        {
            this.age = age;
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }
}
