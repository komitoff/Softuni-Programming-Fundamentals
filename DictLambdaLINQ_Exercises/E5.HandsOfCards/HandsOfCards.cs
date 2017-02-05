using System;
using System.Collections.Generic;
using System.Linq;

class HandsOfCards
{
    static void Main()
    {
        string input = Console.ReadLine();
        var playersScore = new Dictionary<string, Dictionary<List<string>, int>>();

        while (!input.Equals("JOKER"))
        {
            string[] playerHands = input.Split(':');
            string player = playerHands[0];
            string hand = playerHands[1];
            List<string> cards = hand.Split(',').ToList();
            if (!playersScore.ContainsKey(player))
            {
                playersScore.Add(player, new Dictionary<List<string>, int>);
            }

        }


    }



    private static int CalcHandStrength(HashSet<string> uniqueCards)
    {
        int strength = 0;
        //fill the types of the cards
        Dictionary<char, int> cardTypes = new Dictionary<char, int>();
        cardTypes['S'] = 4;
        cardTypes['H'] = 3;
        cardTypes['D'] = 2;
        cardTypes['C'] = 1;

        //fill the card powers
        Dictionary<char, int> cardPowers = new Dictionary<char, int>();
        cardPowers['1'] = 10;
        cardPowers['2'] = 2;
        cardPowers['3'] = 3;
        cardPowers['4'] = 4;
        cardPowers['5'] = 5;
        cardPowers['6'] = 6;
        cardPowers['7'] = 7;
        cardPowers['8'] = 8;
        cardPowers['9'] = 9;
        cardPowers['J'] = 11;
        cardPowers['Q'] = 12;
        cardPowers['K'] = 13;
        cardPowers['A'] = 14;

        foreach (var card in uniqueCards)
        {
            char cardPower = card[1];
            char cardType = card[card.Length - 1];
            strength += cardPowers[cardPower] * cardTypes[cardType];
        }
        return strength;
    }
}