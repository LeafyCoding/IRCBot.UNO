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
    internal static class User
    {
        public static readonly List<string> Users = new List<string>();

        public static bool isUser(string user)
        {
            if (Users.Contains(user.ToLower()))
            {
                Tools.SemiColoredWrite(ConsoleColor.Green, "[UserHandler:isUser] ", user);
                return true;
            }
            Tools.SemiColoredWrite(ConsoleColor.Red, "[UserHandler:notUser] ", user);
            return false;
        }

        public static void DenyAccess(string sendernick, string channel)
        {
            Tools.ColoredWrite(ConsoleColor.Red, $"[UserHandler:DenyAccess] I do not recognise {sendernick}");
            Program.client.SendMessage($"{IRC.BOLD}{IRC.RED}I do not recognise your authority, {sendernick}.", channel);
        }
    }
}