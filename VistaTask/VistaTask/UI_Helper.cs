using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VismaTask
{
    public static class UI_Helper//leis patogiai nusiskaitys duomenis is ekrano
    {
        //       informacijos ivedimo ir isvedimo paskirtis(kaip fornt endas)
        public static void UniversalSelectPrompt(string[] variants, Action[] actions)//Action - metodo padavimas,kaip elegata
        {//universaliai leis pasirinkti pasirinkimus
            bool exit = false;
            int selection = 0;

            while (!exit)
            {
                Console.WriteLine("Pasirinkimai :");
                for (int i = 0; i < variants.Length; i++)
                {
                    Console.WriteLine("{0} - {1}", i, variants[i]);//gausim tam tikra pasirinkima
                }

                if (!int.TryParse(Console.ReadLine(), out selection) || selection > variants.Length || selection < 0)//jei nepavyksta ivesti,tuomet spausdinsim errora
                {
                    Console.Clear();
                    Console.WriteLine("Netinkamai ivestas pasirinkimas");
                    continue; //soks vel nuo pradziu
                }

                exit = true;
                actions[selection]();//kvieciam metoda is rinkinio pagal pasirinkinta metoda
            }//action apsirasom pPrograms.cs


        }
        public static string AskForString(string question)//validacija,kad pavadinimas nebutu tuscias
        {
            string rez = "";//tuscias rezultatas
            bool exit = false;

            while (!exit) //jei exit ne false
            {
                Console.WriteLine(question);
                var input = Console.ReadLine();//ivedamas tekstas ar norimas zenklas
                if (input == null)//jei input reiksme lygi nuliui 
                {//tuomet
                    Console.Clear();//isvalo ekrana ir ismeta uzrasa paie netinkama reiksme
                    Console.WriteLine("Netinkamai ivesta reiksme.");
                    continue;//ir bando is naujo
                }
                exit = true;//jei yra imput'as, tuomet exit bus true,while bus !true-neteisybe ir toliau
                rez = input;//tai input'a priskiria i rez reiksme
            }
            return rez;//grazina i rez stringa iraso inputo reiksme
        }
    }
}
 //public static int AskForSelection(string[]variants)
        //{
        //    bool exit = false;
        //    int selection = 0;
        //    while (!exit)
        //    {
        //        Console.WriteLine("Pasirinkimai :");
        //        for (int i = 0; i < variants.Length; i++)
        //        {
        //            Console.WriteLine("{0} - {1}",1,variants[i]);
        //        }//jei teisingai perskaito selection,tuomet iraso i selektions
        //        if (!int.TryParse(Console.ReadLine(), out selection) || selection > variants.Length-1 || selection < 0)//jei nepavyksta ivesti,tuomet spausdinsim errora
        //        { 
        //       Console.Clear();
        //        Console.WriteLine("Netinkamai ivestas pasirinkimas");
        //       continue; //soks vel nuo pradziu
        //        }
        //        exit = true;//exit pavercia true,gausis !true
        //    }
        //return selection;//grazina pasirinkima
        //}

