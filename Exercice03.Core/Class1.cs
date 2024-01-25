﻿using System;
using System.Collections.Generic;
using System.Linq;

public class RechercheVille
{
   private List<string> _villes;

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
        if (mot.Length < 2)
        {
            throw new NotFoundException();
        }
        return _villes.Where(ville => ville.Contains(mot)).ToList();
    }
}

public class NotFoundException : Exception
{
}