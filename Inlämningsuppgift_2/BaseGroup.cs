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

    public void AddPerson(Person person) => Group.Add(person);
    public void RemovePerson(Person person) => Group.Remove(person);

    // Find a person by name
    // If exist => return person
    // Otherwise, return null
    public Person FindPerson(string name)
    {
      foreach (Person person in Group)
      {
        if (person.Name.ToLower() == name) return person;
      }
      return null;
    }

    // print every person name from the group list  
    public void PrintGroup()
    {
      Console.Clear();
      Console.WriteLine($"[{Name}]");
      Console.WriteLine("Här är våran basgrupp:");
      Console.WriteLine("----------------------");
      // index
      int i = 1;
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