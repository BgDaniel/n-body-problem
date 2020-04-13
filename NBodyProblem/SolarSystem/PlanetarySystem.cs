using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBodyProblem.SolarSystem
{
    public class PlanetarySystem : NBodyConfiguration
    {
        private PlanetarySystem(Planets planets) : base(planets.ToBodies())
        {
            Bodies.Add(new Sun());
        }

        public static PlanetarySystem Create(List<string> names)
        {
            return new PlanetarySystem(SolarSystemHelper.GetPlanets(names));
        }
    }
}
