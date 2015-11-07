using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Tile : MonoBehaviour {


    public Vector2 gridPosition = Vector2.zero;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        // make the tile under the current unit blue
	
	}


    void OnMouseEnter()
    {
        transform.GetComponent<Renderer>().material.color = Color.blue;

        // Determine which unit has the current turn
        int iCurPlayer = GameManager.instance.GetCurrentPlayer();
        
        List<Player> players = GameManager.instance.GetPlayers();
        // Determine where the current unit is located

        //foo = Object_In_Scene.GetComponent(); Vector3 bar = foo.position;

        Vector3 myPos = players[iCurPlayer].GetPosition(); // world location of player unit

        // determine tile location of player unit.
        int i = (int)(Mathf.Floor(GameManager.instance.mapSize / 2) + myPos.x); // x
        int j = (int)(Mathf.Floor(GameManager.instance.mapSize / 2) - myPos.z); // z

        /// TODO: prevent user from selecting occupied tile

        Debug.Log("Player at (" + i + "-" + j + ")");
        if (Mathf.Abs(i - gridPosition.x) < players[iCurPlayer].GetMaxMove() && Mathf.Abs(j - gridPosition.y) < players[iCurPlayer].GetMaxMove())
        {
            // if the mouse is within one tile of the current unit, make the square green
            transform.GetComponent<Renderer>().material.color = Color.green;
        }
        else
        {
            // else make the tile red
            transform.GetComponent<Renderer>().material.color = Color.red;
        }

        Debug.Log("My position is (" + gridPosition.x + ", " + gridPosition.y + ")");
    }

    void OnMouseExit()
    {
        transform.GetComponent<Renderer>().material.color = Color.white;
    }

    void OnMouseDown()
    {
        GameManager.instance.moveCurrentPlayer(this);
    }

}
