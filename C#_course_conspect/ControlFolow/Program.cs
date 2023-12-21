
using System.Diagnostics.Metrics;
using System.Diagnostics.SymbolStore;
using System.Globalization;

namespace ControlFlow {
    internal class Program
    {
        static void Main(string[] args)
        {
            BreackContinu();
            Console.ReadKey();
        }

        static void ConditionalExpressions()
        {
            Console.WriteLine("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your weight :");
            double weight = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Enter your Height: ");
            double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double result = IMT(weight, height);
            Console.WriteLine(result);

            bool isTooLow = result <= 18.5;
            bool isNormal = result > 18.5 && result < 25;
            bool isAboveNormal = result >= 25 && result <= 30;//Логическое и 
            bool isTooFat = result > 30;

            bool isFat = isAboveNormal || isTooFat;//Логическое или 

            if (isFat)
            {
                Console.WriteLine("You need to loose some weight.");
            }
            else
            {
                Console.WriteLine("Oh you are in a good shape!");
            }

            if (!isFat)
            {
                Console.WriteLine("You are definitely not Fat!");
            }

            if (isTooLow)//пример нескольких обработок
            {
                Console.WriteLine("Not enugh weight!");
            }
            else if (isNormal)
            {
                Console.WriteLine("You are ok.");
            }
            else if (isAboveNormal)
            {
                Console.WriteLine("Be careful!");
            }
            else
            {
                Console.WriteLine("You need to loose some weight");
            }

            if (isFat || isTooFat)
            {
                Console.WriteLine("Diet Time!!!");
            }

            //тернарный условный оператор
            string description = age > 18 ? "You can drink alco" : "You should get a bit older!";
            Console.WriteLine(description);
            //Он заменяет такие записи 
            if (age > 18)
            {
                Console.WriteLine("You can drink alco");
            }
            else
            {
                Console.WriteLine("You should get a bit older");
            }
            Console.WriteLine(description);
            //---------

            double IMT(double w, double h)
            {
                double imt = w / (h * h);

                return imt;
            }
        }

        static void HomeWork4()
        {
            Console.WriteLine("Введите два целочисленых числа");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int c = a > b? a : b;
            Console.WriteLine(c);
        }

        static void loops()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            for(int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
            ///
            for(int i = numbers.Length - 1; i>= 0; i--)
            {
                Console.Write(numbers[i] + " ");
            }
            ///
            Console.WriteLine();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
            Console.WriteLine();
            ///
            foreach(int val in numbers)
            {
                Console.Write(val + " ");
            }
        }

        static void Nestedloop()
        {
            int[] numbers = { 1, -2, 4, -7, 5, 3, 2, -1, -3, 2, 7, -1, -3, 1, 7 };

            //Выводим пары чисел , сумма которых = 0
            for (int i = 0; i < numbers.Length; i++)
            {
                for(int j = i +1; j<numbers.Length; j++)
                {
                    int atI = numbers[i];
                    int atJ = numbers[j];
                    
                    if(atI + atJ == 0)
                    {
                        Console.WriteLine($"Pair ({atI},{atJ}). Indexes ({i},{j})");
                    }
                }
            }

            //НАйдем все тройки чисел что в сумме дадут 0
            for (int i = 0; i < numbers.Length - 2; i++)
            {
                for (int j = i + 1; j < numbers.Length - 1; j++)
                {
                    for (int k = j + 1; k < numbers.Length; k++)
                    {
                        int atI = numbers[i];
                        int atJ = numbers[j];
                        int atK = numbers[k];
                        if (atI + atJ + atK== 0)
                        {
                            Console.WriteLine($"Triplets ({atI},{atJ},{atK}). Indexes ({i},{j},{k})");
                        }
                    }
                }
            }
        }

        static void WhileDoWhile()
        {
            int age = 0;
            while(age < 18)
            {
                Console.WriteLine("What is your age");
                age = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Good");

            do
            {
                Console.WriteLine("What is your age");
                age = int.Parse(Console.ReadLine());
            }
            while (age < 18);
        } 

        static void BreackContinu()
        {
            int[] numbers2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, };

            foreach(int n in numbers2)
            {
                /* if(n % 2 == 0)
                 {
                     Console.WriteLine(n);
                 }*/
                if (n % 2 != 0)
                    continue;

                Console.WriteLine(n);
            }

            Console.ReadLine();
            int[] numbers1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, };
            char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k' , 'l'};

            for(int i = 0;i < numbers1.Length; i++)
            {
                Console.WriteLine(numbers1[i]);
                for(int j = 0;j < letters.Length; j++)
                {
                    if (numbers1[i] == j)
                        break;
                    Console.WriteLine($"Letters : {letters[j]}");
                }
            }

            Console.ReadLine();
            int[] numbers = { 1, -2, 4, -7, 5, 3, 2, -1, -3, 2, 7, -1, -3, 1, 7 };

            //Выводим пары чисел , сумма которых = 0
            int counter = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (counter == 3)
                    break;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int atI = numbers[i];
                    int atJ = numbers[j];

                    if (atI + atJ == 0)
                    {
                        Console.WriteLine($"Pair ({atI},{atJ}). Indexes ({i},{j})");
                        counter++;
                    }
                    if (counter == 3)
                        break;
                }
            }
        }
    }
}
