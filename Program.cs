using System;

namespace Lesson17
{
    class Program
    {
        class User
        {
            private int age;
            public string? FirstName { get; set; }
            public string? LastName { get; set; }
            public int Age
            {
                get {return age;}
                set
                {
                    if(value < 0 || value > 120)
                    {
                        throw new ArgumentException("Возраст долджен быть больше 0 и меньше 120");
                    }
                    age = value;
                }
            }

            public string? Email { get; set; }
            public string? Password { get; set; }
            public User(string? firstName, string? lastName, int age, string? email, string? password)
            {
                FirstName = firstName;
                LastName = lastName;
                Age = age;
                Email = email;
                Password = password;
            }
        }
        static void Main(string[] args)
        {
            List<User> users = new List<User>
            {
                new User("Bob", "Castl", 18, "bob@gmail.com", "123abc"),
                new User("Axl", "Baiden", 24, "axl@gmail.com", "1234abcd"),
                new User("Michael", "Robby", 25, "michael@gmail.com", "12ab"),
                new User("Sergey", "Lazerev", 19, "sergey@gmail.com", "abc123"),
                new User("Lorisa", "Zvereva", 20, "larisa@gmail.com", "1234abcd"),
                new User("Dmitry", "Castl", 26, "dmitry@gmail.com", "1235abc"),
            };

            // //Задание 1
            // var UserBig = users.Where(u => u.Age > 20);
            // Console.WriteLine("Пользователи которым больше 20 лет:");
            // foreach(var i in UserBig)
            // {
            //     Console.WriteLine($"Имя: {i.FirstName}, Фамилия: {i.LastName}, Возраст: {i.Age}, Email: {i.Email}");
            // }

            //Задание 2
            var OrderByFirstName = users.OrderBy(u => u.FirstName);
            Console.WriteLine("Отсортированные пользователи по имени:");
            foreach(var i in OrderByFirstName)
            {
                Console.WriteLine($"Имя: {i.FirstName}, Фамилия: {i.LastName}, Возраст: {i.Age}, Email: {i.Email}");
            }

            var OrderByLasstName = users.OrderBy(u => u.LastName);
            Console.WriteLine("Отсортированные пользователи по фамилии:");
            foreach(var i in OrderByLasstName)
            {
                Console.WriteLine($"Имя: {i.FirstName}, Фамилия: {i.LastName}, Возраст: {i.Age}, Email: {i.Email}");
            }
        }
    }
}