using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public void MeleeWeaponAttack(GameObject target)
    {
        if (target.GetComponent<Creature>().ac <= Random.Dice("1d20") + ScoreFromWeapon(gameObject.GetComponent<Creature>().equippedWeapon)) // also add proficiency if you are proficient in the weapon
        {
            Debug.Log("Attack hit");
            target.GetComponent<Creature>().GetHurt(Random.Dice(gameObject.GetComponent<Creature>().equippedWeapon.dice) + ScoreFromWeapon(gameObject.GetComponent<Creature>().equippedWeapon), gameObject.GetComponent<Creature>().equippedWeapon.damageType);
        }
        else
        {
            Debug.Log("Attack missed");
        }
    }

    int ScoreFromWeapon(Item weapon)
    {
        int value = 0;

        if (weapon.attribute == "strength")
        {
            value = (gameObject.GetComponent<Creature>().strength - 10) / 2;
        }
        else if (weapon.attribute == "dexterity")
        {
            value = (gameObject.GetComponent<Creature>().dexterity - 10) / 2;

        }
        else if (weapon.attribute == "finesse")
        {
            if (gameObject.GetComponent<Creature>().dexterity > gameObject.GetComponent<Creature>().strength)
            {
                value = (gameObject.GetComponent<Creature>().dexterity - 10) / 2;
            }
            else
            {
                value = (gameObject.GetComponent<Creature>().strength - 10 ) / 2;
            }
        }
        return value;
    }




    // Update is called once per frame
    void Update()
    {

    }
}
