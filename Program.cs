using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_END
{
    interface Zav_Cafedra
    {
        public string Name_Zav_Cafedra { set; get; }
        public string Job_Zav_Cafedra { set; get; }
    }
    interface Cafedra
    {
        public string Name_Cafedra { set; get; }
    }
    class Facultet:Cafedra, Zav_Cafedra
    {
        public string Name_facultet { get; set; }
        public string Name_Cafedra { set; get; }
        public string Name_Zav_Cafedra { set; get; }
        public string Job_Zav_Cafedra { set; get; }

        public Facultet() { }
        public Facultet(string Nf, string NC, string NZC, string JZC)
        {
            Name_facultet = Nf;
            Name_Cafedra = NC;
            Name_Zav_Cafedra = NZC;
            Job_Zav_Cafedra = JZC;
        }
    }
    interface Pasvord
    {
        public int ID { set; get; }
        public string Propiska { set; get; }
    }
    interface Headman
    {
        public string Name_Headman { set; get; }
        public int Age_Headman { set; get; }
    }
    interface Prof_Group
    {
        public string Name_ProfCafedra { set; get; }
    }
    class Student:Prof_Group,Headman, Pasvord
    {
        public string Name_Student { set; get; }
        public string Surname { set; get; }
        public string Sex { set; get; }
        public string Place_residence { set; get; }
        public string Name_ProfCafedra { set; get; }
        public string Name_Headman { set; get; }
        public int Age_Headman { set; get; }
        public int ID { set; get; }
        public string Propiska { set; get; }

        public Student() { }
        public Student(string NS, string S, string SeX, string Pr,string NPC, string NH, int Age,  int id , string Prop)
        {
            Name_Student = NS;
            Surname = S;
            Sex = SeX;
            Place_residence = Pr;
            Name_ProfCafedra = NPC;
            Name_Headman = NH;
            Age_Headman = Age;
            ID = id;
            Propiska = Prop;
        }
    }
    class Univer
    {
        public string Name_Univer { get; set; }
        public int Year_Univer { get; set; }
        public string County_Univer { get; set; }

        public Univer() { }
        public Univer(string NU, int YU, string CU)
        {
            Name_Univer = NU;
            Year_Univer = YU;
            County_Univer = CU;
        }

        public void Print()
        {
            Console.WriteLine("Название университета --> "+Name_Univer);
            Console.WriteLine("Год создания университета --> "+ Year_Univer+"год");
            Console.WriteLine("Расположение университета --> "+ County_Univer);
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Univer univer = new Univer();
            univer.Name_Univer = "Step";
            univer.Year_Univer = 2000;
            univer.County_Univer = "Odessa";
            univer.Print();
            Console.WriteLine();
            Console.WriteLine("Факультеты университета\n");
            List<Facultet> facultets = new List<Facultet>()
            {
                new Facultet("Графика и дизайн","Графика и дизайн","Карамоч Александр","Заведует кафедрой графики и дизайна"),
                new Facultet("Програмное обеспечение","Разработка програмного обеспечения","Черкезян Кристина","Заведует кафедрой програмного обеспечения"),
                new Facultet("Киберг безапастность","Киберг безопастность","Акимов Игорь","Заведует кафедрой киберг безопастности")
            };
            foreach (var i in facultets)
            {
                Console.Write(i.Name_facultet);
                Console.Write("\t");
                Console.Write(i.Name_Cafedra);
                Console.Write("\t");
                Console.WriteLine(i.Name_Zav_Cafedra);
                Console.Write("\t");
                Console.Write(i.Job_Zav_Cafedra);
                Console.WriteLine("\t");
            }
            Console.WriteLine("\n");
            List<Student> students = new List<Student>()
            {
                new Student ("Алексей","Петров","Мужчина","Одесса","Программирование","Влад",18, 0213, "Odessa"),
                new Student ("Дмитрий","Шарпило","Мужчина","Киев","Графика и дизайн","Андрей",17,0856, "Lviv"),
                new Student ("Никита","Курганов","Мужчина","Львов","Программирование","Коля",19, 8012, "Odessa"),
                new Student ("Станислав","Домусчи","Мужчина","Одесса","Киберг безопастность","Пётр",18,7012, "Kulevcha"),
            };
            foreach (var t in students)
            {
                Console.WriteLine(t.Name_Student);
                Console.WriteLine("----------------");
                Console.WriteLine(t.Surname);
                Console.WriteLine("----------------");
                Console.WriteLine(t.Sex);
                Console.WriteLine("----------------");
                Console.WriteLine(t.Place_residence);
                Console.WriteLine("----------------");
                Console.WriteLine(t.Name_ProfCafedra);
                Console.WriteLine("----------------");
                Console.WriteLine(t.Name_Headman);
                Console.WriteLine("----------------");
                Console.WriteLine(t.Age_Headman);
                Console.WriteLine("----------------");
                Console.WriteLine(t.ID);
                Console.WriteLine("----------------");
                Console.WriteLine(t.Propiska);
                Console.WriteLine("----------------");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Сортировка по имени");
            foreach (Student i in students)
            {
                Console.WriteLine($"{i.Name_Student}");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Сортировка по кафедре");
            foreach (Student i in students)
            {
                Console.WriteLine($"{i.Name_ProfCafedra}");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Сортировка по ID");
            foreach (Student i in students)
            {
                Console.WriteLine($"{i.ID}");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Сотрировка учителей по именам");
            foreach (Facultet u in facultets)
            {
                Console.WriteLine($"{u.Name_Zav_Cafedra}");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Сотрировка учителей по кафедре ");
            foreach (Facultet u in facultets)
            {
                Console.WriteLine($"{u.Name_Cafedra}");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Сотрировка учителей по факультету ");
            foreach (Facultet u in facultets)
            {
                Console.WriteLine($"{u.Name_facultet}");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Сотрировка по работе зав кафедры ");
            foreach (Facultet u in facultets)
            {
                Console.WriteLine($"{u.Job_Zav_Cafedra}");
            }
            Console.WriteLine("\n");

        }
    }
}
