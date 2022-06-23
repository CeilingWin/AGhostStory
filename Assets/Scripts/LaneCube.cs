using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Serialization;

public class LaneCube : MonoBehaviour
{
    // Start is called before the first frame update
    [FormerlySerializedAs("coordinate")] public Vector2Int pos;
    public bool isTarget;
    void Start()
    {
        var position = transform.position;
        pos.x = (int) Math.Round(position.x);
        pos.y = (int) Math.Round(position.z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
