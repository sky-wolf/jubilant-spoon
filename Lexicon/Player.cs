using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon
{
    public class Player
    {
        public Player(string name, int halsa, int styrka, int tur)
        {
            this.player_name = name;
            this.player_halsa = halsa;
            this.player_styrka = styrka;
            this.player_tur = tur;
        }

        public int player_halsa { get; private set; }
        public int player_styrka { get; private set; }
        public int player_tur { get; private set; }
        public string player_name { get; private set; }

    }
}
