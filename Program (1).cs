using System;

namespace Globaldatafeed_Exercise_1
{
    
        class Program
        {
            static void Main(string[] args)
            {
                var person1 = new Person("Yogesh", "Jadhav", "yogeshjadhav@gmail.com", new DateTime(1990, 2, 23));
                Console.WriteLine(person1.Adult);  
                Console.WriteLine(person1.Birthday);  

                var person2 = new Person("Arjun", "More", "arjunmore@gmail.com");
                Console.WriteLine(person2.Adult);  
                Console.WriteLine(person2.Birthday);  

                var person3 = new Person("Sai", "Mane", new DateTime(2005, 6, 5));
                Console.WriteLine(person3.Adult);  
                Console.WriteLine(person3.Birthday);  
            }
        }


        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public DateTime DateOfBirth { get; set; }

            public bool Adult => CalculateAge() >= 18;
            public bool Birthday => DateTime.Now.Date == DateOfBirth.Date;

            public Person(string firstName, string lastName, string email, DateTime dateOfBirth)
            {
                FirstName = firstName;
                LastName = lastName;
                Email = email;
                DateOfBirth = dateOfBirth;
            }

            public Person(string firstName, string lastName, string email) : this(firstName, lastName, email, DateTime.MinValue)
            {
            }

            public Person(string firstName, string lastName, DateTime dateOfBirth) : this(firstName, lastName, "", dateOfBirth)
            {
            }

            private int CalculateAge()
            {
                var today = DateTime.Today;
                var age = today.Year - DateOfBirth.Year;
                if (DateOfBirth > today.AddYears(-age))
                    age--;
                return age;
            }
        }

    
}
