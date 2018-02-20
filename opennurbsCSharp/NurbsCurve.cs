using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace opennurbsCSharp
{
    public class NurbsCurve
    {
        private IntPtr curve;

        [DllImport("opennurbs.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr ON_NurbsCurve_New();

        [DllImport("opennurbs.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr ON_NurbsCurve_New2(int dimension, bool bIsRational, int order, int cv_count);

        [DllImport("opennurbs.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern bool ON_NurbsCurve_Evaluate(IntPtr curve, double t, int derv_n, int stride, double[] result, int evaluate_from, int[] evaluate_hint);

        [DllImport("opennurbs.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern bool ON_NurbsCurve_SetCV(IntPtr curve, int IX, int style, double[] value);

        [DllImport("opennurbs.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern bool ON_NurbsCurve_SetKnot(IntPtr curve, int knot_index, double knot_value);

        [DllImport("opennurbs.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern int ON_NurbsCurve_KnotCount(IntPtr curve);

        [DllImport("opennurbs.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern void ON_NurbsCurve_GetCV(IntPtr curve, int IX, int style, double[] value);

        [DllImport("opennurbs.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern double ON_NurbsCurve_Knot(IntPtr curve, int IX);

        [DllImport("opennurbs.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern void ON_NurbsCurve_Domain(IntPtr curve, double[] domain);

        [DllImport("opennurbs.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern int ON_NurbsCurve_Degree(IntPtr curve);

        [DllImport("opennurbs.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern bool ON_NurbsCurve_InsertKnot(IntPtr curve, double knot, int multiplicity);

        [DllImport("opennurbs.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern bool ON_NurbsCurve_IncreaseDegree(IntPtr curve, int desiredDegree);

        [DllImport("opennurbs.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern bool ON_NurbsCurve_GetLength(IntPtr curve, double[] length, double fractional_tolerance, double[] sub_domain);

        [DllImport("opennurbs.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern int ON_NurbsCurve_CVCount(IntPtr curve);

        [DllImport("opennurbs.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern int ON_NurbsCurve_GetClosestPoint(IntPtr curve, double[] point, double[] t, double maximum_distance, double[] sub_domain);



        public NurbsCurve()
        {
            curve = ON_NurbsCurve_New();
        }

        public NurbsCurve(int dimension, bool bIsRational, int order, int cv_count)
        {
            curve = ON_NurbsCurve_New2(dimension, bIsRational, order, cv_count);
        }

        public double[] Evaluate(double t, int derv_n)
        {
            var result = new double[2];
            int stride = 2;
            int evaluate_from = 0;
            int[] evaluate_hint = new int[2];

            ON_NurbsCurve_Evaluate(curve, t, derv_n, stride, result, evaluate_from, evaluate_hint);

            return result;
        }


        public double[] GetCV(int IX)
        {
            int style = 3;
            var value = new double[2];
            ON_NurbsCurve_GetCV(curve, IX, style, value);
            return value;
        }
        public void SetCV(int IX, double[] value)
        {
            int style = 3;
            ON_NurbsCurve_SetCV(curve, IX, style, value);
        }


        public double GetKnot(int IX)
        {
            return ON_NurbsCurve_Knot(curve, IX);
        }
        public void SetKnot(int IX, double value)
        {
            ON_NurbsCurve_SetKnot(curve, IX, value);
        }
        public int KnotCount()
        {
            return ON_NurbsCurve_KnotCount(curve);
        }

        public double[] GetDomain()
        {
            var domain = new double[2];
            ON_NurbsCurve_Domain(curve, domain);
            return domain;
        }

        public int GetDegree()
        {
            return ON_NurbsCurve_Degree(curve);
        }

        public void InsertKnot(double knot, int multiplicity)
        {
            ON_NurbsCurve_InsertKnot(curve, knot, multiplicity);
        }

        public void IncreaseDegree(int desiredDegree)
        {
            ON_NurbsCurve_IncreaseDegree(curve, desiredDegree);
        }

        public double GetLength(double[] sub_domain, double fractional_tolerance)
        {
            var length = new double[1];
            var res = ON_NurbsCurve_GetLength(curve, length, fractional_tolerance, sub_domain);
            return length[0];
        }

        public int CVCount()
        {
            return ON_NurbsCurve_CVCount(curve);
        }

        public double GetClosestPoint(double[] point, double maximum_distance, double[] sub_domain)
        {
            var t = new double[1];
            var res =  ON_NurbsCurve_GetClosestPoint(curve, point, t, maximum_distance, sub_domain);
            return t[0];
        }


    }
}
