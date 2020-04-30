using System;
using System.Linq;
namespace MidTerm2OODP_First
{
    class Program
    {
        static void Main(string[] args)
        {

            Pupil p1 = new Pupil("Maks");
            Pupil p2 = new Pupil("Niko");
            Pupil p3 = new Pupil("Mika");
            Pupil p4 = new Pupil("Aaron");

            School scl = new School(26);
            School scl2 = new School(100);
            
            GradeClass A = new GradeClass("A");
            GradeClass B = new GradeClass("B");

            A.AddPupil(p1);
            A.AddPupil(p2);
            B.AddPupil(p3);
            B.AddPupil(p4);
            
            scl.AddClasses(A);
            scl.AddClasses(B);

            GradeClass A2 = new GradeClass("A");
            GradeClass B2 = new GradeClass("B");
            Pupil p5 = new Pupil("Aks");
            Pupil p6 = new Pupil("Iko");
            Pupil p7 = new Pupil("kama");
            Pupil p8 = new Pupil("Shon");
            A2.AddPupil(p1);
            A2.AddPupil(p2);
            B2.AddPupil(p3);
            B2.AddPupil(p4);
            scl2.AddClasses(A2);
            scl2.AddClasses(B2);

            var result = from t in scl.MyPupils orderby t.Name
                         select t.Name;
            var result2 = from t in scl2.MyPupils
                         orderby t.Name
                         select t.Name;
            var r = result.Intersect(result2);




            var res = from a in scl.MyPupils
                      from b in scl2.MyPupils
                      select new {a, b};

            foreach (var item in res)
            {
                Console.WriteLine(item.a.Name);
                Console.WriteLine(item.b.Name);
            }

        }
    }
}
