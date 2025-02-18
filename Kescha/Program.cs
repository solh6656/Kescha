using Kescha.Basic_Ketma_ketlik;
using Kescha.Basic_Takrorlash;
using Kescha.Basics_Tanlash;
using System;
class Program
{
    static void Main()
    {
        #region Basics.Ketma-ketlik bo’limi uchun amaliy vazifa

        BasicKetmaket basicKetmaket = new();

        //Task_1 
        basicKetmaket.FirtTask();
        //Task_2 
        basicKetmaket.SecoundTask();
        //Task_3 
        basicKetmaket.ThirdTask();

        #endregion

        #region Basics.Tanlash bo’limi uchun amaliy vazifa

        BasicsTanlashOne basicsOne = new();

        //Task_1 String ustida amallar
        basicsOne.FirtTask();
        //Task_2 Quyida ternary operator bilan ifodalandan qiymatni if-else yordamida ifodalang.
        basicsOne.SecoundTask();
        //Task_3 Consoleda o’zbek tilida kiritilgan hafta kunini ingliz tiliga o’girib,
        //natijani ekranga chiqaradigan dastur tuzing. Switch expression dan foydalaning!
        basicsOne.ThirdTask();

        #endregion

        #region Basics.Tanlash bo’limi uchun amaliy vazifa

        BasicTanlshSecond basicTanlshSecond = new();

        //Task_1 Palindrome Tekshiruvi
        basicTanlshSecond.FirtTask();
        //Task_2 Temperatura o'girish
        basicTanlshSecond.SecondTask();
        //Task_3 Sonlarni tartiblash
        basicTanlshSecond.ThirdTask();
        //Task_4 Berilgan matnning simvol sanasini hisoblash
        basicTanlshSecond.FourthTask();

        #endregion

        #region Basics.Takrorlash bo’limi uchun amaliy vazifa

        BasicTakrorlash basicTakrorlash = new();
        /*Task_1 1 dan 1000 gacha bo’lgan toq sonlarni yig’indisini ekranga
                     chiqaradigan dastur tuzing. While loop dan foydalaning!*/
        basicTakrorlash.FirtTask();
        /*Task_2 Array ichidagi eng katta va eng kichik qiymatlarni ko’paytmasini
                ekranga chiqaradigan dastur tuzing. For loop dan foydalaning!*/
        basicTakrorlash.SecondTask();
        /*Task_3 Consolga int tipidagi butun son kiritilgan => int x
                x!(x factorial) ni hisoblaydigan dastur tuzing.*/
        basicTakrorlash.ThirdTask();

        #endregion

    }


}