using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckRND.Shared.Models;

public class Library
{
    private Guid Id { get; }
    private Guid UserId { get; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    private Dictionary<string, int> Cards { get; } = new();

    public bool AddCard(string cardId)
    {
        var success = false;
        if (Cards.TryGetValue(cardId, out var currentCount))
        {
            currentCount++;
            Cards[cardId] = currentCount;
            success = true;
        }
        else
        {
            Cards.TryAdd(cardId, 1);
            success = true;
        }

        return success;
    }

    public bool AddCards(IEnumerable<string> cardIds)
    {
        var success = false;
        foreach (var cardId in cardIds)
        {
            success |= AddCard(cardId);
        }

        return success;
    }

    public bool RemoveCard(string cardId)
    {
        var success = false;
        if (Cards.TryGetValue(cardId, out var currentCount))
        {
            currentCount--;
            Cards[cardId] = currentCount;
            success = true;
        }

        return success;
    }

    public bool RemoveCards(IEnumerable<string> cardIds)
    {
        var success = false;
        foreach (var cardId in cardIds)
        {
            success |= RemoveCard(cardId);
        }

        return success;
    }
}
