using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;

namespace Lab_2
{
    public partial class Form1 : Form
    {
        public int build = 1;
        public int Sem = 1;
        Order order = new Order();
        Memento memento = new Memento();
        public Form1()
        {
            Singleton singleton = Singleton.GetSingleton();
            this.BackColor = singleton.Color;
            this.ForeColor = singleton.ForeColor;
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label3.Text = "Курс: " + (trackBar1.Value + 1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar)&&!(e.KeyChar==' ')&&e.KeyChar!=(char)Keys.Back)
            {
                e.Handled = !Char.IsLetter(e.KeyChar);
                MessageBox.Show("Некорректный символ");
            }
        }

        private void textBox_KeyPress_Digit(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = !Char.IsDigit(e.KeyChar);
                MessageBox.Show("Введите число");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton_Lectour_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                build = Convert.ToInt32(radioButton.Text);
            }
        }

        private void radioButton_Sem_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                Sem = Convert.ToInt32(radioButton.Text);
            }
        }

        private void nameLesson_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, "Поле пустое!");
                e.Cancel = true;
            }
            else if (textBox1.Text.Length < 2)
            {
                errorProvider1.SetError(textBox1, "Слишком маленькое название!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.Clear();
                e.Cancel = false;
            }
        }

        private void nameDepartment_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBox4.Text))
            {
                errorProvider1.SetError(textBox4, "Поле пустое!");
                e.Cancel = true;
            }
            else if (textBox1.Text.Length < 3)
            {
                errorProvider1.SetError(textBox4, "Слишком маленькое название!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.Clear();
                e.Cancel = false;
            }
        }

        private void Digit_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (String.IsNullOrEmpty(textBox.Text))
            {
                errorProvider1.SetError(textBox, "Поле пустое!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.Clear();
                e.Cancel = false;
            }
        }

        private void name_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBox5.Text))
            {
                errorProvider1.SetError(textBox5, "Поле пустое!");
                e.Cancel = true;
            }
            else if (textBox5.Text.Length < 10)
            {
                errorProvider1.SetError(textBox5, "Слишком мало символов");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.Clear();
                e.Cancel = false;
            }
        }

        private void Specialization_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(comboBox1.Text))
            {
                errorProvider1.SetError(comboBox1, "Выберите специальность");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.Clear();
                e.Cancel = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                //Lecturer lecturer = new Lecturer(textBox4.Text, textBox5.Text,Convert.ToInt32(textBox6.Text),build);
                //Discipline discipline = new Discipline(textBox1.Text, Sem, trackBar1.Value + 1, comboBox1.Text, Convert.ToInt32(textBox2.Text),
                //    Convert.ToInt32(textBox3.Text), checkBox1.Checked, checkBox2.Checked, lecturer);
                //Disciplines.disciplines.Add(discipline);
                Discipline discipline = order.GetDiscipline(this);
                Order.disciplines.Add(discipline);
                textBox7.Text += $"Дисциплина: {discipline.name}\r\nСеместр: {discipline.semester}\r\nКурс: {discipline.course}\r\n" +
                    $"Специальность: {discipline.specialty}\r\nКоличество лекций: {discipline.countLecture}\r\n" +
                    $"Количество лабораторных: {discipline.countLab}\r\nЗачет: {discipline.test}\r\nЭкзамен: {discipline.exam}\r\n" +
                    $"Кафедра: {discipline.lecturer.department}\r\nФИО лектора: {discipline.lecturer.name}\r\n" +
                    $"Аудитория: {discipline.lecturer.auditorium}\r\nКорпус: {discipline.lecturer.building}\r\n\r\n";
            }
            else
            {
                MessageBox.Show("Не все поля зполнены корректно!");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox7.Clear();
            Order.disciplines.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Order.disciplines.Count == 0)
            {
                MessageBox.Show("Вы ничего не добавили!");
            }
            else
            {
                using (FileStream stream = new FileStream("discipline.json", FileMode.Create))
                {
                    JsonSerializer.SerializeAsync<List<Discipline>>(stream,Order.disciplines);
                    MessageBox.Show("Сохранено");
                    stream.Close();
                }
                Order.disciplines.Clear();
                textBox7.Clear();
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            Order.disciplines.Clear();
            try
            {
                using (FileStream stream = new FileStream("discipline.json", FileMode.OpenOrCreate))
                {
                    while (stream.Position < stream.Length)
                    {
                        stream.Position = 0;
                        Order.disciplines = await JsonSerializer.DeserializeAsync<List<Discipline>>(stream);
                    }
                    stream.Close();
                }
                MessageBox.Show("Загружено");
                textBox7.Clear();
                foreach (var item in Order.disciplines)
                {

                    textBox7.Text += $"Дисциплина: {item.name}\r\nСеместр: {item.semester}\r\nКурс: {item.course}\r\n" +
                        $"Специальность: {item.specialty}\r\nКоличество лекций: {item.countLecture}\r\n" +
                        $"Количество лабораторных: {item.countLab}\r\nЗачет: {item.test}\r\nЭкзамен: {item.exam}\r\n" +
                        $"Кафедра: {item.lecturer.department}\r\nФИО лектора: {item.lecturer.name}\r\n" +
                        $"Аудитория: {item.lecturer.auditorium}\r\nКорпус: {item.lecturer.building}\r\n\r\n";
                }
            }
            catch
            {
                MessageBox.Show("Не удалось открыть файл");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Discipline discipline = Order.disciplines.Last().Clone();
            Order.disciplines.Add(discipline);
            textBox7.Text += $"Дисциплина: {discipline.name}\r\nСеместр: {discipline.semester}\r\nКурс: {discipline.course}\r\n" +
                    $"Специальность: {discipline.specialty}\r\nКоличество лекций: {discipline.countLecture}\r\n" +
                    $"Количество лабораторных: {discipline.countLab}\r\nЗачет: {discipline.test}\r\nЭкзамен: {discipline.exam}\r\n" +
                    $"Кафедра: {discipline.lecturer.department}\r\nФИО лектора: {discipline.lecturer.name}\r\n" +
                    $"Аудитория: {discipline.lecturer.auditorium}\r\nКорпус: {discipline.lecturer.building}\r\n\r\n";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Discipline discipline = Order.disciplines.Last();
            memento.History.Push(discipline.SaveState());
            Order.disciplines.Remove(discipline);
            discipline = new ChangeLecturer(discipline);
            Order.disciplines.Add(discipline);
            textBox7.Clear();
            foreach (var item in Order.disciplines)
            {

                textBox7.Text += $"Дисциплина: {item.name}\r\nСеместр: {item.semester}\r\nКурс: {item.course}\r\n" +
                    $"Специальность: {item.specialty}\r\nКоличество лекций: {item.countLecture}\r\n" +
                    $"Количество лабораторных: {item.countLab}\r\nЗачет: {item.test}\r\nЭкзамен: {item.exam}\r\n" +
                    $"Кафедра: {item.lecturer.department}\r\nФИО лектора: {item.lecturer.name}\r\n" +
                    $"Аудитория: {item.lecturer.auditorium}\r\nКорпус: {item.lecturer.building}\r\n\r\n";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Discipline discipline = Order.disciplines.Last();
            Order.disciplines.Remove(discipline);
            discipline.RestoreState(memento.History.Pop());
            Order.disciplines.Add(discipline);
            textBox7.Clear();
            foreach (var item in Order.disciplines)
            {

                textBox7.Text += $"Дисциплина: {item.name}\r\nСеместр: {item.semester}\r\nКурс: {item.course}\r\n" +
                    $"Специальность: {item.specialty}\r\nКоличество лекций: {item.countLecture}\r\n" +
                    $"Количество лабораторных: {item.countLab}\r\nЗачет: {item.test}\r\nЭкзамен: {item.exam}\r\n" +
                    $"Кафедра: {item.lecturer.department}\r\nФИО лектора: {item.lecturer.name}\r\n" +
                    $"Аудитория: {item.lecturer.auditorium}\r\nКорпус: {item.lecturer.building}\r\n\r\n";
            }
        }
    }

    public class Discipline : Prototype
    {
        public string name { get; set; }
        public int semester { get; set; }
        public int course { get; set; }
        public string specialty { get; set; }
        public int countLecture { get; set; }
        public int countLab { get; set; }
        public bool test { get; set; }
        public bool exam { get; set; }
        public Lecturer lecturer { get; set; }

        public Discipline()
        {
        }

        public override Discipline Clone()
        {
            Discipline newDiscipline = new Discipline();
            newDiscipline.name = this.name;
            newDiscipline.semester = this.semester;
            newDiscipline.course = this.course;
            newDiscipline.specialty = this.specialty;
            newDiscipline.countLecture = this.countLecture;
            newDiscipline.countLab = this.countLab;
            newDiscipline.test = this.test;
            newDiscipline.exam = this.exam;
            newDiscipline.lecturer = new Lecturer();
            newDiscipline.lecturer.department = this.lecturer.department;
            newDiscipline.lecturer.name = this.lecturer.name;
            newDiscipline.lecturer.auditorium = this.lecturer.auditorium;
            newDiscipline.lecturer.building = this.lecturer.building;

            return newDiscipline;
        }

        public Discipline Clone(Discipline discipline)
        {
            this.name = discipline.name;
            this.semester = discipline.semester;
            this.course = discipline.course;
            this.specialty = discipline.specialty;
            this.countLecture = discipline.countLecture;
            this.countLab = discipline.countLab;
            this.test = discipline.test;
            this.exam = discipline.exam;
            this.lecturer = new Lecturer();
            this.lecturer.department = discipline.lecturer.department;
            this.lecturer.name = discipline.lecturer.name;
            this.lecturer.auditorium = discipline.lecturer.auditorium;
            this.lecturer.building = discipline.lecturer.building;

            return this;
        }

        public LecturerMemento SaveState()
        {
            LecturerMemento lecturerMemento = new LecturerMemento(this.lecturer.name);
            return lecturerMemento;
        }

        // восстановление состояния
        public void RestoreState(LecturerMemento memento)
        {
            this.lecturer.name = memento.Name;
        }
    }

    public class Lecturer
    {
        public string department { get; set; }
        public string name { get; set; }
        public int auditorium { get; set; }
        public int building { get; set; }

        //public Lecturer(string dep, string _name, int aud, int build)
        //{
        //    department = dep;
        //    name = _name;
        //    auditorium = aud;
        //    building = build;
        //}
        public Lecturer()
        {
        }
    }

    
}
