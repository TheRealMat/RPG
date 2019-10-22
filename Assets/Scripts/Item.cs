using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{

    public string itemName;
    public string description;
    public string dice;
    public string damageType;
    public string attribute;
    public List<string> Proficiencies = new List<string>
    {

    };
    public Item(string itemName, string description, string dice, string damageType, string attribute)
    {
        this.itemName = itemName;
        this.description = description;
        this.dice = dice;
        this.damageType = damageType;
        this.attribute = attribute;
    }





    public static List<Item> ItemList = new List<Item>
    { 
        new Item("beans", "get beaned loser", "1d1", "bludgeoning", "strength")
    
    
    };





}
