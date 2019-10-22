using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Random
{
    private static System.Random rng = new System.Random();
    public static int Dice(string d)
    {
        // anything before "d" is amount of dice, anything after is number of sides
        string[] words = d.Split('d');
        int diceAmount = Convert.ToInt32(words[0]);
        int diceValue = Convert.ToInt32(words[1]);
        int result = 0;

        for (int i = 0; i < diceAmount; i++)
        {
            result += rng.Next(diceValue) + 1;
        }

        return result;
    }
}
