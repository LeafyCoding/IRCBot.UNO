// -----------------------------------------------------------
// This program is private software, based on C# source code.
// To sell or change credits of this software is forbidden,
// except if someone approves it from the LeafyCoding INC. team.
// -----------------------------------------------------------
// Copyrights (c) 2016 Leafy-IRCBot.UNO INC. All rights reserved.
// -----------------------------------------------------------

#region

using System;
using System.Collections.Generic;
using Leafy_IRCBot.UNO.Classes;

#endregion

namespace Leafy_IRCBot.UNO.Handlers
{
    internal static class Game
    {
        private static bool isRunning;
        private static string isStartedBy;
        private static bool isAcceptingPlayers;
        private static readonly List<string> PlayerList = new List<string>();
        public static string topCard;

        public static void StartGame(string sendernick, string channel)
        {
            if (isRunning)
            {
                Tools.SemiColoredWrite(ConsoleColor.Red, "[UNO] ", "Game requested but already running.");
                Program.client.SendMessage(Messages.ALREADY_STARTED(isStartedBy), channel);
            }
            else
            {
                isRunning = true;
                isStartedBy = sendernick;
                // TODO Get MySQL ready for a game.
                Tools.SemiColoredWrite(ConsoleColor.Green, "[UNO] ", $"Game started by {sendernick}.");
                Program.client.SendMessage(Messages.GAME_STARTED(sendernick), channel);
                AnnounceStart();
            }
        }

        private static void AnnounceStart()
        {
            isAcceptingPlayers = true;
            PlayerList.Add(isStartedBy);
        }
    }
}