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
using System.Linq;
using System.Threading;

#endregion

// ReSharper disable InvertIf

namespace Leafy_IRCBot.UNO.Classes.UNOGame
{
    internal static class GetCard
    {
        private static readonly Random rndcard = new Random();
        private static readonly Random rndcolor = new Random();

        private const bool isTopCard = false;

        private static readonly List<string> Cards = new List<string>
        {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "R",
            "S",
            "D2",
            "W",
            "WD4"
        };

        private static readonly List<string> Deck = new List<string>();

        private static readonly List<string> Colors = new List<string> {"R", "G", "Y", "B"};

        public static void InitDeck()
        {
            Deck.Add($"{IRC.GREEN}[1]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.GREEN}[2]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.GREEN}[3]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.GREEN}[4]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.GREEN}[5]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.GREEN}[6]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.GREEN}[7]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.GREEN}[8]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.GREEN}[9]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.GREEN}[R]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.GREEN}[S]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.GREEN}[D2]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.GREEN}[1]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.GREEN}[2]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.GREEN}[3]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.GREEN}[4]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.GREEN}[5]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.GREEN}[6]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.GREEN}[7]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.GREEN}[8]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.GREEN}[9]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.GREEN}[R]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.GREEN}[S]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.GREEN}[D2]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.RED}[1]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.RED}[2]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.RED}[3]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.RED}[4]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.RED}[5]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.RED}[6]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.RED}[7]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.RED}[8]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.RED}[9]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.RED}[R]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.RED}[S]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.RED}[D2]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.RED}[1]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.RED}[2]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.RED}[3]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.RED}[4]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.RED}[5]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.RED}[6]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.RED}[7]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.RED}[8]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.RED}[9]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.RED}[R]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.RED}[S]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.RED}[D2]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.BLUE}[1]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.BLUE}[2]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.BLUE}[3]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.BLUE}[4]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.BLUE}[5]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.BLUE}[6]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.BLUE}[7]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.BLUE}[8]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.BLUE}[9]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.BLUE}[R]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.BLUE}[S]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.BLUE}[D2]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.BLUE}[1]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.BLUE}[2]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.BLUE}[3]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.BLUE}[4]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.BLUE}[5]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.BLUE}[6]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.BLUE}[7]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.BLUE}[8]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.BLUE}[9]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.BLUE}[R]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.BLUE}[S]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.BLUE}[D2]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.YELLOW}[1]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.YELLOW}[2]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.YELLOW}[3]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.YELLOW}[4]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.YELLOW}[5]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.YELLOW}[6]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.YELLOW}[7]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.YELLOW}[8]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.YELLOW}[9]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.YELLOW}[R]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.YELLOW}[S]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.YELLOW}[D2]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.YELLOW}[1]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.YELLOW}[2]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.YELLOW}[3]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.YELLOW}[4]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.YELLOW}[5]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.YELLOW}[6]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.YELLOW}[7]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.YELLOW}[8]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.YELLOW}[9]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.YELLOW}[R]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.YELLOW}[S]{IRC.NOCOLOR}");
            Deck.Add($"{IRC.YELLOW}[D2]{IRC.NOCOLOR}");
            Deck.Add("[W]");
            Deck.Add("[W]");
            Deck.Add("[W]");
            Deck.Add("[W]");
            Deck.Add("[WD4]");
            Deck.Add("[WD4]");
            Deck.Add("[WD4]");
            Deck.Add("[WD4]");
        }

        public static string DrawCards(int cardNumber)
        {
            var cardList = new List<string>();
            var cardString = string.Empty;
            var counter = 0;
            var pass = 0;

            do
            {
                Thread.Sleep(0);
                var r_card = rndcard.Next(Cards.Count);
                var randomCard = Cards[r_card];
                var cardIsValid = false;

                do
                {
                    if (randomCard.Equals("W") || randomCard.Equals("WD4"))
                    {
                        var result = $"[{randomCard}]";

                        if (result.Equals("[W]") && Deck.Contains("[W]"))
                        {
                            cardList.Add(result);
                            Deck.Remove(result);
                            CardPlayability.AddDealtCard(result);
                            cardIsValid = true;
                        }
                        if (result.Equals("[WD4]") && Deck.Contains("[WD4]"))
                        {
                            cardList.Add(result);
                            Deck.Remove(result);
                            CardPlayability.AddDealtCard(result);
                            cardIsValid = true;
                        }
                    }
                    else
                    {
                        var r_color = rndcolor.Next(Colors.Count);
                        var randomColor = Colors[r_color];
                        var result = colorToString(randomColor, randomCard);

                        if (Deck.Contains(result))
                        {
                            cardList.Add(result);
                            Deck.Remove(result);
                            CardPlayability.AddDealtCard(result);
                            cardIsValid = true;
                        }
                        else
                        {
                            Tools.ColoredWrite(ConsoleColor.Red, "THIS IS A FUCKING ERROR, OKAY?");
                        }
                    }
                    pass++;
                    if (pass == 104) // This shouldn't happen, there are only 104 cards in a full deck...
                    {
                        break;
                    }
                } while (!cardIsValid);

                if (pass == 104) // This shouldn't happen, there are only 104 cards in a full deck...
                {
                    break;
                }
                counter++;
            } while (counter != cardNumber);

            cardString = cardList.Aggregate(cardString, (current, card) => current + card);
            if (cardString.Count(x => x == '[') == cardNumber)
            {
                return !isTopCard ? Messages.CARDS(cardString) : cardString;
            }
            ResetPlayedCards();
            return null;
        }

        private static void ResetPlayedCards()
        {
            Program.client.SendMessage("No more cards in deck, reshuffling.", Config.IRC_ChannelName); // TODO Change this to allow multi-channel.
            Deck.Clear();
            InitDeck();
            foreach (var card in CardPlayability.DealtCards)
            {
                Deck.Remove(card);
            }
        }

        private static string colorToString(string color, string card)
        {
            switch (color.ToLower())
            {
                case "r":
                    return $"{IRC.RED}[{card}]{IRC.NOCOLOR}";
                case "g":
                    return $"{IRC.GREEN}[{card}]{IRC.NOCOLOR}";
                case "b":
                    return $"{IRC.BLUE}[{card}]{IRC.NOCOLOR}";
                case "y":
                    return $"{IRC.YELLOW}[{card}]{IRC.NOCOLOR}";
                default:
                    throw new NotImplementedException(); // This should never ever happen.
            }
        }
    }
}