using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector2Int pos;

    private GameController _gameController;
    private MapController _mapController;
    private bool _canControl;
    void Start()
    {
        _gameController = GameObject.Find("GameController").GetComponent<GameController>();
        _mapController = _gameController.GetMapController();
        var position = transform.position;
        pos.x = (int) Math.Round(position.x);
        pos.y = (int) Math.Round(position.z);
        _canControl = false;
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
        if (!_mapController.isOnLane(pos))
        {
            print("cant move");
            return;
        }
        this.pos = pos;
        this.transform.position = new Vector3(pos.x, transform.position.y, pos.y);
        if (_mapController.IsTarget(this.pos))
        {
            print("win");
        }
    }
}
