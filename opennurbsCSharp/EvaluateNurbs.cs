using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace opennurbsCSharp
{
    public class EvaluateNurbs
    {
        [DllImport("opennurbs.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool ON_EvaluateNurbsSpan(int dim,
            bool is_rat,
            int order,
            double[] knot,
            int cv_stride,
            double[] cv,
            int der_count,
            double t,
            int v_stride,
            double[] v);

    }
}
