using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("w") || Input.GetKeyDown("up"))
        {
            gameObject.GetComponent<Movement>().TryMove(0, 1);

        }
        if (Input.GetKeyDown("s") || Input.GetKeyDown("down"))
        {
            gameObject.GetComponent<Movement>().TryMove(0, -1);

        }
        if (Input.GetKeyDown("a") || Input.GetKeyDown("left"))
        {
            gameObject.GetComponent<Movement>().TryMove(-1, 0);

        }
        if (Input.GetKeyDown("d") || Input.GetKeyDown("right"))
        {
            gameObject.GetComponent<Movement>().TryMove(1, 0);

        }

    }

}
