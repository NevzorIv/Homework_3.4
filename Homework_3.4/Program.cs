using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bookAll = 0;
            int bookFirst = 0;
            int bookSecond = 0;
            int bookThird = 0;
            int oneSet = 0;
            int howMuchSet = 0;
            int pagesAllSet = 0;
            Random rndBook = new Random();
            bookAll = RandomForBookAll(rndBook, bookAll);   //Кол-во страниц общее
            bookFirst = RandomForBookFirst(rndBook, bookFirst); //Кол-во страниц в первой книге
            bookSecond = RandomForBookSecond(rndBook, bookSecond);  //Кол-во страниц во второй книге
            bookThird = RandomForBookThird(rndBook, bookThird); //Кол-во страниц в третьей книге
            oneSet = OneSet(oneSet, bookFirst, bookSecond, bookThird);   //Кол-во страниц в наборе из трех книг каждого типа
            howMuchSet = HowMuchSets(howMuchSet, bookAll, oneSet);  //Кол-во наборов до bookAll
            pagesAllSet = PagesAllSet(pagesAllSet, howMuchSet, oneSet); //Кол-во страниц всех наборов
            Answer(bookAll, pagesAllSet, bookFirst, bookSecond, bookThird);
            Console.ReadKey();
        }
        static int RandomForBookAll(Random rndBook, int bookAll)
        {
            bookAll = rndBook.Next(8000, 10000);
            Console.Write($"Общее количество страниц: {bookAll}\n");
            return bookAll;
        }
        static int RandomForBookFirst(Random rndBook, int bookFirst)
        {
            bookFirst = rndBook.Next(50, 200);
            Console.Write($"Количество страниц в первой книге: {bookFirst}\n");
            return bookFirst;
        }
        static int RandomForBookSecond(Random rndBook, int bookSecond)
        {
            bookSecond = rndBook.Next(50, 200);
            Console.Write($"Количество страниц во второй книге: {bookSecond}\n");
            return bookSecond;
        }
        static int RandomForBookThird(Random rndBook, int bookThird)
        {
            bookThird = rndBook.Next(50, 200);
            Console.Write($"Количество страниц в третьей книге: {bookThird}\n");
            return bookThird;
        }
        static int OneSet(int oneSet, int bookFirst, int bookSecond, int bookThird)
        {
            oneSet = bookFirst + bookSecond + bookThird;
            Console.Write($"Один набор из трех книг с количеством страниц: {oneSet}\n");
            return oneSet;
        }
        static int HowMuchSets(int howMuchSet, int bookAll, int oneSet)
        {
            howMuchSet = bookAll / oneSet;
            Console.Write($"Кол-во наборов: {howMuchSet}\n");
            return howMuchSet;
        }
        static int PagesAllSet(int pagesAllSet, int howMuchSet, int oneSet)
        {
            pagesAllSet = howMuchSet * oneSet;
            Console.Write($"Общее кол-во страниц всех наборов: {pagesAllSet}\n");
            return pagesAllSet;
        }
        static void Answer(int bookAll, int pagesAllSet, int bookFirst,
            int bookSecond, int bookThird)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int kol = bookAll - pagesAllSet;
            int kolFirst = kol;
            int kolSecond = kol;
            int kolThird = kol;
            Console.Write($"Кол-во оставшихся страниц: {kol}\n");
            if (kol > bookFirst || kol > bookSecond || kol > bookThird)
            {
                if (kol > bookFirst)
                {
                    while (kolFirst > bookFirst)
                    {
                        kolFirst -= bookFirst;
                        a++;
                    }
                    Console.Write($"Кол-во книг первого типа можно добавить: {a}\n");
                }
                if (kol > bookSecond)
                {
                    while (kolSecond > bookSecond)
                    {
                        kolSecond -= bookSecond;
                        b++;
                    }
                    Console.Write($"Кол-во книг второго типа можно добавить: {b}\n");
                }
                if (kol > bookThird)
                {
                    while (kolThird > bookThird)
                    {
                        kolThird -= bookThird;
                        c++;
                    }
                    Console.Write($"Кол-во книг третьего типа можно добавить: {c}\n");
                }
                return;
            }
            Console.Write("Больше книг добавить нельзя");
        }
    }
}
