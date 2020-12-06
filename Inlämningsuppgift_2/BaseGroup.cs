using System;
using System.Collections.Generic;

namespace Inlämningsuppgift_2
{
    class BaseGroup
    {
        private List<Person> Group = new List<Person>();

        public BaseGroup() { }
        public BaseGroup(string name)
        {
            this.Name = name;
        }
        public string Name { get; }

        /// <summary>
        /// Add person to the Group
        /// </summary>
        /// <param name="person">person is a Person object</param>
        public void AddPerson(Person person) => Group.Add(person);

        /// <summary>
        /// Remove person from the Group 
        /// </summary>
        /// <param name="person">person is a Person object</param>
        public void RemovePerson(Person person) => Group.Remove(person);

        /// <summary>
        /// Find a person by name
        /// </summary>
        /// <param name="name">Name - name of the person</param>
        /// <returns>Person object if the person exists. Otherwise, returns null</returns>
        public Person FindPerson(string name)
        {
            foreach (Person person in Group)
            {
                if (person.Name.ToLower() == name) return person;
            }
            return null;
        }

        /// <summary>
        /// Print every person name from the Group
        /// </summary>
        public void PrintGroup()
        {
            Console.Clear();
            Console.WriteLine($"[{Name}]");
            Console.WriteLine("Här är våran basgrupp:");
            Console.WriteLine("----------------------");
            int i = 1; // index
            foreach (Person p in Group)
            {
                Console.WriteLine($"{i}. {p.Name},");
                // increase the index by 1 after each iteration
                i++;
            }
            Console.WriteLine();
            Console.WriteLine("[OBS]: Några av oss känns inte super bekvämt med info upp på GitHub (som fullt namn).");
        }
    }
}