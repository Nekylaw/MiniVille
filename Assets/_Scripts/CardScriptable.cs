using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Rendering;


[CreateAssetMenu(fileName = "CardScriptable", menuName = "My game / CardScriptable")]
public class CardScriptable : ScriptableObject
{


    
    public int cost;
    public int gainValue;
    public string cardName;
    public string type;
    public string color;
    public GameObject spriteCard;
    public int stackable;
    public int anyRound;
    public int diceValue1;
    public int diceValue2;
    public int cardsLeftStore = 6;


}
