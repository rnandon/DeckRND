using DeckRND.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckRND.Core.PlayFormat.Evaluators
{
    internal class NoneEvaluator : IDeckEvaluator
    {
        public bool EvaluateDeck(Deck deck)
        {
            return true;
        }
    }
}
