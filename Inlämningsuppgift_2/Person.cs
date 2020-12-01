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
    public string programingDrive;

    public void Describe()
    {
      Console.WriteLine($"1. Namn: {fullName}, \n2. Ålder: {age} år, \n3. Födelsedag: {birthday.ToString("MMMM dd")}, \n4. Favoritmat: {favoriteFood}, \n5. Favoritband: {favoriteBand}, \n6. Favoritfilm: {favoriteFilm["title"]} - {favoriteFilm["ganre"]} - [{favoriteFilm["release"]}], \n7. Älskar: {likes}, \n8. Hatar: {hates}, \n9. Stjärntecken: {astrologicalSign}, \n10. Superpower: {superpower}, \n11. Största driv till programmering: {programingDrive}");
    }
  }
}