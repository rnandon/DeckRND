using DeckRND.Core.PlayFormat.Evaluators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckRND.Core.PlayFormat
{
    public static class DeckEvaluatorFactory
    {
        public static IDeckEvaluator GetEvaluator(PlayFormat format)
        {
            switch (format)
            {
                case PlayFormat.None:
                    return new NoneEvaluator();
                case PlayFormat.Standard: 
                    return new StandardEvaluator();
                default:
                    return new NoneEvaluator();
            }
        }
    }
}
