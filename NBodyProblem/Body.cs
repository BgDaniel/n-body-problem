using MathNet.Numerics.LinearAlgebra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBodyProblem
{
    public class PQState
    {
        public Vector<double> Position { get; set; }
        public Vector<double> Velocity { get; set; }
        public Vector<double> Acceleration { get; set; }

        public PQState(Vector<double> position, Vector<double> velocity, Vector<double> acceleration)
        {
            Position = position;
            Velocity = velocity;
            Acceleration = acceleration;
        }
    }

    public class InitialValues
    {
        public Vector<double> InitialPosition { get; set; }
        public Vector<double> InitialVelocity { get; set; }
        public Vector<double> InitialAcceleration { get; set; }

        public InitialValues(Vector<double> initialPosition, Vector<double> initialVelocity, Vector<double> initialAcceleration)
        {
            InitialPosition = initialPosition;
            InitialVelocity = initialVelocity;
            InitialAcceleration = initialAcceleration;
        }
    }

    public class Body : IMassPoint
    { 
        public PQState PQState { get; set; }
        public InitialValues InitialValues { get; set; }
        public double Mass { get; private set; }

        public Body(Vector<double> initialPosition, Vector<double> initialVelocity, Vector<double> initialAcceleration, double mass)
        {
            InitialValues = new InitialValues(initialPosition, initialVelocity, initialAcceleration);
            PQState = new PQState(initialPosition.Clone(), initialVelocity.Clone(), initialAcceleration.Clone());
            Mass = mass;
        }

        public Body(double mass)
        {
            Mass = mass;
        }
    }
}
