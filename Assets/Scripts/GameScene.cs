using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameScene : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject textSoul;
    void Start()
    {
        setNumSoul(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void setNumSoul(int num)
    {
        textSoul.GetComponent<TextMeshProUGUI>().text = "Soul " + num;
    }
}
