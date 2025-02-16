using System;
class Program
{
    static void Main()
    {
        #region
        //Task_1
        Console.Write("Radiusni kiriting: ");
        if (double.TryParse(Console.ReadLine(), out double radius) && radius > 0)
        {
            double pi = Math.PI;
            double S = pi * Math.Pow(radius, 2);
            double L = 2 * pi * radius;

            Console.WriteLine($"S={S}, L={L}");
        }
        else
        {
            Console.WriteLine("Noto'g'ri qiymat kiritildi. Radius musbat son bo'lishi kerak.");
        }

        //Task_2
        Console.Write("Valyuta miqdorini kiriting: ");
        if (double.TryParse(Console.ReadLine(), out double qiymat) && qiymat > 0)
        {
            Console.Write("Valyuta kursini kiriting: ");
            if (double.TryParse(Console.ReadLine(), out double kurs) && kurs > 0)
            {
                double natija = qiymat * kurs;
                Console.WriteLine($"Natija: {natija} so'm");
            }
            else
            {
                Console.WriteLine("Noto'g'ri kurs qiymati kiritildi.");
            }
        }
        else
        {
            Console.WriteLine("Noto'g'ri valyuta miqdori kiritildi.");
        }

        //Task_3
        Console.Write("Tug'ilgan yilingizni kiriting: ");
        if (int.TryParse(Console.ReadLine(), out int yil) && yil > 0)
        {
            int hozirgiYil = DateTime.Now.Year;
            int yoshKunlarda = (hozirgiYil - yil) * 365;
            Console.WriteLine($"Sizning yoshingiz kunlarda: {yoshKunlarda}");
        }
        else
        {
            Console.WriteLine("Noto'g'ri yil kiritildi.");
        }
        #endregion

        #region Basics.Tanlash bo’limi uchun 1-amaliy vazifa
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
        #endregion
    }

}

