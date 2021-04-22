using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab_2
{
    class Singleton
    {
        private static Singleton singleton;
        public Color Color { get; set; }
        public Color ForeColor { get; set; }

        private Singleton()
        {
            Color = Color.WhiteSmoke;
            ForeColor = Color.Black;
        }

        public static Singleton GetSingleton()
        {
            return singleton ?? (singleton = new Singleton());
        }
    }
}
