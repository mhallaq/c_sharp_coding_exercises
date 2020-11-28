using System;

namespace TechReturners.Exercises
{
    public class Person
    {
        public string firstName;
        public string lastName;
        public string city;
        public int age;

        public Person( string v1, string v2, string v3, int v4)
        {
             this.firstName=v1;
             this.lastName=v2;
             this.city=v3;
             this.age=v4;
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
