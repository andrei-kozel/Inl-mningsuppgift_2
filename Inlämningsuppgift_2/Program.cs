﻿using System;
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
        Name = "Andrei K",
        Age = 26,
        Birthday = new DateTime(1994, 1, 12),
        FavoriteFood = "Carbonara",
        FavoriteBand = "Two Steps from Hell",
        FavoriteFilm = new Dictionary<string, string>{{"title","The Lord of the Rings"},
        {"ganre","Fantasy/Adventure"}, {"release","2001"}},
        Likes = "Resa",
        Hates = "Oliver",
        AstrologicalSign = AstrologicalSign.Stenbocken,
        ProgrammingDrive = "Problemlösning",
        Superpower = "Instant olive detection",
      };
      Group.AddPerson(AndreiK);

      Person MaLin = new Person
      {
        Name = "MA.Lin",
        Age = 29,
        Birthday = new DateTime(1994, 3, 13),
        FavoriteFood = "Rårakor",
        FavoriteBand = "Modest Mouse",
        FavoriteFilm = new Dictionary<string, string>{{"title","Snatch"},
        {"ganre","Comedy/Crime"}, {"release","2000"}},
        Likes = "Höst/Vinter",
        Hates = "Banan",
        AstrologicalSign = AstrologicalSign.Fiskarna,
        ProgrammingDrive = "Skapande",
        Superpower = "Mrs.Hindsight",
      };
      Group.AddPerson(MaLin);


      Person Leroy = new Person
      {
        Name = "Leroy",
        Age = 32,
        Birthday = new DateTime(1994, 10, 22),
        FavoriteFood = "Pizza",
        FavoriteBand = "We the best music",
        FavoriteFilm = new Dictionary<string, string>{{"title","Matrix"},
        {"ganre","Action/Sci-fi"}, {"release","1999"}},
        Likes = "Choklad",
        Hates = "Kaviar",
        AstrologicalSign = AstrologicalSign.Vågen,
        Superpower = "Flyga",
        ProgrammingDrive = "Dynamisk",
      };
      Group.AddPerson(Leroy);

      Person JesperP = new Person
      {
        Name = "Jesper P",
        Age = 28,
        Birthday = new DateTime(1994, 05, 29),
        FavoriteFood = "Lammracks",
        FavoriteBand = "Lars Winnerbäck",
        FavoriteFilm = new Dictionary<string, string>{{"title","Catch me if you can"},
        {"ganre","Crime/Drama"}, {"release","2002"}},
        Likes = "De enkla sakerna",
        Hates = "Folk som filmar på konserter",
        AstrologicalSign = AstrologicalSign.Tvillingarna,
        Superpower = "Teleportering",
        ProgrammingDrive = "Frihet",
      };
      Group.AddPerson(JesperP);

      Person GurraM = new Person
      {
        Name = "Gurra M",
        Age = 33,
        Birthday = new DateTime(1994, 11, 17),
        FavoriteFood = "Tacos",
        FavoriteBand = "Berliner Philharmoniker",
        FavoriteFilm = new Dictionary<string, string>{{"title","Star Wars: The Phantom Menace (Episode I)"},
        {"ganre","Sci-fi/Action"}, {"release","1999"}},
        Likes = "J.S. Bach",
        Hates = "Schlager",
        AstrologicalSign = AstrologicalSign.Skorpionen,
        Superpower = "Tala med hundvalpar",
        ProgrammingDrive = "Kreativitet",
      };
      Group.AddPerson(GurraM);

      Person JonnaWiberg = new Person
      {
        Name = "Jonna Wiberg",
        Age = 30,
        Birthday = new DateTime(1994, 02, 05),
        FavoriteFood = "Pizza",
        FavoriteBand = "Full of hell",
        FavoriteFilm = new Dictionary<string, string>{{"title","Interstellar"},
        {"ganre","Sci-fi/Adventure"}, {"release","2014"}},
        Likes = "Musik",
        Hates = "Kött",
        AstrologicalSign = AstrologicalSign.Vattumannen,
        Superpower = "Odödlig",
        ProgrammingDrive = "Tjurskallig",
      };
      Group.AddPerson(JonnaWiberg);

      Person LinusN = new Person
      {
        Name = "Linus N",
        Age = 27,
        Birthday = new DateTime(1994, 07, 27),
        FavoriteFood = "Fisksoppa",
        FavoriteBand = "Jack Moy",
        FavoriteFilm = new Dictionary<string, string>{{"title","The secret life of walter mitty"},
        {"ganre","Comedy/Adventure"}, {"release","2013"}},
        Likes = "Banan",
        Hates = "Senap",
        AstrologicalSign = AstrologicalSign.Kräftan,
        Superpower = "Andas under vatten",
        ProgrammingDrive = "Få ett riktigt skoj jobb",
      };
      Group.AddPerson(LinusN);

      Person NilsO = new Person
      {
        Name = "Nils O",
        Age = 21,
        Birthday = new DateTime(1994, 03, 15),
        FavoriteFood = "Pannkakor",
        FavoriteBand = "Beach Boys",
        FavoriteFilm = new Dictionary<string, string>{{"title","American Psycho"},
        {"ganre","Horror/Mystery"}, {"release","2000"}},
        Likes = "Snö",
        Hates = "Slask",
        AstrologicalSign = AstrologicalSign.Fiskarna,
        Superpower = "Räkna med fingrarna",
        ProgrammingDrive = "Roligt",
      };
      Group.AddPerson(NilsO);

      Person Yulrok = new Person
      {
        Name = "Yulrok",
        Age = 38,
        Birthday = new DateTime(1994, 04, 23),
        FavoriteFood = "Musli",
        FavoriteBand = "Morcheeba",
        FavoriteFilm = new Dictionary<string, string>{{"title","The green book"},
        {"ganre","Drama/Comedy-drama"}, {"release","2016"}},
        Likes = "Ost",
        Hates = "Slöseri",
        AstrologicalSign = AstrologicalSign.Oxen,
        Superpower = "Tankeöverföring",
        ProgrammingDrive = "Biljett till \"digital nomad\" - livet",
      };
      Group.AddPerson(Yulrok);
    }
  }
}
