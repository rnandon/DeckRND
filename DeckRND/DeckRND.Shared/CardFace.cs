using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckRND.Shared
{
	public class CardFace
	{
		string? Artist;
		Guid? ArtistId;
		decimal? ConvertedManaCost;
		CardColor[]? ColorIndicator;
		CardColor[]? ColorsOnCard;
		string? Defense;
		string? FlavorText;
		Guid? IllustrationId;
		Uri[]? ImageUris;
		string? Layout;
		string? Loyalty;
		string ManaCost;
		string Name;
		Guid? OracleId;
		string? OracleText;
		string? Power;
		string? PrintedName;
		string? PrintedText;
		string? PrintedTypeLine;
		string? Toughness;
		string? TypeLine;
		string? Watermark;
	}
}
