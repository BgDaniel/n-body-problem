using MathNet.Numerics.LinearAlgebra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBodyProblem
{
    public class Neighbours : List<Body> { }

    public class Body : IMassPoint
    { 
        public Vector<double> Position { get; private set; }
        public Vector<double> Velocity { get; private set; }
        public Vector<double> Acceleration { get; private set; }
        public double Mass { get; private set; }
        public Neighbours Neighbours { get; private set; }

        public Body(Vector<double> position, Vector<double> velocity, Vector<double> acceleration, double mass)
        {
            Position = position;
            Velocity = velocity;
            Acceleration = acceleration;
            Mass = mass;
        }

        public Body(double mass)
        {
            Mass = mass;
        }

        public void Evolve(double dt)
        {
            var acceleration = NewtonsGravitationalLaw.Force(this, Neighbours) * dt / Mass;
            var velocity_next = Velocity + acceleration * dt;
            Acceleration = velocity_next - Velocity;
            var position_next = Position + Velocity * dt;

            Velocity = velocity_next.Clone();
            Position = position_next.Clone();
        }
    }
}
