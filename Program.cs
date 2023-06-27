using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace tasks18
{
    public class Program
    {
        public static void Main()
        {
            //1
            //Console.WriteLine("Введите вашу фамилию: ");
            //string n = Console.ReadLine();
            //Console.WriteLine("Введите оценку которую хотите получить за экзамен: ");
            //int m = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Поздравляю {n} ваша оценка за экамен {m} !");

            //2
            //Console.WriteLine("Введите количество чисел: ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //List<int> list = new List<int>();
            //float sum = 0;
            //for(int i = 1; i <= a; i++)
            //{
            //    Console.WriteLine($"Введите число {i}: ");
            //    int n = Convert.ToInt32(Console.ReadLine());
            //    list.Add(n);
            //    sum += n;
            //}

            //Console.WriteLine(sum);

            //Console.WriteLine(sum / a);
            //Console.WriteLine(Math.Round(sum / a));
            //Console.WriteLine(Math.Floor(sum / a));

            //3
            //Console.WriteLine("Введите пароль: ");
            //bool strCheck = false;
            //bool numCheck = false;
            //bool upCheck = false;
            //bool lowCheck = false;
            //bool specCheck = false;

            //while (true)
            //{
            //    string password = Console.ReadLine();

            //    for(int i  = 0; i < password.Length; i++)
            //    {
            //        if (Char.IsDigit(password[i]))
            //            numCheck = true;
            //        if (Char.IsLetter(password[i]))
            //            strCheck = true;
            //        if (Char.IsUpper(password[i]))
            //            upCheck = true;
            //        if (Char.IsLower(password[i]))
            //            lowCheck = true;
            //        if (!Char.IsLetterOrDigit(password[i]))
            //            specCheck = true;
            //    }
            //    if (password.Length <= 8)
            //        Console.WriteLine("Пароль должен быть больше 8 символов!");
            //    else if (password.Length > 20)
            //        Console.WriteLine("Пароль должен быть меньше 20 символов!");
            //    else if (numCheck == false)
            //        Console.WriteLine("В пароле должны быть цифры");
            //    else if (strCheck == false)
            //        Console.WriteLine("В пароле должны быть буквы");
            //    else if (upCheck == false)
            //        Console.WriteLine("В пароле должны быть большие буквы");
            //    else if (lowCheck == false)
            //        Console.WriteLine("В пароле должны быть маленькие буквы");
            //    else if (specCheck == false)
            //        Console.WriteLine("В пароле должны быть спец символы");
            //    else 
            //    { 
            //        Console.WriteLine("Все ок! "); break; 
            //    }
            //}

            //4
            int sum = 0;
            int i = 0;
            while (i < 3)
            {
                Random rnd = new Random();

                int a = rnd.Next(1, 5);
                int b = rnd.Next(1, 5);
                int c = rnd.Next(1, 5);

                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(c);
                Console.WriteLine($"Введите число:  {i + 1}");

                int x = Convert.ToInt32(Console.ReadLine());

                if (x == a || x == b || x == c)
                {
                    sum = sum + 1;
                }
                i++;
            }
            if (sum < 2)
                Console.WriteLine("Вы проебали");
            else if (sum >= 2)
                Console.WriteLine("Вы выиграли");

            //5
            //Random rnd = new Random();
            //int a = rnd.Next(0, 7);
            //float cena = rnd.Next(50, 100);
            //int srok = rnd.Next(1, 14);
            //Console.WriteLine(cena);
            //DateTime datet = DateTime.Now.Date;
            //DateTime dater = datet.AddDays(-a).Date;
            //DateTime darek = dater.AddDays(srok).Date;

            //Console.WriteLine($"Дата изготовления: {dater}");
            //Console.WriteLine($"Дата конца: {darek}");

            //if (dater == datet)
            //    Console.WriteLine($"Цена: {cena}");
            //else if (darek < DateTime.Now)
            //    Console.WriteLine($"Цена: {cena * 0}");
            //else 
            //    Console.WriteLine($"Цена: {cena * 0.8}");
            //7
            //List<object> marks = new List<object>() { "Б", "П", "Н", 2, 3, 4, 5 };
            //Random rnd = new Random();
            //int bolel = 0;
            //List<object> bolelo = new List<object>() { };
            //for (int i = 1; i < 11; i++)
            //{
            //    object mark = marks[rnd.Next(marks.Count)];
            //    DateTime date1 = DateTime.Today;
            //    Console.WriteLine($"{date1.AddDays(i)} {mark}");
            //    if (mark == "Б" && DateTime.Today.Month == date1.AddDays(i).Month)
            //    {
            //        bolelo.Add(date1.AddDays(i));
            //        bolelo.Add(mark);
            //        bolel = bolel + 1;
            //    }
            //}
            //Console.WriteLine("bolel: " + bolel);
            //foreach (var person in bolelo)
            //{
            //    Console.WriteLine("Дата болезни: " + person);
            //}

            //6
            var person_dict = new Dictionary<string, List<object>> ()
            {
                { "person_id" , new List<object>() { 41, 84, 72}},
                { "person_name",new List<object>() {"Keanu Reeves", "Jim Carrey", "IshowSpeed" } }
            };

            var travel_log = new Dictionary<string, List<object>>()
                 {
                     { "travel_id", new List<object>() { 101, 102, 105 } },
                     { "person_id", new List<object>() { 41, 72, 41 } },
                     { "country", new List<object>() { "USA", "Japan", "China" } }
                 };

            Console.WriteLine("Введите имя: ");
            string name = Console.ReadLine();

            int count = 0;
            int dcount = 0;
            for (int i = 0;  i < person_dict["person_name"].Count; i++)
            {
                if(name == Convert.ToString(person_dict["person_name"][i]))
                {
                    for (int j = 0; j < travel_log["person_id"].Count; j++)
                    {
                        if (Convert.ToInt32(person_dict["person_id"][i]) == Convert.ToInt32(travel_log["person_id"][j]))
                        {
                            count ++;
                            dcount = j;
                        }
                    }
                }
            }

            if(count == 2)
            {
                Console.WriteLine("много");
            }
            else if (count == 1)
            {
                Console.WriteLine(travel_log["country"][dcount]);
            }
            else
            {
                Console.WriteLine("Отдыхает");
            }
            //8
            //Students stud1 = new Students();
            //stud1.setStudent(new List<object>(), 2005, "Andrew Popov");
            //Students stud2 = new Students();
            //stud2.setStudent(new List<object>(), 2005, "Vasya Ostrovsky");
            //Students stud3 = new Students();
            //stud3.setStudent(new List<object>(), 2005, "Alina Kyzimka");
            //Students stud4 = new Students();
            //stud4.setStudent(new List<object>(), 2005, "Anastasia Belkina");
            //// stud1.printStudents();
            //stud1.genetareStudents();
            //stud2.genetareStudents();
            //// stud3.genetareStudents();
            //// stud4.genetareStudents();
            //Group group1 = new Group();
            //group1.Append(stud1);
            //group1.Append(stud2);
            //// group1.Append(stud3);
            //// group1.Append(stud4);
            //group1.printGroup();

        }
    }
}
//class Students
//{
//    private static int count;
//    public List<object> marksST = new List<object>();
//    public int years;
//    public string FIO;

//    public void setStudent(List<object> marksST, int years, string FIO)
//    {
//        this.marksST = marksST;
//        this.years = years;
//        this.FIO = FIO;
//    }

//    public void printStudents()
//    {
//        Console.WriteLine($"Студент {this.FIO} год посутпления {this.years}");
//    }

//    public void genetareStudents()
//    {
//        List<object> marks = new List<object>() { "Б", "П", "Н", 2, 3, 4, 5 };
//        Random rnd = new Random();
//        for (int i = 1; i < 11; i++)
//        {
//            object mark = marks[rnd.Next(marks.Count)];
//            DateTime date1 = DateTime.Today;
//            Console.WriteLine($"{date1.AddDays(i)} {mark} {this.FIO}");
//            this.marksST.Add(date1.AddDays(i));
//            this.marksST.Add(mark);
//        }
//    }
//}

//class Group
//{

//    public List<Students> group = new List<Students>();

//    public void setGroup(List<Students> group = null)
//    {
//        this.group = new List<Students>();
//    }

//    public void printGroup()
//    {
//        foreach (var person in this.group)
//        {
//            Console.WriteLine($"Студент {person.FIO} год поступления {person.years}");
//        }
//    }

//    public void Append(Students stud)
//    {
//        this.group.Add(stud);
//    }

//}