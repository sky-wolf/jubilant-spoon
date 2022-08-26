namespace Lexicon
{
    using Lexicon;
    using System;
    using System.Diagnostics;
    using System.IO;
    using System.Runtime.CompilerServices;
    using System.Xml.Linq;


    public class Huvud
    {

        public static void Main(string[] args)
        {
            Program_funk program = new Program_funk();
            Huvud huvud = new Huvud();
            int choice = 0;
            string ? temp = null;
            bool run = true;
            while (run)
            {
                do
                {
                    Console.WriteLine("menysystem");
                    Console.WriteLine("Välj mellan funktionerna 1-16");
                    Console.WriteLine("eller välj funktione 0 för att avsluta");
                    temp = Convert.ToString(Console.ReadLine());
                    if (!int.TryParse(temp, out choice))
                    {
                        temp = null;
                        Console.Clear();
                        Console.WriteLine("Felaktig inmatnig försök igen!");
                    }

                } while (string.IsNullOrEmpty(temp));


                switch (choice)
                {
                    case 0:
                        {
                            Console.Clear();
                            Console.WriteLine("Hej då");
                            break;
                        }
                    case 1:
                        {
                            program.Hello_World();
                            break;
                        }
                    case 2:
                        {
                            program.andvandare();
                            break;
                        }
                    case 3:
                        {
                            program.andra_farg();
                            break;
                        }
                    case 4:
                        {
                            program.dateee();
                            break;
                        }
                    case 5:
                        {
                            int ett = huvud.isnumber("Ange nummer Ett");
                            int tva = huvud.isnumber("Ange nummer Två");
                            program.storst(ett, tva);
                            break;
                        }
                    case 6:
                        {
                            program.slump();
                            break;
                        }
                    case 7:
                        {
                            program.fil_spara();
                            break;
                        }
                    case 8:
                        {
                            program.fil_lasa();
                            break;
                        }
                    case 9:
                        {
                            var returnvalue = program.deci();
                            Console.WriteLine($"roten ur {returnvalue.Item1}, upphöjt till 2 {returnvalue.Item2} och upphöjt till 10 {returnvalue.Item3}");
                            break;
                        }
                    case 10:
                        {
                            program.multiplikation();
                            break;
                        }
                    case 11:
                        {
                            program.arraysorting();
                            break;
                        }
                    case 12:
                        {
                            var palasron =  program.paldron();
                            Console.WriteLine( palasron.ToString());
                            break;
                        }
                    case 13:
                        {
                            program.mellan();
                            break;
                        }
                    case 14:
                        {
                            program.udda_jamna();
                            break;
                        }
                    case 15:
                        {
                            program.komma_add();
                            break;
                        }
                    case 16:
                        {
                            program.Player_create();
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("Felaktig inmatnig försök igen!");
                            break;
                        }

                }
                Console.WriteLine("Tryck enter för att fortsätta");
                Console.ReadLine();

                Console.Clear();
            }
        }

        private int isnumber(string message)
        {
            string? temp = null;
            int result = 0;
            do
            {
                Console.WriteLine(message);
                temp = Convert.ToString(Console.ReadLine());
                if (!int.TryParse(temp, out result))
                {
                    temp = null;
                    //Console.Clear();
                    Console.WriteLine("Felaktig inmatnig försök igen!");
                }

            } while (string.IsNullOrEmpty(temp));

            return result;

        }

  

    }
}
