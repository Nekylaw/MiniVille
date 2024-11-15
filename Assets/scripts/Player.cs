using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Rendering.GPUSort;

public class Player : MonoBehaviour
{
    public bool isAI;
    public int money = 3;
    public List<Card> cards;
    public List<Card> monuments = new();
    public List<Dice> dices = new() { new Dice() };
    public bool reroll = false;

    /*  ____à mettre dans game____
     *  
    public void activateCards(int diceRoll, Player activePlayer)
    {
        foreach (var card in cards)
        {
            if (card.card.diceValue1 == diceRoll || card.card.diceValue2 == diceRoll)
            {
                // Activation selon le type de carte
                if ((card.card.type == "red" && activePlayer != this) ||   // Rouge : tour d'un adversaire
                    (card.card.type == "green" && activePlayer == this) || // Verte : tour du joueur
                    (card.card.type == "blue"))                            // Bleue : toujours active
                {
                    card.Effect(this, );
                }
            }
        }
    }
    */
}
