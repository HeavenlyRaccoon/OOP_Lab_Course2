using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    interface IBuilder
    {
        Discipline BuildOrder(object obj);
    }

    class OrderBuilder : IBuilder
    {
        public Discipline BuildOrder(object obj)
        {
            Form1 form1 = (Form1)obj;
            Discipline discipline = new Discipline();
            discipline.name = form1.textBox1.Text;
            discipline.semester = form1.Sem;
            discipline.course = form1.trackBar1.Value+1;
            discipline.specialty = form1.comboBox1.Text;
            discipline.countLecture = Convert.ToInt32(form1.textBox2.Text);
            discipline.countLab = Convert.ToInt32(form1.textBox3.Text);
            discipline.test = form1.checkBox1.Checked;
            discipline.exam = form1.checkBox2.Checked;
            discipline.lecturer = new Lecturer();
            discipline.lecturer.department = form1.textBox4.Text;
            discipline.lecturer.name = form1.textBox5.Text;
            discipline.lecturer.auditorium = Convert.ToInt32(form1.textBox6.Text);
            discipline.lecturer.building = form1.build;
            return discipline;
        }
    }
}
