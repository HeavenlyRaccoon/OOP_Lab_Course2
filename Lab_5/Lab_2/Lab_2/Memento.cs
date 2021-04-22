using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Memento
    {
        public Stack<LecturerMemento> History { get; set; }
        public Memento()
        {
            History = new Stack<LecturerMemento>();
        }
    }

    public class LecturerMemento
    {
        public string Name { get; private set; }

        public LecturerMemento(string name)
        {
            this.Name = name;
        }
    }
}
