using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tracker : MonoBehaviour
    // monobehavior assumes script is attached to an object
{
    // Start is called before the first frame update
    void Start()
    {
    }

    public static List<GameObject> Units = new List<GameObject>();
    //public static List<string> CoordList = new List<string>();



    // i need to find out which object i'm hitting specifically
    public static GameObject CheckCoords (Vector3Int xy)
    {
        GameObject returner = null;

        // checks if a gameobject in the list appear at this location
        foreach (GameObject unit in Units)
        {
            if (unit.GetComponent<Movement>().getPos() == xy)
            {
                returner = unit;
            }
        }
        return returner;
    }


    // goes through all units and returns the unit that matches the input
    public static GameObject Iterator (GameObject unga)
    {
        GameObject returner = null;
        foreach (GameObject unit in Units)
        {
            if (unit == unga)
            {
                returner = unit;
            }
        }
        return returner;
    }


    // i need to delete unit from units, but not while i'm in the foreach loop
    public static void Remove (GameObject toRemove)
    {
        if (Iterator(toRemove) != null)
        {
            Units.Remove(Iterator(toRemove));
        }

    }



    // Update is called once per frame
    void Update()
    {
        //// debugging. remove later
        //foreach (GameObject unit in Units)
        //{
        //    //Debug.Log(unit);
        //    //Debug.Log(unit.GetComponent<Movement>().getPos());
        //}
    }
}
