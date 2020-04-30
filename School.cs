using System;
using System.Collections.Generic;
using System.Text;

namespace MidTerm2OODP_First
{
    class School
    {
        public List<GradeClass> gradeClasses { get; private set; } = new List<GradeClass>();
        public List<Pupil> MyPupils { get; private set; } = new List<Pupil>();
        int _number;
        public School(int number)
        {
            _number = number;
            
        }

        public void AddClasses(GradeClass gradeClass)
        {
            for (int i = 0; i < gradeClass.pupils.Count; i++)
            {
                MyPupils.Add(gradeClass.pupils[i]);
            }
            gradeClasses.Add(gradeClass);
        }
        
    }
}
