using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBodyProblem.SolarSystem
{
    public class Planets : List<Planet> { }

    public sealed class Planet : Body
    {        
        public String Name { get; private set; }
        public double Diameter { get; private set; }

        public Planet(string name, double mass, double diameter) : base(mass)
        {
            Name = name;
            Diameter = diameter;
        }
    }

    public sealed class Sun : Body
    {
        private const double SUN_MASS = 332946.0;
        private const double SUN_DIAMETER = 109.0;

        public String Name => "Sun";
        public double Diameter => SUN_DIAMETER;

        public Sun() : base(SUN_MASS)
        { }
    }
}



