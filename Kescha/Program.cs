using System;
class Program
{
    static void Main()
    {
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
    }
}
