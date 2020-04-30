using System;
using System.Collections.Generic;
using System.Text;

namespace MidTerm2OODP_First
{
    class GradeClass
    {
        public List<Pupil> pupils { get; private set; } = new List<Pupil>();
        string _className;
        public GradeClass(string className)
        {
            _className = className;
        }

        public void AddPupil(Pupil pupil)
        {
            pupils.Add(pupil);
        }
    }
}
