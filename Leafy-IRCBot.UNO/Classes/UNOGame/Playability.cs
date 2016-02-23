// -----------------------------------------------------------
// This program is private software, based on C# source code.
// To sell or change credits of this software is forbidden,
// except if someone approves it from the LeafyCoding INC. team.
// -----------------------------------------------------------
// Copyrights (c) 2016 Leafy-IRCBot.UNO INC. All rights reserved.
// -----------------------------------------------------------

#region

using System.Collections.Generic;

#endregion

namespace Leafy_IRCBot.UNO.Classes.UNOGame
{
    internal static class CardPlayability
    {
        private static readonly List<string> PlayedCards = new List<string>();
        public static readonly List<string> DealtCards = new List<string>();

        public static void AddDealtCard(string card) => DealtCards.Add(card);

        public static void AddPlayedCard(string card) => PlayedCards.Add(card);
    }
}