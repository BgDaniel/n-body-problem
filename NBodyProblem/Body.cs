using MathNet.Numerics.LinearAlgebra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBodyProblem
{
    public class Body : IMassPoint
    { 
        public Vector<double> Position { get; set; }
        public Vector<double> InitialPosition { get; private set; }
        public Vector<double> Velocity { get; set; }
        public Vector<double> InitialVelocity { get; private set; }
        public Vector<double> Acceleration { get; set; }
        public double Mass { get; private set; }


        public Body(Vector<double> initialPosition, Vector<double> initialVelocity, Vector<double> acceleration, double mass)
        {
            InitialPosition = initialPosition;
            Velocity = initialVelocity;
            Acceleration = acceleration;
            Mass = mass;
        }

        public Body(double mass)
        {
            Mass = mass;
        }
    }
}
