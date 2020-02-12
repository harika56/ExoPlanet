using System;
using System.Collections.Generic;
using System.Text;

namespace ExoPlanet
{
    public class ExoPlanetData
    {
        public string PlanetIdentifier { get; set; }
        public int TypeFlag { get; set; }
        public object PlanetaryMassJpt { get; set; }
        public object RadiusJpt { get; set; }
        public object PeriodDays { get; set; }
        public object SemiMajorAxisAU { get; set; }
        public object Eccentricity { get; set; }
        public object PeriastronDeg { get; set; }
        public object LongitudeDeg { get; set; }
        public object AscendingNodeDeg { get; set; }
        public object InclinationDeg { get; set; }
        public object SurfaceTempK { get; set; }
        public object AgeGyr { get; set; }
        public string DiscoveryMethod { get; set; }
        public object DiscoveryYear { get; set; }
        public string LastUpdated { get; set; }
        public string RightAscension { get; set; }
        public string Declination { get; set; }
        public object DistfromSunParsec { get; set; }
        public object HostStarMassSlrMass { get; set; }
        public object HostStarRadiusSlrRad { get; set; }
        public object HostStarMetallicity { get; set; }
        public object HostStarTempK { get; set; }
        public object HostStarAgeGyr { get; set; }
    }
}
