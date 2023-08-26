using DeckRND.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckRND.Core.Contracts
{
    public class Card
    {
        public List<CardType> CardTypes;
        public string Name;
        public List<Color> Colors;
        public string ManaCost;
        public string ConvertedManaCost;
        public string Set;
        public string Text;
        public int? Power;
        public int? Toughness;
    }
}
