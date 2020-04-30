using System;
using System.Collections.Generic;
using System.Text;

namespace MidTerm2OODP_First
{
    class School
    {
        List<GradeClass> gradeClasses = new List<GradeClass>();
        int _number;
        public School(int number)
        {
            _number = number;
        }

        public void AddClasses(GradeClass gradeClass)
        {
            gradeClasses.Add(gradeClass);
        }
    }
}
