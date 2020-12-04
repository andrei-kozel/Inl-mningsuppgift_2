using System;
using System.Collections.Generic;

namespace Inlämningsuppgift_2
{
  class Program
  {
    private const string PASSWORD = "götebuggarna";

    // Main method
    static void Main(string[] args)
    {
      // Create BasGrupp
      BaseGroup Group = new BaseGroup("Götebuggarna");
      // Welcome user and ask to enter a password
      Console.WriteLine("Välkommen!");
      Console.Write("Ange ditt lösenord: ");

      // check the password. If the password is correct - run the app
      string password = Console.ReadLine().ToLower();
      if (CheckPassword(password))
      {
        CreateGroup(Group);
        RunApp(Group);
      }
      else Console.WriteLine("Fel lösenord!");
    }

    private static void RunApp(BaseGroup Group)
    {
      Group.PrintGroup();
      // Asking the user to enter the name of the person to show more info
      // Or enter q to exit
      Console.WriteLine("[q] - Stänga");
      Console.Write("Visa mer info (skriv 'Namn E'): ");
      string name = Console.ReadLine().ToLower();
      if (name == "q") CloseApp();
      Person person = Group.FindPerson(name);
      // If the person is null - ask the user again and again.
      while (person == null)
      {
        System.Console.WriteLine("Jag har inte hittat någon :(");
        System.Console.Write("Prova en gång till. Skriv tex 'Andrei K': ");
        name = Console.ReadLine().ToLower();
        person = Group.FindPerson(name);
        if (name == "q") CloseApp();
      }
      person.Describe();

      // Ask the user what he wants to do with this information
      // 1 - go back
      // 2 - delete person from the list 
      // 3 - exit
      Console.WriteLine("[1]-Tillbaka, [2]-Ta Bort Person, [q]-Quite");
      Console.Write("Vad vill du göra? ");
      string input = Console.ReadLine();
      switch (input)
      {
        case "1":
          RunApp(Group);
          break;
        case "2":
          Group.RemovePerson(person);
          RunApp(Group);
          break;
        case "q":
          CloseApp();
          break;
      }
    }
    // if passed password(pw) equals password => return true
    // otherwise => return false
    private static bool CheckPassword(string pw) => PASSWORD == pw;

    // Close app
    private static void CloseApp()
    {
      Console.Clear();
      Console.WriteLine("Bye! Bye! Bye!");
      Environment.Exit(0);
    }

    private static void CreateGroup(BaseGroup Group)
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
      Group.AddPerson(AndreiK);

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
      Group.AddPerson(MaLin);


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
      Group.AddPerson(Leroy);

    }
  }
}
