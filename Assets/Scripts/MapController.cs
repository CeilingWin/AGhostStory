using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : MonoBehaviour
{
    // Start is called before the first frame update
    private List<GameObject> _listLaneCube;
    private List<GameObject> _listMapObject;
    private void Awake()
    {
        // load lane data
        GameObject lane = GameObject.Find("Lane");
        _listLaneCube = new List<GameObject>();
        for (int i = 0; i < lane.transform.childCount; i++)
        {
            GameObject cube = lane.transform.GetChild(i).gameObject;
            if (cube.CompareTag("LaneCube"))
            {
                _listLaneCube.Add(cube);
                LaneBlock scp = cube.GetComponent<LaneBlock>();
                print("cube" + i + " -> coordinate" + scp.pos.x + " " + scp.pos.y);
            }
        }
        
        // load all object in map
        GameObject mapObjects = GameObject.Find("Objects");
        for (int i = 0; i < mapObjects.transform.childCount; i++)
        {
            _listMapObject.Add(mapObjects.transform.GetChild(i).gameObject);
            // todo
        }
    }

    public bool isOnLane(Vector2Int coordinate)
    {
        return this.GetLaneBlockByPos(coordinate) != null;
    }

    public bool IsTarget(Vector2Int coordinate)
    {
        var cube = this.GetLaneBlockByPos(coordinate);
        return cube.isTarget;
    }

    private LaneBlock GetLaneBlockByPos(Vector2Int pos)
    {
        foreach (var cube in _listLaneCube)
        {
            LaneBlock blockController = cube.GetComponent<LaneBlock>();
            if (blockController.pos.Equals(pos)) return blockController;
        }
        return null;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
