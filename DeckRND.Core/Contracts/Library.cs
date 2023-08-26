using DeckRND.Core.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckRND.Core.Contracts
{
    public class Library : CardCollection
    {
        public List<Card> Cards = new List<Card>();
        public string Name = string.Empty;

        public Library() {}
        public Library(List<Card> cards, string name)
        {
            Cards = cards;
            Name = name;
        }
    }
}
