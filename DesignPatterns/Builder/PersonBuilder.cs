using System;
namespace DesignPatterns.Builder
{
    public class PersonBuilder : IBuilder<Person>
    {
        private int age;
        private string firstName;
        private string lastName;

        public PersonBuilder SetAge(int value)
        {
            age = value;
            return this;
        }

        public PersonBuilder SetFirstName(string value)
        {
            firstName = value;
			return this;
        }

        public PersonBuilder SetLastName(string value)
        {
			lastName = value;
			return this;
        }

        public Person Build()
        {
            return new Person(age, firstName, lastName);
        }
    }
}
