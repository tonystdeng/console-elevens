// Author: Tony Deng
// File Name: Program.cs
// Project Name: PASS 1 - Elevens
// Creation Date: 09/16/26
// Modified Date: 09/25/26
// Description: a fully playable version of the card game, Elevens in a 120x30 character terminal with dotnet
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime;

namespace PASS1;

class Program
{
    // const var

    
    // global var
    static Random rand = new Random();

    static void Main(string[] args)
    {
        // local var
        // intro out
        Console.WriteLine("Hello, World!");
        // input
        // processing
        // out
    }



    // CARD UTIL FUNCITONS
    // ###############################################################################

    /// <summary>
    /// makes a new deck of cards unshuffled without jokers
    /// </summary>
    /// <returns>a deck of cards unshuffled without jokers</returns>
    static List<int> NewCards()
    {
        List<int> returns = [];
        
        for (int i = 0; i < 52; i++)
        {
            returns.Add(i);
        }
        return returns;
    }

    /// <summary>
    /// shuffles a given deck of cards with the fisher yates algo
    /// </summary>
    /// <param name="cards">the deck to be shuffled</param>
    /// <returns> the shuffled deck of cards</returns>
    static List<int> FisherYates(List<int> cards)
    {
        for (int i = 0; i < cards.Count; i++)
        {
            int iIndex = cards.Count - i - 1;
            int jIndex = rand.Next(iIndex);

            int iValue = cards[iIndex];
            int jValue = cards[jIndex];

            cards[iIndex] = jValue;
            cards[jIndex] = iValue;
        }
        return cards;
    }

    /// <summary>
    /// checks if a card is a face card
    /// </summary>
    /// <param name="card">int representing a card</param>
    /// <returns>boolean determins if the card is a face</returns>
    static bool IsFace(int card)
    {
        switch (card % 13)
        {
            case 10:
            case 11:
            case 12:
            return true;
            
            default:
            return false;
        }
        // if (card % 13 is 10 or 11 or 12)
        // {
        //     return true;
        // }
        // return false;
    }

    /// <summary>
    /// converts an int representing a card to its display value
    /// </summary>
    /// <param name="card">int representing a card</param>
    /// <returns>a user acceptable repersentation of the card</returns>
    static char Display(int card)
    {
        char returns;

        switch (card % 13)
        {
            case 0:
            returns = 'A';
            break;

            case 10:
            returns = 'J';
            break;
            
            case 11:
            returns = 'Q';
            break;
            
            case 12:
            returns = 'K';
            break;
            
            default:
            returns = (char)card;
            break;
        }
        return returns;
    }
}
