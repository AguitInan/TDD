using System;
using System.Collections.Generic;
using System.Linq;

public class RechercheVille
{
   public List<string> _villes;

    public RechercheVille()
    {
        _villes = new List<string> {
            "Paris", "Budapest", "Skopje", "Rotterdam", "Valence",
            "Vancouver", "Amsterdam", "Vienne", "Sydney", "New York",
            "Londres", "Bangkok", "Hong Kong", "Dubaï", "Rome", "Istanbul"
        };
    }

    public List<string> Rechercher(string mot)
    {
        if (mot == "*")
        {
            return _villes;
        }
        if (mot.Length < 2)
        {
            throw new NotFoundException();
        }
        return _villes.Where(ville => ville.ToLower().Contains(mot.ToLower())).ToList();
    }
}

public class NotFoundException : Exception
{
}