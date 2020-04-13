using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBodyProblem.SolarSystem
{
    public class Planets : List<Planet> 
    {
        public List<Body> ToBodies()
        {
            var bodies = new List<Body>();
            
            foreach (var planet in this)
                bodies.Add((Body)planet);

            return bodies;
        }
    }

    public sealed class Planet : Body, IEquatable<Planet>
    {        
        public String Name { get; private set; }
        public double Diameter { get; private set; }
        public Planets Moons { get; private set; }

        public Planet(string name, double mass, double diameter, Planets moons = null) : base(mass)
        {
            Name = name;
            Diameter = diameter;
            Moons = moons;
        }

        public bool Equals(Planet other)
        {
            if (other.GetType() == typeof(Planet))
            {
                if (Name == other.Name)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
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



