using System;
using System.Collections.Generic;
using System.Linq;

class Person
{
    public string Name { get; set; }
    public string ID { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main()
    {
        List<Person> people = new List<Person>();

        string input;

        while ((input = Console.ReadLine()) != "End")
        {
            string[] personInfo = input.Split(' ');

            string name = personInfo[0];
            string id = personInfo[1];
            int age = int.Parse(personInfo[2]);

            Person person = new Person()
            {
                Name = name,
                ID = id,
                Age = age
            };

            Person existingPerson = people.FirstOrDefault(p => p.ID == id);

            if (existingPerson != null)
            {
                existingPerson.Name = name;
                existingPerson.Age = age;
            }
            else
            {
                people.Add(person);
            }
        }

        people = people.OrderBy(p => p.Age).ToList();

        foreach (Person person in people)
        {
            Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
        }
    }
}
