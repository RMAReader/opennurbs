using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace opennurbsCSharp.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int dim = 2;
            bool is_rat = false;
            int order = 3;
            double[] knot = new double[] { 0,1,2,3};
            int cv_stride = 2;
            double[] cv = new double[] { 1, 1, 0, 1, 0, 0};//{ 0, 0, 1, 0, 1, 1 };
            int der_count = 1;
            int v_stride = 1;
           
            var p1 = new double[2];
            var result1 = EvaluateNurbs.ON_EvaluateNurbsSpan(dim, is_rat, order, knot, cv_stride, cv, der_count, 1.9, v_stride, p1);

            var p2 = new double[2];
            var result2 = EvaluateNurbs.ON_EvaluateNurbsSpan(dim, is_rat, order, knot, cv_stride, cv, der_count, 2, v_stride, p2);

            var p3 = new double[2];
            var result3 = EvaluateNurbs.ON_EvaluateNurbsSpan(dim, is_rat, order, knot, cv_stride, cv, der_count, 2.5, v_stride, p3);

            var p4 = new double[2];
            var result4 = EvaluateNurbs.ON_EvaluateNurbsSpan(dim, is_rat, order, knot, cv_stride, cv, der_count, 3, v_stride, p4);

            var p5 = new double[2];
            var result5 = EvaluateNurbs.ON_EvaluateNurbsSpan(dim, is_rat, order, knot, cv_stride, cv, der_count, 3.1, v_stride, p5);



        }
    }
}
