using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lane : MonoBehaviour
{
    // Start is called before the first frame update
    private List<GameObject> listLaneCube;
    void Start()
    {
        listLaneCube = new List<GameObject>();
        for (int i = 0; i < transform.childCount; i++)
        {
            GameObject cube = transform.GetChild(i).gameObject;
            if (cube.CompareTag("LaneCube"))
            {
                listLaneCube.Add(cube);
                LaneCube scp = cube.GetComponent<LaneCube>();
                print("cube" + i + " -> coordinate" + scp.pos.x + " " + scp.pos.y);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public bool isOnLane(Vector2Int coordinate)
    {
        return this.getLaneCubeByPos(coordinate) != null;
    }

    public bool isTarget(Vector2Int coordinate)
    {
        var cube = this.getLaneCubeByPos(coordinate);
        return cube.isTarget;
    }

    private LaneCube getLaneCubeByPos(Vector2Int pos)
    {
        foreach (var cube in listLaneCube)
        {
            LaneCube cubeController = cube.GetComponent<LaneCube>();
            if (cubeController.pos.Equals(pos)) return cubeController;
        }
        return null;
    }
}
