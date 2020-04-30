using System;
using System.Collections.Generic;
using System.Text;

namespace MidTerm2OODP_First
{
    class Pupil
    {
        string _pupilName;
        public Pupil(string pupilName)
        {
            _pupilName = pupilName;
        }
        public string Name { get { return _pupilName; } }
    }
}
