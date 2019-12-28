using System;
using System.Collections;
using System.Text;

namespace Lab.classes
{
    public static class StringExtension
    {
        public static int CharCount(this string str, char ch)
        {
            int counter = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ch)
                {
                    counter++;
                }
            }

            return counter;
        }

        public static bool CharCheck(this string str, char ch)
        {
            bool isCheck = false;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ch)
                {
                    isCheck = true;
                    break;
                }
            }

            return isCheck;
        }

        public static string RemoveVowels(this string str)
        {
            StringBuilder tempString = new StringBuilder(50);

            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            bool flag = false;

            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < vowels.Length; j++)
                {
                    if (str[i] == vowels[j])
                    {
                        flag = true;
                        break;
                    }
                }

                if (!flag)
                {
                    tempString.Append(str[i]);
                }

                flag = false;
            }

            return tempString.ToString();
        }

        public static string GetShortString(this string[] array)
        {
            int index = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 1; j < array.Length - 1; j++)
                {
                    if (array[i].Length < array[j + 1].Length)
                    {
                        index = i;
                        break;
                    }
                }
            }

            string str = array[index];

            return str;
        }

        public static string GetLongString(this string[] array)
        {
            int index = 0;

            for(int i = 0; i < array.Length; i++)
            {
                for(int j = 1; j < array.Length - 1; j++)
                {
                    if(array[i].Length > array[j].Length)
                    {
                        index = i;
                        break;
                    }
                }
            }

            string str = array[index];

            return str;
        }

        public static int GetFirstNum(this string str)
        {
            char[] numbers = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            bool flag = false;
            int index = 0;

            for(int i = 0; i < str.Length; i++)
            {
                for(int j = 0; j < numbers.Length; j++)
                {
                    if(str[i] == numbers[j])
                    {
                        index = i;
                        flag = true;
                        break;
                    }
                }

                if (flag)
                {
                    break;
                }
            }

            int num = (int)Char.GetNumericValue(str[index]);

            return num;
        }
    }
}
