using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kescha.Basic_Takrorlash
{
    public class BasicTakrorlash
    {
        public void FirtTask()
        {
            /*Task_1 1 dan 1000 gacha bo’lgan toq sonlarni yig’indisini ekranga
                     chiqaradigan dastur tuzing. While loop dan foydalaning!*/
            int sum = 0;
            int number = 1;

            while (number <= 1000)
            {
                if (number % 2 != 0)
                {
                    sum += number;
                }
                number++;
            }

            Console.WriteLine($"1 dan 1000 gacha bo'lgan toq sonlarning yig'indisi: {sum}");
        }
        public void SecondTask()
        {
            /*Task_2 Array ichidagi eng katta va eng kichik qiymatlarni ko’paytmasini
                ekranga chiqaradigan dastur tuzing. For loop dan foydalaning!*/

            int[] numbersToplam = { 3, 5, 7, 2, 8, -1, 4, 10, 12 };
            int engKatta = numbersToplam[0];
            int engKichik = numbersToplam[0];

            for (int i = 1; i < numbersToplam.Length; i++)
            {
                if (numbersToplam[i] > engKatta)
                {
                    engKatta = numbersToplam[i];
                }
                if (numbersToplam[i] < engKichik)
                {
                    engKichik = numbersToplam[i];
                }
            }

            int kopaytma = engKatta * engKichik;

            Console.WriteLine($"Array ichidagi eng katta qiymat: {engKatta}");
            Console.WriteLine($"Array ichidagi eng kichik qiymat: {engKichik}");
            Console.WriteLine($"Eng katta va eng kichik qiymatlarni ko'paytmasi: {kopaytma}");
        }
        public void ThirdTask()
        {
            /*Task_3 Consolga int tipidagi butun son kiritilgan => int x
                x!(x factorial) ni hisoblaydigan dastur tuzing.*/
            Console.Write("Butun sonni kiriting: ");
            int xFact = int.Parse(Console.ReadLine());

            long factorial = CalculateFactorial(xFact);

            Console.WriteLine($"{xFact}! = {factorial}");

            //Task_3 Factorial funksiasi
            static long CalculateFactorial(int n)
            {
                long result = 1;

                for (int i = 1; i <= n; i++)
                {
                    result *= i;
                }

                return result;
            }
        }
    }
}