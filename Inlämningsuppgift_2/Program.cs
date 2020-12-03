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
        if (p.Name.ToLower() == name) return p;
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
        Console.WriteLine($"{i}. {p.Name},");
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
        Age = 26,
        AstrologicalSign = AstrologicalSign.Stenbocken,
        Birthday = new DateTime(1994, 1, 12),
        FavoriteBand = "Two Steps from Hell",
        FavoriteFilm = new Dictionary<string, string>{{"title","The Lord of the Rings"},
        {"ganre","Fantasy/Adventure"}, {"release","2001"}},
        FavoriteFood = "Carbonara",
        Name = "Andrei K",
        Hates = "Oliver",
        Likes = "Resa",
        ProgrammingDrive = "Problemlösning",
        Superpower = "Instant olive detection"
      };
      group.Add(AndreiK);

      Person MaLin = new Person
      {
        Age = 29,
        AstrologicalSign = AstrologicalSign.Fiskarna,
        Birthday = new DateTime(1994, 3, 13),
        FavoriteBand = "Modest Mouse",
        FavoriteFilm = new Dictionary<string, string>{{"title","Snatch"},
        {"ganre","Comedy/Crime"}, {"release","2000"}},
        FavoriteFood = "Rårakor",
        Name = "MA.Lin",
        Hates = "Banan",
        Likes = "Höst/Vinter",
        ProgrammingDrive = "Skapande",
        Superpower = "Mrs.Hindsight"
      };
      group.Add(MaLin);

      Person Leroy = new Person
      {
        Age = 32,
        AstrologicalSign = AstrologicalSign.Vågen,
        Birthday = new DateTime(1994, 10, 22),
        FavoriteBand = "We the best music",
        FavoriteFilm = new Dictionary<string, string>{{"title","Matrix"},
        {"ganre","Action/Sci-fi"}, {"release","1999"}},
        FavoriteFood = "Pizza",
        Name = "Leroy",
        Hates = "Kaviar",
        Likes = "Choklad",
        ProgrammingDrive = "Dynamisk",
        Superpower = "Flyga"
      };
      group.Add(Leroy);
    }
  }
}
