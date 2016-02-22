﻿// -----------------------------------------------------------
// This program is private software, based on C# source code.
// To sell or change credits of this software is forbidden,
// except if someone approves it from the LeafyCoding INC. team.
// -----------------------------------------------------------
// Copyrights (c) 2016 Leafy-IRCBot.UNO INC. All rights reserved.
// -----------------------------------------------------------

#region

using System;
using System.Threading;

#endregion

namespace Leafy_IRCBot.UNO.Classes
{
    internal static class Tools
    {
        public static void ColoredWrite(ConsoleColor color, string text)
        {
            var originalColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.Write(text + Environment.NewLine);
            Console.ForegroundColor = originalColor;
        }

        public static void SemiColoredWrite(ConsoleColor color, string coloredText, string noColorText)
        {
            var originalColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.Write(coloredText);
            Console.ForegroundColor = originalColor;
            Console.Write(noColorText + Environment.NewLine);
        }

        public static void SetupIRCClient()
        {
            Program.client.ConnectionComplete += (s, e) =>
            {
                SemiColoredWrite(ConsoleColor.Yellow, "[IRC] ", "Identifying to NickServ.");
                Program.client.SendMessage("identify " + Config.IRC_NSPassword, "NickServ");
                Thread.Sleep(200);
                SemiColoredWrite(ConsoleColor.Yellow, "[IRC] ", "Enabling vHost.");
                Program.client.SendMessage("hs on", "HostServ");
                Thread.Sleep(200);
                SemiColoredWrite(ConsoleColor.Yellow, "[IRC] ", "Joining default channel.");
                Program.client.JoinChannel(Config.IRC_ChannelName);
                SemiColoredWrite(ConsoleColor.Yellow, "[IRC] ", "Joined channel, enabling menu.");
                Thread.Sleep(100);
                Program.MenuEnabled = true;
            };

            Program.client.ChannelMessageRecieved += (s, e) =>
            {
                // Ignored
            };

            Program.client.PrivateMessageRecieved += (s, e) =>
            {
                if (e.PrivateMessage.Message.Equals("\x01VERSION\x01"))
                {
                    var msg = $"\x01VERSION {IRC.NOCOLOR}💩 Leafy-IRCBot.UNO 💩\x01";
                    Program.client.SendNotice(msg, e.PrivateMessage.User.Nick);
                    SemiColoredWrite(ConsoleColor.Magenta, "[CTCP:VERSION] ", $"Responded to request from {e.PrivateMessage.User.Nick}");
                }
                if (e.PrivateMessage.Message.Equals("\x01TIME\x01"))
                {
                    var msg = $"\x01TIME  {BuildCTCPTime()} \x01";
                    Program.client.SendNotice(msg, e.PrivateMessage.User.Nick);
                    SemiColoredWrite(ConsoleColor.Magenta, "[CTCP:TIME] ", $"Responded to request from {e.PrivateMessage.User.Nick}");
                }
            };
        }

        private static string BuildCTCPTime()
        {
            var time = DateTime.Now;
            var message = $"{IRC.NOCOLOR}{time.ToString("HH:mm:ss tt")} ({time.ToString("dd/MM/yyyy")})";
            return message;
        }
    }
}