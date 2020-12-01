using System;
using System.Collections.Generic;

namespace Inlämningsuppgift_2
{
  class Program
  {
    static void Main(string[] args)
    {
      var andreiK = new Person
      {
        age = 26,
        astrologicalSign = AstrologicalSign.Stenbocken,
        birthday = new DateTime(1994, 1, 12),
        favoriteBand = "Two Steps from Hell",
        favoriteFilm = new Dictionary<string, string>{{"title","The Lord of the Rings"},
        {"ganre","Fantasy/Adventure"}, {"release","10 December 2001"}},
        favoriteFood = "Carbonara",
        fullName = "Andrei K",
        hates = "Oliver",
        likes = "Resa",
        programingDrive = "Problemlösning",
        superpower = "Instant olive detection"
      };
      andreiK.Describe();
    }
  }
}
