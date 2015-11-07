using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    // Use this for initialization
    public Vector3 moveDestination;

    void Awake()
    {
        moveDestination = transform.position;
    }

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public Vector3 GetPosition()
    {
        return transform.position;
    }

    public virtual int GetMaxMove()
    {
        return 1;
    }

    public virtual void TurnUpdate()
    {

    }

}
