using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kescha.Basics_Tanlash
{
    public class BasicsTanlashOne
    {
        public void FirtTask()
        {
            //Task_1 String ustida amallar
            Console.Write("Stringni kiriting: ");
            string str = Console.ReadLine();

            Console.Write("Sonni kiriting: ");
            int num_x = int.Parse(Console.ReadLine());

            if (num_x > str.Length)
            {
                str = str.ToUpper();
            }
            else
            {
                str = str.ToLower();
            }

            Console.WriteLine($"Natija: {str}");
        }
        public void SecoundTask()
        {
            //Task_2 Quyida ternary operator bilan ifodalandan qiymatni if-else yordamida ifodalang.
            int x = 15;
            int y = 10;
            string result;

            //string result = (x > y)
            //    ? "x, y dan katta"
            //    : (x < y)
            //        ? "x, y dan kichkina"
            //        : (x == y)
            //            ? "x, y ga teng" 
            //            : "x bina y ni solishtirib bo'lmaydi";

            if (x > y)
            {
                result = "x, y dan katta";
            }
            else if (x < y)
            {
                result = "x, y dan kichkina";
            }
            else if (x == y)
            {
                result = "x, y ga teng";
            }
            else
            {
                result = "x bilan y ni solishtirib bo'lmaydi";
            }
        }
        public void ThirdTask()
        {
            //Task_3 Consoleda o’zbek tilida kiritilgan hafta kunini ingliz tiliga o’girib,
                    //natijani ekranga chiqaradigan dastur tuzing. Switch expression dan foydalaning!
            Console.Write("Hafta kunini kiriting (o'zbek tilida): ");
            string haftaKuniUz = Console.ReadLine().ToLower();

            string haftaKuniEn = haftaKuniUz switch
            {
                "dushanba" => "Monday",
                "seshanba" => "Tuesday",
                "chorshanba" => "Wednesday",
                "payshanba" => "Thursday",
                "juma" => "Friday",
                "shanba" => "Saturday",
                "yakshanba" => "Sunday",
                _ => "Noto'g'ri hafta kuni"
            };

            Console.WriteLine($"Ingliz tilida: {haftaKuniEn}");
        }

    }
}
//Temp
//public void FirtTask()
//{
   

//public void SecondTask()
//{
   
    
//}
//public void ThirdTask()
//{
    
//}