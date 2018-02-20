using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opennurbs_CLI.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            int dummy = 1;
            System.Console.WriteLine("Program begun:");

            var curve = new NurbsCurve(2, 0, 3, 3);

            //System.Console.WriteLine("Curve created: NurbsCurve(2, 0, 3, 3)");

            //curve.SetCV(0, 3, new double[] { 0, 0 });
            //curve.SetCV(1, 3, new double[] { 1, 0 });
            //curve.SetCV(2, 3, new double[] { 1, 1 });

            //for (int i = 0; i < curve.KnotCount(); i++) curve.SetKnot(i, i);

            //var points = new List<double[]>();
            //for (int i = 0; i < 3; i++)
            //{
            //    double[] p = new double[2];
            //    curve.GetCV(i, 3, p);
            //    points.Add(p);
            //    System.Console.WriteLine("Point added");
            //}

            //var knots = new List<double>();
            //for (int i = 0; i < curve.KnotCount(); i++) knots.Add(curve.GetKnot(i));

            ////var domain = curve.GetDomain();

            //var p1 = new double[2]; curve.Evaluate(1.0, 1, p1);
            //var p2 = new double[2]; curve.Evaluate(1.2, 1, p2);
            //var p3 = new double[2]; curve.Evaluate(1.5, 1, p3);
            //var p4 = new double[2]; curve.Evaluate(1.9, 1, p4);
            //var p5 = new double[2]; curve.Evaluate(2.0, 1, p5);



            //var degree1 = curve.GetDegree();
            //var nCV1 = curve.CVCount();
            //var len1 = curve.GetLength(new double[] { 1, 2 }, 1E-8);
            //var len2 = curve.GetLength(new double[] { 1, 1.5 }, 1E-8);
            //var t1 = curve.GetClosestPoint(new double[] { 1, 0 }, 100, new double[] { 1, 2 });
            //var t2 = curve.GetClosestPoint(new double[] { 1, 0 }, 100, new double[] { 1, 1.1 });

            //curve.InsertKnot(1.5, 1);

            //var p21 = curve.Evaluate(1.0, 1);
            //var p22 = curve.Evaluate(1.2, 1);
            //var p23 = curve.Evaluate(1.5, 1);
            //var p24 = curve.Evaluate(1.9, 1);
            //var p25 = curve.Evaluate(2.0, 1);
            //var degree2 = curve.GetDegree();
            //var knots2 = curve.KnotCount();
            //var nCV2 = curve.CVCount();

            //curve.IncreaseDegree(4);

            //var p31 = curve.Evaluate(1.0, 1);
            //var p32 = curve.Evaluate(1.2, 1);
            //var p33 = curve.Evaluate(1.5, 1);
            //var p34 = curve.Evaluate(1.9, 1);
            //var p35 = curve.Evaluate(2.0, 1);
            //var degree3 = curve.GetDegree();
            //var knots3 = curve.KnotCount();
            //var nCV3 = curve.CVCount();
            System.Console.ReadKey();
        }
    }
}
