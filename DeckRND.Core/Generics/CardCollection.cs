using DeckRND.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckRND.Core.Generics
{
    public abstract class CardCollection
    {
        public List<Card> Cards { get; protected set; } = new List<Card>();
        public string Name { get; protected set; } = string.Empty;

        public bool AddCard(Card card)
        {
            Cards.Append(card);
            return true;
        }

        public void RemoveAllCards()
        {
            Cards.Clear();
        }

        public bool RemoveCard(Card card)
        {
            return Cards.Remove(card);
        }

        public void SetName(string name)
        {
            Name = name;
        }
    }
}
