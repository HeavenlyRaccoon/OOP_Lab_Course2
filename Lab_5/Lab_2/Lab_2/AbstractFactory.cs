using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public abstract class AbstractFactory
    {
        public abstract Discipline GetDiscipline(object obj);
    }

    public class Order : AbstractFactory
    {
        public static List<Discipline> disciplines = new List<Discipline>();
        private readonly OrderBuilder orderBuilder = new OrderBuilder();
        public override Discipline GetDiscipline(object obj)
        {
            return orderBuilder.BuildOrder(obj);
        }
    }
}
