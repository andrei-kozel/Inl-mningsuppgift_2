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
    public string fullName;
    public int age;
    public DateTime birthday;
    public string favoriteFood;
    public string favoriteBand;
    public Dictionary<string, string> favoriteFilm;
    public string likes;
    public string hates;
    public AstrologicalSign astrologicalSign;
    public string superpower;
    public string programmingDrive;

    public void Describe()
    {
      Console.Clear();
      Console.WriteLine($"1. Namn: {fullName},");
      Console.WriteLine($"2. Ålder: {age} år,");
      Console.WriteLine($"3. Födelsedag: {birthday.ToString("MMMM dd")},");
      Console.WriteLine($"4. Favoritmat: {favoriteFood},");
      Console.WriteLine($"5. Favoritband: {favoriteBand},");
      Console.WriteLine($"6. Favoritfilm: {favoriteFilm["title"]} - {favoriteFilm["ganre"]} - [{favoriteFilm["release"]}],");
      Console.WriteLine($"7. Älskar: {likes},");
      Console.WriteLine($"8. Hatar: {hates},");
      Console.WriteLine($"9. Stjärntecken: {astrologicalSign},");
      Console.WriteLine($"10. Superpower: {superpower}, \n11. Största driv till programmering: {programmingDrive}");
      Console.WriteLine();
    }
  }
}