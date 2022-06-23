using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    public int currentNumSoul;
    public GameObject map;

    private void Awake()
    {
        currentNumSoul = 0;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public MapController GetMapController()
    {
        return map.GetComponent<MapController>();
    }
}
