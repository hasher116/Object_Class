using System;

namespace Object_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            string b = x.ToString(); // ToString для базовых типов данных
            Console.WriteLine(b);

            Person person = new Person("Vasya");
            Person person2 = new Person("Andrei");
            Person person3 = new Person("Vasya");
            Console.WriteLine(person.ToString()); // переопределили метод
            Console.WriteLine(person.GetHashCode()); // одинаковый код с person3 т.к переопределили по имени
            Console.WriteLine(person2.GetHashCode());
            Console.WriteLine(person3.GetHashCode());
            Console.WriteLine("\n");

            Clock clock = new Clock(06, 23, 15);
            Clock clock2 = new Clock(06, 23, 15);
            string f = clock.ToString(); // переопределили метод
            Console.WriteLine(f);
            Console.WriteLine(clock.GetHashCode());

            Console.WriteLine("\n" + clock.GetType()); // возвращает тип объекта. не переопределяется
            Console.WriteLine(typeof(Clock));

            object n = true;
            Console.WriteLine(n.GetType());

            int z = 34;
            double y = 34;
            Console.WriteLine(z.Equals(y)); // Надо переопределять и сравнивать по свойствам, иначе хз зачем он

        }
    }
}
