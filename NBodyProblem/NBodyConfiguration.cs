using MathNet.Numerics.LinearAlgebra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBodyProblem
{
    public abstract class NBodyConfiguration
    {
        public List<Body> Bodies { get; private set; }

        public NBodyConfiguration(List<Body> bodies)
        {
            Bodies = bodies;
        }

        public void Evolve(double dt)
        {
            foreach(var body in Bodies)
            {
                var acceleration = Vector<double>.Build.Dense(3);

                foreach (var neighbour in Bodies.Where(_body => _body != body))
                {
                    acceleration += NewtonsGravitationalLaw.Force(body, neighbour) * dt / body.Mass;
                }

                var newVelocity = body.Velocity + acceleration * dt;
                body.Acceleration = newVelocity - body.Velocity;
                var newPosition = body.Position + body.Velocity * dt;
                body.Velocity = newVelocity.Clone();
                body.Position = newPosition.Clone();
            }
        }
    }
}
