using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    abstract class Decorator : Discipline
    {
        public Decorator(string n,Discipline _discpline)
        {
            _discpline.lecturer.name = n;
            this.Clone(_discpline);
        }
    }

    class ChangeLecturer : Decorator
    {
        public ChangeLecturer(Discipline discipline):
            base("Нет лектора", discipline)
        {
        }
    }
}
