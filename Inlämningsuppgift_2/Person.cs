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
    private string name;
    private int age;
    private DateTime birthday;
    private string favoriteFood;
    private string favoriteBand;
    private Dictionary<string, string> favoriteFilm;
    private string likes;
    private string hates;
    private AstrologicalSign astrologicalSign;
    private string superpower;
    private string programmingDrive;

    public string Name
    {
      get => name;
      set => name = value;
    }
    public int Age
    {
      get => age;
      set => age = value;
    }

    public DateTime Birthday
    {
      get => birthday;
      set => birthday = value;
    }

    public string FavoriteFood
    {
      get => favoriteFood;
      set => favoriteFood = value;
    }

    public string FavoriteBand
    {
      get => favoriteBand;
      set => favoriteBand = value;
    }

    public Dictionary<string, string> FavoriteFilm
    {
      get => favoriteFilm;
      set => favoriteFilm = value;
    }

    public string Likes
    {
      get => likes;
      set => likes = value;
    }

    public string Hates
    {
      get => hates;
      set => hates = value;
    }

    public AstrologicalSign AstrologicalSign
    {
      get => astrologicalSign;
      set => astrologicalSign = value;
    }

    public string Superpower
    {
      get => superpower;
      set => superpower = value;
    }

    public string ProgrammingDrive
    {
      get => programmingDrive;
      set => programmingDrive = value;
    }

    public void Describe()
    {
      Console.Clear();
      Console.WriteLine($"1. Namn: {name},");
      Console.WriteLine($"2. Ålder: {age} år,");
      Console.WriteLine($"3. Födelsedag: {birthday.ToString("MMMM dd")},");
      Console.WriteLine($"4. Favoritmat: {favoriteFood},");
      Console.WriteLine($"5. Favoritband: {favoriteBand},");
      Console.WriteLine($"6. Favoritfilm: {favoriteFilm["title"]} - {favoriteFilm["ganre"]} - [{favoriteFilm["release"]}],");
      Console.WriteLine($"7. Älskar: {likes},");
      Console.WriteLine($"8. Hatar: {hates},");
      Console.WriteLine($"9. Stjärntecken: {astrologicalSign},");
      Console.WriteLine($"10. Superpower: {superpower}");
      Console.WriteLine($"11. Största driv till programmering: {programmingDrive}");
      Console.WriteLine();
    }
  }
}