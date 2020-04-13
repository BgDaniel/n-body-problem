using MathNet.Numerics.LinearAlgebra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBodyProblem
{
    public static class NewtonsGravitationalLaw
    {
        private const double GRAVITATIONAL_CONSTANT = 6.6743 * 10e-11;

        public static Vector<double> Force(Body body, Body neighbour)
        {
            Vector<double> force = Vector<double>.Build.Dense(3);

            var bodyToNeighbour = neighbour.PQState.Position - body.PQState.Position;
            var distance = Math.Sqrt(bodyToNeighbour.Norm(2));
            force += GRAVITATIONAL_CONSTANT * body.Mass * neighbour.Mass * bodyToNeighbour / (distance * distance * distance);

            return force;
        }
    }
}
