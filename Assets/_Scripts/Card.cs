using Unity.VisualScripting;
using UnityEngine;
using System.Collections.Generic;
using System;
public class Card : MonoBehaviour
{


    public CardScriptable card = new CardScriptable();
    public MonumentScriptable monument;

    List<Card> unlockedMonuments = new List<Card>(); 
    


 
    //public void Effect(player cardPlayed, string playerSendingEffect, string playerReceivingEffect, int moneyCurrentlayer)
    //{

        
    //    if (cardPlayed.color == "Bleu")
    //    {

    //        playerSendingEffect.money += cardPlayed.gainValue;
    //        playerReceivingEffect.money += cardPlayed.gainValue;

            
    //    }
    //    if (cardPlayed.color == "Rouge")
    //    {
    //        playerReceivingEffect.money += cardPlayed.gainValue;
    //    }
    //    if (cardPlayed.color == "Vert")
    //    {
    //        if (cardPlayed.name)
    //            playerSendingEffect.money += cardPlayed.gainValue;
    //    }
    //    if (cardPlayed.color == "Violet")
    //    {

    //        playerSendingEffect.money += cardPlayed.gainValue;
    //        playerReceivingEffect.money -= cardPlayed.gainValue;
    //    }


    //}







    //public void monumentEffect()
    //{

    //    foreach(var monument in unlockedMonuments)
    //    {
    //        if(monument.name == "Gare")
    //        {
    //            player.nbDiceAllowed = 2;
    //        }
    //        if(monument.name == "Tour radio")
    //        {
    //            player.rerollDice = true;
    //        }
    //        if(monument.name == "Centre commercial")
    //        {
    //            foreach(var card in listCardPlayer)
    //            {
    //                if(card.type == "Restauration" || card.type == "Magasin")
    //                {
    //                    card.gainValue += 1;
    //                }
                    
    //            }

    //        }
    //        if(monument.name == "Parc")
    //        { 
    //            if(player.dice1 == PlayerPrefs.dice2)
    //            {

    //            }
    //        }

    //    }
    








    void Start()
    {
        
    }

   
    void Update()
    {
        
    }
}
