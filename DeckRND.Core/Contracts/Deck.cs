using DeckRND.Core.Generics;
using DeckRND.Core.PlayFormat;
using Format = DeckRND.Core.PlayFormat.PlayFormat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckRND.Core.Contracts
{
    public class Deck : CardCollection
    {
        public Format DeckFormat { get; private set; } = Format.None;
        public bool IsLegal { get; private set; } = false;
        public Deck() { }
        public Deck(List<Card> cards, string name, Format format)
        {
            Cards = cards;
            Name = name;
            DeckFormat = format;
            IsLegal = EvaluateDeck();
        }

        public Deck(List<Card> cards, string name, Format format, bool isLegal)
        {
            Cards = cards;
            Name = name;
            DeckFormat = format;
            IsLegal = isLegal;
        }



        private bool EvaluateDeck()
        {
            var deckEvaluator = DeckEvaluatorFactory.GetEvaluator(DeckFormat);
            return deckEvaluator.EvaluateDeck(this);
        }
    }
}
