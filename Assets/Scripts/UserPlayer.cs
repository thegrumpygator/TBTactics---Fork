using UnityEngine;
using System.Collections;

public class UserPlayer : Player {

    // Use this for initialization
    public int maxMoveDistance = 3;
    public float moveSpeed = 10.0f;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public override int GetMaxMove()
    {
        return maxMoveDistance;
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

        base.TurnUpdate();
    }
}
