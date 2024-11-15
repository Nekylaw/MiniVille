using Unity.VisualScripting;
using UnityEngine;
using System.Collections.Generic;
using System;
public class Card : MonoBehaviour
{


    public CardScriptable info = new CardScriptable();
    public MonumentScriptable monument;

    List<Card> unlockedMonuments = new List<Card>(); 
    


    //La fonction qui g�re les effets des cartes hors monuments

    //CardPlayed correspond � la carte jou� pendant le tour actuel (est d�finit dans la classe player)
    public void Effect(Player playerSendingEffect, Player playerReceivingEffect)
    {

        
        if (info.color == "Bleu")
        {



            playerSendingEffect.money += info.gainValue;
            playerReceivingEffect.money += info.gainValue;

            
        }
        if (info.color == "Rouge")
        {
            playerReceivingEffect.money += info.gainValue;
        }
        if (info.color == "Vert")
        {
            /*if (card.name)
                playerSendingEffect.money += card.gainValue;*/
        }
        if (info.color == "Violet")
        {

            playerSendingEffect.money += info.gainValue;
            playerReceivingEffect.money -= info.gainValue;
        }



    }
    //G�re les effets des monuments
    public void monumentEffect(Player player)
    {

        foreach(var monument in unlockedMonuments)
        {
            if(monument.name == "Gare")
            {
                player.dices.Add(new Dice());
            }
            if(monument.name == "Tour radio")
            {
                player.reroll = true;
            }
            if(monument.name == "Centre commercial")
            {
                foreach(var card in player.cards)
                {
                    if(card.info.type == "Restauration" || card.info.type == "Magasin")
                    {
                        card.info.gainValue += 1;
                    }
                }

            }
            if(monument.name == "Parc")
            {
                if (player.dices[0].face == player.dices[1].face)
                {
                    //rejouer c'est pas mon probleme :)
                }
            }

    //    }
    








    void Start()
    {
        
    }

   
    void Update()
    {
        
    }
}
