using Lab.classes;
using System;
using System.Collections;

namespace Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ПЕРЕГРУЗКА ОПЕРАЦИЙ

            //SumOperation();

            //Console.WriteLine("--------------------");

            //SubOperation();

            //Console.WriteLine("--------------------");

            //MoreOperation();

            //Console.WriteLine("--------------------");

            //LessOperation();

            //Console.WriteLine("--------------------");

            //IncrementOperation();

            //Console.WriteLine("--------------------");

            //DecrementOperation();

            //Console.WriteLine("--------------------");

            //TrueOperation();

            //Console.WriteLine("--------------------");

            //FalseOperation();

            #endregion

            #region ВЛОЖЕННЫЕ ТИПЫ
            //CreateNestedObject();
            #endregion

            #region СТАТИЧЕСКИЙ КЛАСС И МЕТОДЫ РАСШИРЕНИЯ
            WorkWithStaticClass();

            Console.WriteLine("-----------------------");

            WorkWithStringExtension();
            #endregion
        }

        public static void WorkWithStringExtension()
        {
            string word = "hello";
            char letter = 'y';
            string[] words = new string[] { "short", "byte", "decimal" };
            string wordWithNum = "hel1l2";

            int resultCount = StringExtension.CharCount(word, letter);

            Console.WriteLine("Word = {0}, count letters - \"{1}\": {2}", word, letter, resultCount);

            bool resultCheck = StringExtension.CharCheck(word, letter);

            Console.WriteLine("Word = {0}, check letter - \"{1}\": {2}", word, letter, resultCheck);

            string resultString = StringExtension.RemoveVowels(word);

            Console.WriteLine("Word = {0}, without vowels: {1}", word, resultString);

            string resultShortString = StringExtension.GetShortString(words);

            Console.WriteLine("Short word: {0}", resultShortString);

            string resultLongString = StringExtension.GetLongString(words);

            Console.WriteLine("Long word: {0}", resultLongString);

            int resultNum = StringExtension.GetFirstNum(wordWithNum);

            Console.WriteLine("Word: {0}, First Num: {1}", wordWithNum, resultNum);
        }

        public static void WorkWithStaticClass()
        {
            int resultSum = StaticOperation.Sum(1, 2);

            Console.WriteLine("Result Sum: {0}", resultSum);

            int resultSub = StaticOperation.Sub(new int[] { 1, 2, 3 });

            Console.WriteLine("Result Sub: {0}", resultSub);

            int resultCount = StaticOperation.Count(new int[] { 1, 2, 3 });

            Console.WriteLine("Result Count: {0}", resultCount);
        }

        public static void CreateNestedObject()
        {
            Book book = new Book { Name = "Book", Author = "Eduard" };

            Book.Price price = new Book.Price { Cost = 1000 };

            Book.Date date = new Book.Date { Create = DateTime.Now };

            Console.WriteLine($"Book name: {book.Name}\n" +
                $"Author: {book.Author}\n" +
                $"Price: {price.Cost}\n" +
                $"Date: {date.Create}\n");
        }

        public static void SumOperation()
        {
            Calculator c1 = new Calculator(1);
            Calculator c2 = new Calculator(3);

            Calculator c3 = c1 + c2;

            Console.WriteLine(c3);
        }

        public static void SubOperation()
        {
            Calculator c1 = new Calculator(1);
            Calculator c2 = new Calculator(3);

            Calculator c3 = c1 - c2;

            Console.WriteLine(c3);
        }

        public static void MoreOperation()
        {
            Calculator c1 = new Calculator(1);
            Calculator c2 = new Calculator(2);

            bool result = c1 > c2;

            Console.WriteLine("{0} > {1}: {2}", c1.Value, c2.Value, result);
        }

        public static void LessOperation()
        {
            Calculator c1 = new Calculator(1);
            Calculator c2 = new Calculator(2);

            bool result = c1 < c2;

            Console.WriteLine("{0} < {1}: {2}", c1.Value, c2.Value, result);
        }

        public static void IncrementOperation()
        {
            Calculator c1 = new Calculator(1);

            Calculator c2 = c1++;

            Console.WriteLine("Decrement: {0}", c2);
        }

        public static void DecrementOperation()
        {
            Calculator c1 = new Calculator(1);

            Calculator c2 = c1--;

            Console.WriteLine("Increment: {0}", c2);
        }

        public static void TrueOperation()
        {
            Calculator c = new Calculator(0);

            if (c)
            {
                Console.WriteLine("True: {0}", c);
            }
            else
            {
                Console.WriteLine("False: {0}", c);
            }
        }

        public static void FalseOperation()
        {
            Calculator c = new Calculator(0);

            if (c)
            {
                Console.WriteLine("True: {0}", c);
            }
            else
            {
                Console.WriteLine("False: {0}", c);
            }
        }
    }
}
