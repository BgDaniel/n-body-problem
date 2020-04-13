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
        PQState PQState { get; }
        InitialValues InitialValues { get;}
        double Mass { get; }
    }
}
