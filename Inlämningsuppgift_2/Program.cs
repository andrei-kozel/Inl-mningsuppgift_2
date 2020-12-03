using System;
using System.Collections.Generic;

namespace Inlämningsuppgift_2
{
  class Program
  {
    private const string password = "götebuggarna";
    private static List<Person> group = new List<Person>();

    // Main method
    static void Main(string[] args)
    {
      // Welcome user and ask to enter a password
      Console.WriteLine("Välkommen!");
      Console.Write("Ange ditt lösenord: ");
      string pw = Console.ReadLine().ToLower();

      // check the password. If the password is correct - run the app
      if (CheckPassword(pw))
      {
        CreateGroup();
        RunApp();
      }
      else Console.WriteLine("Fel lösenord!");
    }

    private static void RunApp()
    {
      PrintGroup();
      // Asking the user to enter the name of the person to show more info
      // Or enter q to exit
      Console.WriteLine("[q] - Stänga");
      Console.Write("Vaisa mer info (skriv 'Namn E'): ");
      string name = Console.ReadLine().ToLower();
      if (name == "q") CloseApp();
      Person person = FindPerson(name);
      // If the person is null - ask the user again and again.
      while (person == null)
      {
        System.Console.WriteLine("Jag har inte hittat någon :(");
        System.Console.Write("Prova en gång till. Skriv tex 'Andrei K': ");
        name = Console.ReadLine().ToLower();
        person = FindPerson(name);
        if (name == "q") CloseApp();
      }
      person.Describe();

      // Ask the user what he wants to do with this information
      // 1 - go back
      // 2 - delete perosn from the list 
      // 3 - exit
      Console.WriteLine("[1]-Tillbaka, [2]-Ta Bort Person, [q]-Quite");
      Console.Write("Vad vill du göra? ");
      string choice = Console.ReadLine();
      HandleInput(choice, person);
    }

    private static void HandleInput(string input, Person person = null)
    {
      switch (input)
      {
        case "1":
          RunApp();
          break;
        case "2":
          DeletePerson(person);
          RunApp();
          break;
        case "q":
          CloseApp();
          break;
      }
    }

    private static Person FindPerson(string name)
    {
      // check every person
      // if passed name equals to the Person p name => return Person p
      // otherwise, return null
      foreach (Person p in group)
      {
        if (p.fullName.ToLower() == name) return p;
      }
      return null;
    }

    // print every person name from the group list  
    private static void PrintGroup()
    {
      Console.Clear();
      Console.WriteLine("Här är våran basgrupp:");
      Console.WriteLine("----------------------");
      // index
      int i = 1;
      foreach (Person p in group)
      {
        Console.WriteLine($"{i}. {p.fullName},");
        // increase the index by 1 after each iteration
        i++;
      }
      Console.WriteLine();
      Console.WriteLine("[OBS]: Några av oss känns inte super bekvämt med info upp på GitHub (som fullt namn).");
    }

    // if passed password(pw) equals password => return true
    // otherwise => return false
    private static bool CheckPassword(string pw) => password == pw;
    private static void DeletePerson(Person person) => group.Remove(person);
    private static void CloseApp()
    {
      Console.Clear();
      Console.WriteLine("Bye! Bye! Bye!");
      Environment.Exit(0);
    }

    private static void CreateGroup()
    {
      Person AndreiK = new Person
      {
        age = 26,
        astrologicalSign = AstrologicalSign.Stenbocken,
        birthday = new DateTime(1994, 1, 12),
        favoriteBand = "Two Steps from Hell",
        favoriteFilm = new Dictionary<string, string>{{"title","The Lord of the Rings"},
        {"ganre","Fantasy/Adventure"}, {"release","2001"}},
        favoriteFood = "Carbonara",
        fullName = "Andrei K",
        hates = "Oliver",
        likes = "Resa",
        programmingDrive = "Problemlösning",
        superpower = "Instant olive detection"
      };
      group.Add(AndreiK);

      Person MaLin = new Person
      {
        age = 29,
        astrologicalSign = AstrologicalSign.Fiskarna,
        birthday = new DateTime(1994, 3, 13),
        favoriteBand = "Modest Mouse",
        favoriteFilm = new Dictionary<string, string>{{"title","Snatch"},
        {"ganre","Comedy/Crime"}, {"release","2000"}},
        favoriteFood = "Rårakor",
        fullName = "MA.Lin",
        hates = "Banan",
        likes = "Höst/Vinter",
        programmingDrive = "Skapande",
        superpower = "Mrs.Hindsight"
      };
      group.Add(MaLin);

      Person Leroy = new Person
      {
        age = 32,
        astrologicalSign = AstrologicalSign.Vågen,
        birthday = new DateTime(1994, 10, 22),
        favoriteBand = "We the best music",
        favoriteFilm = new Dictionary<string, string>{{"title","Matrix"},
        {"ganre","Action/Sci-fi"}, {"release","1999"}},
        favoriteFood = "Pizza",
        fullName = "Leroy",
        hates = "Kaviar",
        likes = "Choklad",
        programmingDrive = "Dynamisk",
        superpower = "Flyga"
      };
      group.Add(Leroy);
    }
  }
}
