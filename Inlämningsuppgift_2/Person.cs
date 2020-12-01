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
  }
}