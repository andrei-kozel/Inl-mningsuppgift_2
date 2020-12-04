using System;
using System.Collections.Generic;

namespace Inlämningsuppgift_2
{
  public enum AstrologicalSign
  {
    Väduren, Oxen, Tvillingarna, Kräftan, Lejonet, Jungfrun,
    Vågen, Skorpionen, Skytten, Stenbocken, Vattumannen, Fiskarna
  }
  class Person
  {
    public string Name { get; set; }
    public int Age { get; set; }
    public DateTime Birthday { get; set; }
    public string FavoriteFood { get; set; }
    public string FavoriteBand { get; set; }
    public Dictionary<string, string> FavoriteFilm { get; set; }
    public string Likes { get; set; }
    public string Hates { get; set; }
    public AstrologicalSign AstrologicalSign { get; set; }
    public string Superpower { get; set; }
    public string ProgrammingDrive { get; set; }

    public void Describe()
    {
      Console.Clear();
      Console.WriteLine($"1. Namn: {Name},");
      Console.WriteLine($"2. Ålder: {Age} år,");
      Console.WriteLine($"3. Födelsedag: {Birthday.ToString("MMMM dd")},");
      Console.WriteLine($"4. Favoritmat: {FavoriteFood},");
      Console.WriteLine($"5. Favoritband: {FavoriteBand},");
      Console.WriteLine($"6. Favoritfilm: {FavoriteFilm["title"]} - {FavoriteFilm["ganre"]} - [{FavoriteFilm["release"]}],");
      Console.WriteLine($"7. Älskar: {Likes},");
      Console.WriteLine($"8. Hatar: {Hates},");
      Console.WriteLine($"9. Stjärntecken: {AstrologicalSign},");
      Console.WriteLine($"10. Superpower: {Superpower}");
      Console.WriteLine($"11. Största driv till programmering: {ProgrammingDrive}");
      Console.WriteLine();
    }
  }
}