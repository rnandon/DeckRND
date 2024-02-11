using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckRND.Shared
{
	public class GameplayField
	{
		RelatedCard[]? RelatedCards;
		CardFace[]? CardFaces;
		decimal ConvertedManaCost;
		CardColor[] ColorIdentity;
		CardColor[]? ColorIndicators;
		CardColor[]? Colors;
		string? Defense;
		int? EDHRecRank;
		string? HandModifier;
		string[] Keywords;
		PlayFormats[] LegalFormats;
		string? LifeModifier;
		string? Loyalty;
		string? ManaCost;
		string Name;
		string? OracleText;
		int? PennyRank;
		string? Power;
		CardColor[]? ProducedMana;
		bool IsReserved;
		string TypeLine;
	}
}
