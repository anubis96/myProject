using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProject
{
    class Semester
    {
        public int NumberOfWeeks { get; set; }
        public string DateStartofSemester { get; set; }

        public Semester(int nofw, string dates)
        {
            NumberOfWeeks = nofw;
            DateStartofSemester = dates;
        }
        public Semester()
        {

        }

    }
}
