using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace temp {
    internal class Program {
        private static bool endWith;

        static void Main(string[] args)
        {
            HomeWork3();
            Console.ReadKey();
        }

        static void variables()
        {
            int x = -1;
            int y;

            Int32 x1 = -1;

            Console.WriteLine(x1);
            Console.ReadKey();

            uint q = 1;

            float f = 1.1f;

            double c = 2.3;

            var a = 1;
            var b = "123";

            //Dictionary<int, string> dict = new Dictionary<int, string>();   
            var dict = new Dictionary<int, string>();

            decimal money = 12321.73m;//постфик m явно указав компилятору что это money

            char ch = 'a';
            string name = "Bob";

            bool canDrive = true;

            object ob = 1;
            object obs = "123"; //Так использовать обджект нельзя

            Console.WriteLine();

        }
        static void literals()
        {
            int k = 0b10101010000110;
            Console.WriteLine(k);

            k = 0x1FAB30EF;
            Console.WriteLine(k);
            Console.ReadKey();
        }

        static void OverFlow()
        {
            checked{
                uint max = uint.MaxValue;
                Console.WriteLine(max);

                max = max + 1;
                Console.WriteLine(max);

                max = max - 1;
                Console.WriteLine(max);

                decimal maxd = decimal.MaxValue;
                Console.WriteLine(maxd);
            }
        }

        static void IncrementDecrementDemo() {
            int x = 1;
            x = x + 1;
            Console.WriteLine(x);

            x++;
            Console.WriteLine(x);

            ++x;
            Console.WriteLine(x);

            x = x - 1;
            x--;
            --x;

            Console.WriteLine(x);

            Console.WriteLine("Lern about increments");
            Console.WriteLine($"Last state of x : {x}");

            int j = x++;
            Console.WriteLine(j);
            Console.WriteLine(x);

            j = ++x;
            Console.WriteLine(j);
            Console.WriteLine(x);

            x += 2;
            Console.WriteLine(x);

            j -= 2;
            Console.WriteLine(j);
        }

        static void StringAPI()
        {
            string name = "abcdhcj";
            bool endWith = name.EndsWith("d");
            Console.WriteLine(endWith);

            string name1 = "abcd";
            bool startWith = name.StartsWith("a");
            Console.WriteLine(endWith);

            int indexOfname = name.IndexOf("c");
            Console.WriteLine(indexOfname);

            int lastIndexOf = name.LastIndexOf("c");
            Console.WriteLine(lastIndexOf);

            Console.WriteLine(name.Length);
        }

        static void EmptyString()
        {
            string empty = "";
            string space = " ";
            string notEmpty = " b";
            string nullString = null;

            Console.WriteLine("IS NULL OR EMPTY");
            bool state = string.IsNullOrEmpty(nullString);
            Console.WriteLine(state);

            state = string.IsNullOrEmpty(space);
            Console.WriteLine(state);

            state = string.IsNullOrEmpty(empty);
            Console.WriteLine(state);

            state = string.IsNullOrEmpty(notEmpty);
            Console.WriteLine(state);

            Console.WriteLine("Is null or withe spaced\n");

            bool isNullOrWiteSpace = string.IsNullOrWhiteSpace(nullString);
            Console.WriteLine($" nullString : {isNullOrWiteSpace}");

            isNullOrWiteSpace = string.IsNullOrWhiteSpace(notEmpty);
            Console.WriteLine($" notEmpty : {isNullOrWiteSpace}");

            isNullOrWiteSpace = string.IsNullOrWhiteSpace(space);
            Console.WriteLine($" space : {isNullOrWiteSpace}");

            isNullOrWiteSpace = string.IsNullOrWhiteSpace(empty);
            Console.WriteLine($" empty : {isNullOrWiteSpace}");

            string str = string.Empty; // Vozvrachaet takuy stroku ""
        }

        static void StringModification()
        {
            string nameConcat = string.Concat("My ", "Name ", "is ", "Bob");
            Console.WriteLine(nameConcat);

            nameConcat = string.Join(" ", "My", "Name", "Bob"); // просто проставляет пробелы между обьединяемых строк
            Console.WriteLine(nameConcat);

            string nameName = nameConcat.Insert(0, "By the way , ");//ТАК РАБОТАЕТ
            nameConcat.Insert(0, "By the way , ");// ТАК НЕ РАБОТАЕТ

            nameConcat = nameConcat.Remove(0, 1);
            Console.WriteLine(nameConcat);

            string replaced = nameConcat.Replace('n', 'z');
            Console.WriteLine(nameConcat);

            string data = "12;28;34;11;56;73";
            string[] splitData = data.Split(';');
            string first = splitData[0];
            Console.WriteLine(first);

            char[] chars = nameConcat.ToCharArray();
            Console.WriteLine("\n масив который мы получим : ");
            int n = chars.Length;
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(chars[i]);
            }

            string toRegistr = "\nmy name is pasha";
            toRegistr.ToLower();
            Console.WriteLine(toRegistr);
            toRegistr.ToUpper();
            Console.WriteLine(toRegistr);

            string noTrim = "  bara bu dai dabudi dabudai  ";
            Console.WriteLine(noTrim);
            string votTeperTrim = noTrim.Trim();
            Console.WriteLine(votTeperTrim);
        }

        static void _StringBuilder()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("My ");
            sb.Append("Name ");
            sb.Append("Bogdan ");
            sb.AppendLine("!");
            sb.AppendLine("Hi!");
            Console.WriteLine(sb);

            string sbString = sb.ToString();
            Console.WriteLine(sbString);
        }

        static void StringFormat()
        {
            string name = "Jhon";
            int age = 33;
            string str1 = string.Format("My name is {0} and im {1}", name, age);
            Console.WriteLine(str1);

            string str2 = "My name is \n Jhon";
            str2 = $"My name is {Environment.NewLine}Jhon";//работает корректно под всеми ОС
            Console.WriteLine(str2);

            string str3 = @"C:\tmp\test_file.txt";
            Console.WriteLine(str3);

            int answer = 42;
            string result = string.Format("{0:d}" , answer);
            Console.WriteLine(result);

            string result2 = string.Format("{0:d4}", answer);
            Console.WriteLine(result2);

            result = string.Format("{0:f}", answer);
            result2 = string.Format("{0:f4}", answer);
            Console.WriteLine(result);
            Console.WriteLine(result2);
        }

        static void ConsoleWorck()
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Please enter your age : ");
            string input = Console.ReadLine();  
            int age = int.Parse(input);//Раьотает как ToString() только в инт

            string sentence = $"Your age is {age}";
            Console.WriteLine(sentence);
        } 

        static void Cast()
        {                   //вид в памяти 
            byte b = 3;//0000 0011
            int i = b;//0000 0000 0000 0000 0000 0000 0000 0011
            long l = i;

            b = (byte)i;//и есть так званое явное приведение типов 

            float f = 3.1f;
            i = (int)f;
            Console.WriteLine(i);//происходит потеря точности 

            int x = 5;
            int result = x / 2;
            Console.WriteLine(result);//Не происходит приведение типов 

            double result2 = (double)x / 2;
            Console.WriteLine(result2); //если мі result2 обьявим как double , єто не поможет . Потому что сначала 
            //происходит x / 2 а уже потом присваевается в переменную , явное преведение имеет больший приоритет чем
            //x / 2 поєтому оно решает єту проблему 
        }

        static void MathClass()
        {
            Console.WriteLine(Math.Pow(2,3));// 8
            Console.WriteLine(Math.Sqrt(9));// 3
            Console.WriteLine(Math.Sqrt(8));// вернет некий double

            Console.WriteLine(Math.Round(1.5));//2
            Console.WriteLine(Math.Round(1.4));//1

            Console.WriteLine(Math.Round(2.5));//2
            Console.WriteLine(Math.Round(2.5 ,MidpointRounding.AwayFromZero));//3
            Console.WriteLine(Math.Round(2.5, MidpointRounding.ToEven));//2
        }

        static void Arrays()
        {
            int[] a1;
            a1 = new int[10];//Выделили память под 10 елементов инт

            int[] a2 = new int[5];

            int[] a3 = new int[5] { 1, 3, -2, 4, 5 };

            int[] a4 = { 1 ,2, 2, 3, 4, 5 };

            Console.WriteLine(a4[0]);

            int number = a1[2];
            Console.WriteLine(number);

            a4[4] = 10;
            Console.WriteLine(a4[4]);

            Console.WriteLine(a2.Length);//выведет длинну масива
            Console.WriteLine(a4[a4.Length - 1]);// обращается к последнему элемента масива

            string s1 = "qwertyuio";
            char first = s1[0];
            Console.WriteLine(first);

        }

        static void APIDateTime()
        {
            DateTime dateTime= DateTime.Now;

            Console.WriteLine(dateTime.ToString());
            Console.WriteLine(dateTime);

            Console.WriteLine(dateTime.Date);//Забираем с переменной только дату 

            DateTime dt = new DateTime(2016,2,28);//Передал при создание переменной год месяц и дату
            Console.WriteLine(dt);

            DateTime newDt = dt.AddDays(1);
            Console.WriteLine(newDt);

            Console.WriteLine(newDt.AddDays(1003));//DateTime знает как работать с календарями

            TimeSpan ts = newDt - dt;
            //ts = dt.Subtract(newDt);
            Console.WriteLine(ts.Days);//выводит разницу в днях
        }

        static void HomeWork1()
        {

            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}");

            Console.WriteLine("Enter a: ");
            int x = int.Parse( Console.ReadLine() );
            Console.WriteLine("ENter b");
            int y = int.Parse( Console.ReadLine() );
            Console.WriteLine(x +" " + y);

            int temp = x;
            x = y;
            y = temp;

            Console.WriteLine(x + " " + y);

            Console.WriteLine("\n");
            Console.WriteLine("Enter number: ");
            int number = int.Parse( Console.ReadLine() );
            Console.WriteLine(number.ToString().Length);
        }

        static void HomeWork2()
        {
            Console.WriteLine("Введите длинну трех сторон треугольник");
            double l1 = double.Parse(Console.ReadLine());
            double l2 = double.Parse(Console.ReadLine());
            double l3 = double.Parse(Console.ReadLine());

            double result = Geron(l1 ,l2, l3);

            Console.WriteLine($"S = {result}");

            double Geron(double a , double b, double c)
            {
                double p = (a + b + c) / 2;
                double S = Math.Sqrt(p*(p-a)*(p - b)*(p - c));
                return S;
            }
        }

        static void HomeWork3()
        {
            Console.WriteLine("Enter your surename: ");
            string surName = Console.ReadLine();
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your age: ");
            int age = int.Parse( Console.ReadLine() );
            Console.WriteLine("Enter your weight :");
            double weight = double.Parse( Console.ReadLine());
            Console.WriteLine("Enter your Height: ");
            double height = double.Parse(Console.ReadLine());//tryparse

            double result = IMT(weight, height);
            Console.WriteLine(result);

            double  IMT(double w , double h)
            {
                double imt = w / (h * h);
                return imt;
            }
        }
    }
}
