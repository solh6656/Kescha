using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kescha.Basics_Tanlash
{
    public class BasicTanlshSecond
    {
        public void FirtTask()
        {
            //Task_1 Palindrome Tekshiruvi
            Console.Write("Satrni kiriting: ");
            string strPalindrome = Console.ReadLine();

            bool isPalindrome = IsPalindrome(strPalindrome);

            string resultPalindrome = isPalindrome ? "Palindrom" : "Palindrom emas";
            Console.WriteLine(resultPalindrome);

            
            static bool IsPalindrome(string str)
            {
                char[] arr = str.ToCharArray();
                Array.Reverse(arr);
                string reverseStr = new string(arr);

                return str.Equals(reverseStr, StringComparison.OrdinalIgnoreCase);
            }

        }
        public void SecondTask()
        {
            //Task_2 Temperatura o'girish
            Console.Write("Selsiyus bo'yicha temperaturani kiriting: ");
            string input = Console.ReadLine();

            if (double.TryParse(input, out double celsius))
            {
                double fahrenheit = celsius * 9 / 5 + 32;
                double kelvin = celsius + 273.15;

                Console.WriteLine($"Selsiyus: {celsius}, Fahrenheit: {fahrenheit:F1}, Kelvin: {kelvin:F2}");
            }
            else
            {
                Console.WriteLine("Noto'g'ri kirish. Iltimos, son kiriting.");
            }
        }
        public void ThirdTask()
        {
            //Task_3 Sonlarni tartiblash
            Console.Write("Sonlarni vergul bilan ajratib kiriting: ");
            string inputSort = Console.ReadLine();
            int[] numbers = inputSort.Split(',').Select(int.Parse).ToArray();

            Console.Write("Tartiblash tartibini kiriting (1 - O'suvchi, 2 - Kamayuvchi): ");
            string tartib = Console.ReadLine();

            switch (tartib)
            {
                case "1":
                    Array.Sort(numbers);
                    break;
                case "2":
                    Array.Sort(numbers);
                    Array.Reverse(numbers);
                    break;
                default:
                    Console.WriteLine("Noto'g'ri tartib tanlandi.");
                    return;
            }

            string resultSort = string.Join(", ", numbers);
            Console.WriteLine($"Natija: {resultSort}");
        }
        public void FourthTask()
        {
            //Task_4 Berilgan matnning simvol sanasini hisoblash
            Console.Write("Matnni kiriting: ");
            string inputCountChar = Console.ReadLine();

            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach (char c in inputCountChar)
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount[c] = 1;
                }
            }

            Console.WriteLine("Simvollar qaytarilishi:");
            foreach (var item in charCount)
            {
                Console.WriteLine($"'{item.Key}': {item.Value} martta");
            }
        }
    }
}
