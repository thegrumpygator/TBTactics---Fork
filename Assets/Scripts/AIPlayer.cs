using UnityEngine;
using System.Collections;

public class AIPlayer : Player {

    // Use this for initialization
    public int maxMoveDistance = 3;
    public float moveSpeed = 10.0f;

	void Start () {
	
	}

    public override int GetMaxMove()
    {
        return maxMoveDistance;
    }


    // Update is called once per frame
    void Update () {
	
	}
    public override void TurnUpdate()
    {
        if (Vector3.Distance(moveDestination, transform.position) > 0.1f)
        {
            transform.position += (moveDestination - transform.position).normalized * moveSpeed * Time.deltaTime;

            if (Vector3.Distance(moveDestination, transform.position) <= 0.1f)
            {
                transform.position = moveDestination;
                GameManager.instance.nextTurn();
            }
        }
        else
        {
            /// TODO: prevent AI from moving to occupied space
            moveDestination = new Vector3(0 - Mathf.Floor(GameManager.instance.mapSize / 2), 1.5f, -0 + Mathf.Floor(GameManager.instance.mapSize / 2));
        }

        base.TurnUpdate();
    }
}
