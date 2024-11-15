using Unity.VisualScripting;
using UnityEngine;
using System.Collections.Generic;
using System;
public class Card : MonoBehaviour
{


    public CardScriptable card = new CardScriptable();
    public MonumentScriptable monument;

    List<Card> unlockedMonuments = new List<Card>(); //Liste où y aura tous les monuments débloqués par le joueur / ia
    


    //La fonction qui gère les effets des cartes hors monuments

    //CardPlayed correspond à la carte joué pendant le tour actuel (est définit dans la classe player)
    public void Effect(player cardPlayed, string playerSendingEffect, string playerReceivingEffect, int moneyCurrentlayer)
    {

        
        if (cardPlayed.color == "Bleu")
        {
            playerSendingEffect.money += cardPlayed.gainValue;
            playerReceivingEffect.money += cardPlayed.gainValue;
            
        }
        if (cardPlayed.color == "Rouge")
        {
            playerReceivingEffect.money += cardPlayed.gainValue;
        }
        if (cardPlayed.color == "Vert")
        {
            if (cardPlayed.name)
                playerSendingEffect.money += cardPlayed.gainValue;
        }
        if (cardPlayed.color == "Violet")
        {

            playerSendingEffect.money += cardPlayed.gainValue;
            playerReceivingEffect.money -= cardPlayed.gainValue;
        }



    }
    //Gère les effets des monuments
    public void monumentEffect()
    {

        foreach(var monument in unlockedMonuments)
        {
            if(monument.name == "Gare")
            {
                player.nbDiceAllowed = 2;
            }
            if(monument.name == "Tour radio")
            {
                player.rerollDice = true;
            }
            if(monument.name == "Centre commercial")
            {
                foreach(var card in listCardPlayer)
                {
                    if(card.type == "Restauration" || card.type == "Magasin")
                    {
                        card.gainValue += 1;
                    }
                    
                }
            }
            if(monument.name == "Parc")
            { 
                if(player.dice1 == PlayerPrefs.dice2)
                {

                }
            }

        }
    }








    void Start()
    {
        
    }

   
    void Update()
    {
        
    }
}
