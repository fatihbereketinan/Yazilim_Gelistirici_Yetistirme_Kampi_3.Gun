using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 =??=30 olacak
            Console.WriteLine(sayi1);

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 3000 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0] =??=999 olacak.
            Console.WriteLine(sayilar1[0]);

            //int, decimal, float, double, bool gibi sayısal veri tipleri, değer tiptir.
            //array, class, interface ise referans tiptir.

            //bellekte stack ve heap diye iki tane alan vardır. Değer tipler stack te işlem görür. Referans tipler stack bölgesinde işlem görür.
            //Stack bölgesinde sadece değerler işlem görür sadece değer ataması yapılır.
            //Referans tipler için new denilince heap bölgesinde alan oluşturulur ve adres ataması yapılır.
            //18. Satırda sayilar2 nin refereans numarası yani adresi sayilar1 in referans numarasına atandı. Aynı zamanda alanları da aynı oldu.

        }
    }
}
