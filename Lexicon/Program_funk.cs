using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon
{

    public class Program_funk
    {
        private string path = @"c:\temp\MyTest.txt";

        public void Hello_World()
        {
            Console.WriteLine("Hello World");
        }

        public void andvandare()
        {
            string ? fornamn = null;
            string ? efternamn = null;
            string ? temp = null;
            int alder = 0;
            Console.WriteLine("Var snäll och ange Förnamn, Efternamn, Ålder!");
            do
            {
                Console.WriteLine("Ange Förnamn!");
                fornamn = Convert.ToString(Console.ReadLine());

            } while (string.IsNullOrEmpty(fornamn));
            do
            {
                Console.WriteLine("Ange Efternamn!");
                efternamn = Convert.ToString(Console.ReadLine());

            } while (string.IsNullOrEmpty(efternamn));

            do
            {
                Console.WriteLine("Ange Ålder!");

                temp = Convert.ToString(Console.ReadLine());
                if (!int.TryParse(temp, out alder))
                {
                    temp = null;
                    Console.Clear();
                    Console.WriteLine("Felaktig inmatnig försök igen!");
                }

            } while (string.IsNullOrEmpty(temp));
            

            Console.WriteLine($"Hej {fornamn} {efternamn}, {alder}år");
        }

        public void andra_farg()
        {
            if (Console.ForegroundColor != ConsoleColor.Gray)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
            }

        }

        public void dateee()
        {
            DateTime date = DateTime.Today;
            Console.WriteLine("I dag är det: " + date.ToString("yyyy-MM-dd"));
        }

        public void storst(int ett, int tva)
        {
            int svar = Math.Max(ett, tva);

            Console.WriteLine("Det största värdet är: " + svar);
        }

        public void slump()
        {
            Console.WriteLine("Välkommen till gissa spelet!!");
            Console.WriteLine("Det går utt på att gissa på ett");
            Console.WriteLine("slumpmässigt genererar tal");
            Console.WriteLine("mellan 1 och 100.");

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("May the odds ever be in your favor");
            Console.ForegroundColor = ConsoleColor.Gray;

            Random random = new Random();

            int tal = random.Next(1, 101);
            int gizza = 0;
            int forsok = 0;
            string ? temp = null;
            
            do
            {
                Console.WriteLine("Gissa: ");
                temp = Convert.ToString(Console.ReadLine());
                if (!int.TryParse(temp, out gizza))
                {
                    temp = null;
                    Console.Clear();
                    Console.WriteLine("Felaktig inmatnig försök igen!");
                }

                if (gizza != tal)
                {
                    temp = null;
                    
                    Console.WriteLine("Felaktig gissning.");
                    Console.WriteLine(gizza + " " + tal);

                    if (tal > gizza)
                        Console.WriteLine("Talet var för litet!");

                    if (tal < gizza)
                        Console.WriteLine("Talet var för stort!");
                }
                if (gizza == tal)
                {
                    temp = "slut";
                }
                forsok++;
            } while (string.IsNullOrEmpty(temp));

            Console.WriteLine("Rätt gissat.");
            Console.WriteLine($"Det tog bara {forsok} försök");
        }

        public void fil_spara()
        {
            string? temp = null;
            do
            {
                Console.WriteLine("Det text du anger här kommer spara i en fil");
                Console.WriteLine($"Ange text");
                temp = Convert.ToString(Console.ReadLine());
                if (!string.IsNullOrEmpty(temp))
                {
                    temp = null;
                    Console.Clear();
                    Console.WriteLine("Felaktig inmatnig försök igen!");
                }

            } while (string.IsNullOrEmpty(temp));

            string text = temp;
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine(text);
            }

        }

        public void fil_lasa()
        {
            if (File.Exists(path))
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    string? s = "";

                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }

            }
        }

        public Tuple<double, double, double> deci()
        {
            Console.WriteLine("Ange ett nummer och få tillbacka roten ur, upphöjt till 2 och upphöjt till 10!");
            Console.WriteLine("Ange ett nummer");
            double tal = Convert.ToDouble(Console.ReadLine());

            double roten = Math.Sqrt(tal);
            double log2 = Math.Log2(tal);
            double log10 = Math.Log10(tal);

            var result = Tuple.Create(log2, log10, roten);
            return result;
        }

        public void multiplikation()
        {
            string result = "";
            for (int i = 0; i <= 10; i++)
            {
                result = "";
                result += $"{i}:\t";
                
                for (int j = 1; j <= 10; j++)
                {
                    if(i == 0)
                    {
                        result += $"{j}:\t";
                    }else
                    {
                        result += $"{i * j}\t";
                    }
                }
                Console.WriteLine(result);
            }

        }

        public void arraysorting()
        {
            Random random = new Random();

            int ran = 0;
            int len = 10;
            int[] etts = new int[len];
            int[] tvas = new int[len];

            for (int i = 0; i < len; i++)
            {
                while (etts.Contains(ran))
                {
                    ran = random.Next(1, 101);
                }
                etts[i] = ran;
            }

            //for (int i = 0; i < etts.Length; i++)
            //{
            //    Console.Write(etts[i] + "  ");
            //}
            //Console.Write("\n");

            int racknare = 0;
            for( int i=0; i < 101; i++)
                for (int j = 0; j < len; j++)
                {
                    if(etts[j] == i)
                    {
                        tvas[racknare] = i;
                        racknare++;
                        break;
                    }
                }


            //for (int i = 0; i < tvas.Length; i++)
            //{
            //    Console.Write(tvas[i] + "  ");
            //}
            //Console.Write("\n");

        }

        public bool paldron()
        {
            string? text = null;
            do
            {
                Console.WriteLine("Det text du vill kolla om den är en palindrom");
                Console.WriteLine($"Ange text");
                text = Convert.ToString(Console.ReadLine());
                if (!string.IsNullOrEmpty(text))
                {
                    text = null;
                    Console.Clear();
                    Console.WriteLine("Felaktig inmatnig försök igen!");
                }

            } while (string.IsNullOrEmpty(text));
            

            char[] arr = text.ToCharArray();

            Array.Reverse(arr);

            string temp = new string(arr);

            return text.Equals(temp);
        }


        public void mellan()
        {
            
            Console.WriteLine("Ange de nummer som du vill se talen mellan");
            string? temp = null;
            int result = 0;
            do
            {
     
                Console.WriteLine($"Ange tal 1");
                temp = Convert.ToString(Console.ReadLine());
                if (!int.TryParse(temp, out result))
                {
                    temp = null;
                    //Console.Clear();
                    Console.WriteLine("Felaktig inmatnig försök igen!");
                }

            } while (string.IsNullOrEmpty(temp));

            int nummer1 = result;
            temp = null;
            do
            {
                Console.WriteLine($"Ange tal 2");
                temp = Convert.ToString(Console.ReadLine());
                if (!int.TryParse(temp, out result))
                {
                    temp = null;
                    //Console.Clear();
                    Console.WriteLine("Felaktig inmatnig försök igen!");
                }

            } while (string.IsNullOrEmpty(temp));

            int nummer2 = result;

            int max = Math.Max(nummer1, nummer2);
            int min = Math.Min(nummer1, nummer2);

            for(int i = min; i <= max; i++)
            {
                Console.WriteLine(i + "  ");
            }
        }

        public void udda_jamna()
        {
            Console.WriteLine("Ange de komma-separerade siffror som ska soteras");
            string? temp = null;
            do
            {
                Console.WriteLine($"Ange text");
                temp = Convert.ToString(Console.ReadLine());
                if (!string.IsNullOrEmpty(temp))
                {
                    temp = null;
                    Console.Clear();
                    Console.WriteLine("Felaktig inmatnig försök igen!");
                }

            } while (string.IsNullOrEmpty(temp));

            string[] arrs = temp.Split(new char[] { ',' });

            int[] antts = new int[arrs.Length];
            for (int i = 0; i < arrs.Length; i++)
            {
                antts[i] = Convert.ToInt32(arrs[i].ToString());
            }

            Array.Sort(antts);
            string odd = "";
            string even = "";

            foreach (int value in antts)
            {
                if(value % 2 == 0)
                {
                    even += value + " ";
                }
                else
                {
                    odd += value + " ";
                }
            }

            Console.WriteLine($"udda:  " + odd);
            Console.WriteLine($"ämna:  " + even);
        }

        public void komma_add()
        {
            Console.WriteLine("Ange de komma-separerade siffror som ska adderas");
            string? temp = null;
            do
            {
                Console.WriteLine($"Ange text");
                temp = Convert.ToString(Console.ReadLine());
                if (!string.IsNullOrEmpty(temp))
                {
                    temp = null;
                    Console.Clear();
                    Console.WriteLine("Felaktig inmatnig försök igen!");
                }

            } while (string.IsNullOrEmpty(temp));
            
            string[] arrs = temp.Split(new char[] { ',' });

            int resutat = 0;
            for (int i = 0; i < arrs.Length; i++)
            {
                resutat += Convert.ToInt32(arrs[i].ToString());
            }

            

            Console.WriteLine($"Resultatet blir:  " + resutat);
        }

        public void Player_create()
        {
            Console.WriteLine("Ange de namn som du vill ge dina karatärer!");
            Random random = new Random();
            string ?name = null;

            do
            {
                Console.WriteLine($"Ange namn1 ");
                name = Convert.ToString(Console.ReadLine());

            } while (string.IsNullOrEmpty(name));

            int halsa = random.Next(50, 101);
            int styrka = random.Next(25, 50);
            int tur = random.Next(1, 15);
            Player player_one = new Player(name, halsa, styrka, tur);

            name = null;
            do
            {
                Console.WriteLine($"Ange namn2 ");
                name = Convert.ToString(Console.ReadLine());

            } while (string.IsNullOrEmpty(name));

            halsa = random.Next(50, 101);
            styrka = random.Next(25, 50);
            tur = random.Next(1, 15);

            Player player_two = new Player(name, halsa, styrka, tur);
        }


    }
}
