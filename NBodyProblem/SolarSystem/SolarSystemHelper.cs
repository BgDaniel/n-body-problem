using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NBodyProblem.SolarSystem
{    
    public static class SolarSystemHelper
    {
        public static Planets GetPlanets()
        {

            var planets = new Planets();

            var execturingAssembly = Assembly.GetExecutingAssembly();
            using (var resourceStream = execturingAssembly.GetManifestResourceStream("NBodyProblem.SolarSystem.data_solarsystem.json"))
            {
                using (var streamReader = new StreamReader(resourceStream))
                {
                    var dataSolarSystem = JsonConvert.DeserializeObject<Dictionary<string, object>>(streamReader.ReadToEnd());                    

                    foreach (var kvp in dataSolarSystem)
                    {
                        var name = kvp.Key;
                        var data = ((JObject)(kvp.Value)).ToObject<Dictionary<string, double>>();
                        planets.Add(new Planet(kvp.Key, data["mass"], data["diameter"]));
                    }                    
                }
            }

            return planets;
        }
    }

    public sealed class SolarSystem
    {
        private static SolarSystem m_instance = null;
        public Planets Planets { get; private set; }
        public Sun Sun { get; private set; }

        private SolarSystem()
        {
            Planets = SolarSystemHelper.GetPlanets();
            Sun = new Sun();
        }

        public static SolarSystem GetInstance
        {
            get
            {
                if (m_instance == null)
                {
                    m_instance = new SolarSystem();
                    return m_instance;
                }
                else
                {
                    return m_instance;
                }
            }
        }
    }
}
