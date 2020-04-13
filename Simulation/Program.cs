using NBodyProblem.SolarSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var system = PlanetarySystem.Create(new List<String>() { "Earth" });
            system.Evolve(10e-7);
        }
    }
}
