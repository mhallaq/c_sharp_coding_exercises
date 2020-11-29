using System;

namespace TechReturners.Exercises
{
    public class Person
    {
        public string firstName;
        public string lastName;
        public string city;
        public int age;

        public Person( string firstName, string lastName, string city, int age)
        {
             this.firstName=firstName;
             this.lastName=lastName;
             this.city=city;
             this.age=age;
        }
    }

    public class Exercise002
    {
        public static bool IsFromManchester( Person person ) 
        {
            return person.city.ToLower() == "manchester";
            throw new NotImplementedException();
        }

        public static bool CanWatchFilm(Person person, int ageLimit) 
        {
            return person.age >= ageLimit;
            throw new NotImplementedException();
        }
    }
}
