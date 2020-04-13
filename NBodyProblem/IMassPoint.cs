using MathNet.Numerics.LinearAlgebra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBodyProblem
{
    public interface IMassPoint
    {
        Vector<double> Position { get; }
        Vector<double> Velocity { get; }
        Vector<double> Acceleration { get; }
        double Mass { get; }
    }
}
