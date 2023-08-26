using DeckRND.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckRND.Core.PlayFormat
{
    public interface IDeckEvaluator
    {
        bool EvaluateDeck(Deck deck);
    }
}
