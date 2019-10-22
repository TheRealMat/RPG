using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creature : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {


    }

    public Item equippedWeapon = Item.ItemList[0];




    public int health;
    public int ac;
    public int strength;
    public int dexterity;
    public int constitution;
    public int intelligence;
    public int wisdom;
    public int charisma;
    public int proficiencyBonus;

    public List<string> Proficiencies = new List<string>
    {

    };

    public List<string> Resistances = new List<string>
    {

    };

    public void GetHurt(int damage, string damagetype)
    {
        foreach (string resistance in Resistances)
        {
            if (damagetype == resistance)
            {
                damage = damage / 2;
            }
        }

        this.health -= damage;
        if (health <= 0)
        {
            Debug.Log(name + " fucking died");
            Destroy(gameObject);
            Tracker.Remove(this.gameObject);
            // instantiate (corpse, transform.position, transform.rotation) though i should probably use cellposition
        }
    }
    // Update is called once per frame
    void Update()
    {
    }
}
