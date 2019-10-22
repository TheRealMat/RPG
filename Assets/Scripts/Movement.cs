using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // snaps object to the grid
        GridLayout gridLayout = transform.parent.GetComponentInParent<GridLayout>();
        Vector3Int cellPosition = gridLayout.WorldToCell(transform.position);
        transform.position = gridLayout.CellToWorld(cellPosition);

        Tracker.Units.Add(gameObject);

    }
    public Tilemap tile; // should be assigned to middle by default
    Vector3Int currentCell;



    public void TryMove(int x, int y)
    {
        Vector3Int movingto = new Vector3Int(currentCell.x + x, currentCell.y + y, currentCell.z);
        if (tile.GetTile(movingto) == null)
        {
            if (Tracker.CheckCoords(movingto) == null)
            {
                transform.position = new Vector2(currentCell.x + x, currentCell.y + y);
            }
            else
            {
                gameObject.GetComponent<Attack>().MeleeWeaponAttack(Tracker.CheckCoords(movingto));
                Debug.Log(Tracker.CheckCoords(movingto));
            }
        }
    }


    public Vector3Int getPos()
    {
        return currentCell;
    }

    // Update is called once per frame
    void Update()
    {
        currentCell = tile.WorldToCell(transform.position);













        //// old movement code
        //// beware ye who enter here
        //// also, attempting to move diagonally moves you more than it should. very strange
        //if (Input.GetKeyDown("w"))
        //{
        //    moveY = 1;
        //    ButtonPressed();
        //    cooldown = 0.4F;
        //}
        //if (Input.GetKeyDown("s"))
        //{
        //    moveY = -1;
        //    ButtonPressed();
        //    cooldown = 0.4F;

        //}
        //if (Input.GetKeyDown("a"))
        //{
        //    moveX = -1;
        //    ButtonPressed();
        //    cooldown = 0.4F;

        //}
        //if (Input.GetKeyDown("d"))
        //{
        //    moveX = 1;
        //    ButtonPressed();
        //    cooldown = 0.4F;

        //}
        //if (Input.GetKey("w") || Input.GetKey("s") || Input.GetKey("a") || Input.GetKey("d"))
        //{
        //    ButtonHeld();
        //}



        //void ButtonPressed()
        //{
        //    transform.position = new Vector2(transform.position.x + moveX, transform.position.y + moveY);

        //    startTime = Time.time;
        //}
        //void ButtonHeld()
        //{
        //    float timePressed = Time.time - startTime;
        //    if (timePressed >= cooldown)
        //    {
        //        transform.position = new Vector2(transform.position.x + moveX, transform.position.y + moveY);
        //        startTime = Time.time;
        //        if (cooldown > 0.1F)
        //        {
        //            cooldown -= 0.05F;
        //        }
        //    }

        //}

        //if (Input.GetKeyUp("w") || (Input.GetKeyUp("s")))
        //{
        //    cooldown = 0.4F;
        //    moveY = 0;
        //}
        //if (Input.GetKeyUp("a") || (Input.GetKeyUp("d")))
        //{
        //    cooldown = 0.4F;
        //    moveX = 0;
        //}





    }


}
