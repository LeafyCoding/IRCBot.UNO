// -----------------------------------------------------------
// This program is private software, based on C# source code.
// To sell or change credits of this software is forbidden,
// except if someone approves it from the LeafyCoding INC. team.
// -----------------------------------------------------------
// Copyrights (c) 2016 Leafy-IRCBot.UNO INC. All rights reserved.
// -----------------------------------------------------------

// ReSharper disable UnusedMember.Global
namespace Leafy_IRCBot.UNO.Classes
{
    internal static class Messages
    {
        public static string ENOUGH()
            => $"{IRC.NORMAL}There are enough players, type {IRC.BOLD}.deal{IRC.BOLD} to start!";

        public static string GAINS(string playerName, int points)
            => $"{IRC.NORMAL}{IRC.BOLD}{playerName}{IRC.BOLD} gains {IRC.BOLD}{points}{IRC.BOLD} points!";

        public static string GAME_ALREADY_DEALT()
            => $"{IRC.NORMAL}Game has already been dealt, please wait until game is over or stopped.";

        public static string GAME_STARTED(string playerName)
            =>
                $"{IRC.NORMAL}IRC-UNO started by {IRC.BOLD}{playerName}{IRC.BOLD} - Type {IRC.BOLD}.ujoin{IRC.BOLD} to join!";

        public static string GAME_STOPPED(string playerName) => $"{IRC.NORMAL}Game stopped by {playerName}.";

        public static string JOINED(string playerName, int playerNumber)
            =>
                $"{IRC.NORMAL}Dealing {IRC.BOLD}{playerName}{IRC.BOLD} into the game as player {IRC.BOLD}#{playerNumber}{IRC.BOLD}!";

        public static string ALREADY_JOINED(string playerName)
            => $"{IRC.NORMAL}You're already in the game, {playerName}.";

        public static string NEEDS_TO_DEAL(string playerName)
            => $"{IRC.NORMAL}{IRC.BOLD}{playerName}{IRC.BOLD} needs to deal.";

        public static string NEXT_PLAYER(string playerName, string cardCount)
            => $"{IRC.NORMAL}{IRC.BOLD}{playerName}{IRC.BOLD} ({IRC.BOLD}{cardCount}{IRC.BOLD} cards)";

        public static string NEXT_START() => $"{IRC.NORMAL}Next: ";

        public static string NO_SCORES() => $"{IRC.NORMAL}No scores yet";

        public static string NOT_ENOUGH() => $"{IRC.NORMAL}Not enough players to deal yet.";

        public static string NOT_STARTED() => $"{IRC.NORMAL}Game not started, type {IRC.BOLD}.uno{IRC.BOLD} to start!";

        public static string ON_TURN(string playerName) => $"{IRC.NORMAL}It's {IRC.BOLD}{playerName}'s{IRC.BOLD} turn.";

        public static string OWNER_CHANGE(string playerName, string nextPlayer)
            =>
                $"{IRC.NORMAL}Owner {IRC.BOLD}{playerName}{IRC.BOLD} has left the game. New owner is {IRC.BOLD}{nextPlayer}{IRC.BOLD}.";

        public static string PASSED(string playerName) => $"{IRC.NORMAL}{IRC.BOLD}{playerName}{IRC.BOLD} passed!";

        public static string PLAYER_LEAVES(string playerName)
            => $"{IRC.NORMAL}Player {IRC.BOLD}{playerName}{IRC.BOLD} has left the game.";

        public static string REVERSED() => $"{IRC.NORMAL}Order reversed!";

        public static string SCORE_ROW(string playerName, int rank, int points, int games, int games_won, int ptsPerGame,
            int pctWin) => $"{IRC.NORMAL}{playerName}: {IRC.BOLD}#{rank}{IRC.BOLD} " +
                           $"({IRC.BOLD}{points}{IRC.BOLD} points, {IRC.BOLD}{games}{IRC.BOLD} games, {IRC.BOLD}{games_won}{IRC.BOLD} won,"
                           +
                           $" {IRC.BOLD}{ptsPerGame}{IRC.BOLD} points per game, {IRC.BOLD}{pctWin}{IRC.BOLD} percent wins)";

        public static string SKIPPED(string playerName) => $"{IRC.NORMAL}{IRC.BOLD}{playerName}{IRC.BOLD} is skipped!";

        public static string TOP_CARD(string playerName, string topCard)
            => $"{IRC.NORMAL}{IRC.BOLD}{playerName}'s{IRC.BOLD} turn. Top Card: {IRC.BOLD}{topCard}{IRC.BOLD}";

        public static string UNO(string playerName)
            => $"{IRC.NORMAL}{IRC.RED}UNO! {IRC.BOLD}{playerName}{IRC.BOLD} has ONE card left!{IRC.NOCOLOR}";

        public static string WD4(string playerName)
            => $"{IRC.NORMAL}{IRC.BOLD}{playerName}{IRC.BOLD} draws four and is skipped!";

        public static string WIN(string playerName, int playerCount)
            =>
                $"{IRC.NORMAL}We have a winner! {IRC.BOLD}{playerName}{IRC.BOLD} beats {IRC.BOLD}{playerCount}{IRC.BOLD} player(s)!";

        public static string YOUR_CARDS(string cards) => $"{IRC.NORMAL}Your cards: {IRC.BOLD}{cards}{IRC.BOLD}";

        public static string ALREADY_STARTED(string startedBy)
            =>
                $"{IRC.NORMAL}Game already started by {IRC.BOLD}{startedBy}{IRC.BOLD}! Type {IRC.BOLD}.ujoin{IRC.BOLD} to join!";

        public static string CANT_STOP(string startedBy)
            => $"{IRC.NORMAL}{IRC.BOLD}{startedBy}{IRC.BOLD} is the game owner, you can't stop it!";

        public static string CARDS(string cards) => $"{IRC.NORMAL}Cards: {IRC.BOLD}{cards}{IRC.BOLD}";

        public static string D2(string target) => $"{IRC.NORMAL}{IRC.BOLD}{target}{IRC.BOLD} draws two and is skipped!";

        public static string DEALING_IN(string playerName, int playerNumber)
            =>
                $"{IRC.NORMAL}Dealing {IRC.BOLD}{playerName}{IRC.BOLD} into the game as player {IRC.BOLD}#{playerNumber}{IRC.BOLD}!";

        public static string DOESNT_PLAY(string playerName)
            => $"{IRC.NORMAL}That card does not play, {IRC.BOLD}{playerName}{IRC.BOLD}!";

        public static string DONT_HAVE(string playerName)
            => $"{IRC.NORMAL}You don't have that card, {IRC.BOLD}{playerName}{IRC.BOLD}!";

        public static string DRAW_FIRST(string playerName)
            => $"{IRC.NORMAL}{IRC.BOLD}{playerName}{IRC.BOLD}, you need to draw first!";

        public static string DRAWN_ALREADY()
            => $"{IRC.NORMAL}You've already drawn, either {IRC.BOLD}.pass{IRC.BOLD} or {IRC.BOLD}.play{IRC.BOLD}!";

        public static string DRAWN_CARD(string card) => $"{IRC.NORMAL}Drawn card: {IRC.BOLD}{card}{IRC.BOLD}";

        public static string DRAWS(string playerName) => $"{IRC.NORMAL}{IRC.BOLD}{playerName}{IRC.BOLD} draws a card";

        public static string ALREADY_DEALT() => $"{IRC.NORMAL}Already dealt.";
    }
}