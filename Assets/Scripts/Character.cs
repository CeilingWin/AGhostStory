using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector2Int pos;
    public GameObject lane;
    
    private Lane laneController;
    private bool canControl;
    void Start()
    {
        var position = transform.position;
        pos.x = (int) Math.Round(position.x);
        pos.y = (int) Math.Round(position.z);
        laneController = lane.GetComponent<Lane>();
        canControl = false;
        GetComponent<Rigidbody>().isKinematic = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        print("fsjeofjoejfoiejfie");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMoveUp()
    {
        MoveTo(pos + new Vector2Int(0,1));
    }

    public void OnMoveDown()
    {
        MoveTo(pos + new Vector2Int(0,-1));
    }
    
    public void OnMoveLeft()
    {
        MoveTo(pos + new Vector2Int(-1,0));
    }
    
    public void OnMoveRight()
    {
        MoveTo(pos + new Vector2Int(1,0));
    }

    private void MoveTo(Vector2Int pos)
    {
        if (!laneController.isOnLane(pos))
        {
            print("cant move");
            return;
        }
        this.pos = pos;
        transform.position = new Vector3(pos.x, transform.position.y, pos.y);
        if (laneController.isTarget(this.pos))
        {
            print("win");
        }
    }
}
