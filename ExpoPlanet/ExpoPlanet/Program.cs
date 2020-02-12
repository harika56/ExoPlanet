using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ExoPlanet
{
   public class Program
    {
        static void Main()
        {

        var exoPlanetsJson = File.ReadAllText("exoplanets.json");
        var exoPlanets = JsonConvert.DeserializeObject<List<ExoPlanetData>>(exoPlanetsJson);
        Console.WriteLine($"Number of Planets: {exoPlanets.Count}");
        Console.WriteLine($"Number of Orphan Planets (without star): {exoPlanets.FindAll( n => n.HostStarAgeGyr.ToString() == "" && n.HostStarRadiusSlrRad.ToString() == " " && n.HostStarMetallicity.ToString() == "" && n.HostStarMassSlrMass.ToString() == "" && n.HostStarTempK.ToString() == "" ).Count}");

        var planetOrbitingHottestStar = exoPlanets.FirstOrDefault(v => v.HostStarTempK.ToString() == exoPlanets.Max(c => c.HostStarTempK.ToString()));

        if (planetOrbitingHottestStar != null)
                        {
                            Console.WriteLine($"Planet Orbiting HottestStar: { planetOrbitingHottestStar.PlanetIdentifier}");
                        }
          var years = exoPlanets.GroupBy(u => u.DiscoveryYear.OrderBy(s => s.Key.ToString() == "" ? 0 : Convert.ToInt32(s.Key)).Select(g => g.ToList()).ToList();

            foreach (var year in years)
            {
                var yea = year.FirstOrDefault()?.DiscoveryYear;
                var small = year.FindAll(c => c != null && c.RadiusJpt.ToString() != "" && Convert.ToDouble(c.RadiusJpt) < 1);
                var medium = year.FindAll(c => c! = null && c.RadiusJpt.ToString() != "" && Convert.ToDouble(c.RadiusJpt) < 2 && Convert.ToDouble(c.RadiusJpt) > 1);
                var large = year.FindAll(c => c != null && c.RadiusJpt.ToString() != "" && Convert.ToDouble(c.RadiusJpt) > 2);
                Console.WriteLine($"In the year{yea} we discovered {small.Count} Small Planets, {medium.Count} Medium Planets and {large.Count} Large Planets. Total {small.Count + medium.Count + large.Count}");
            }
        }
    }
}
   


