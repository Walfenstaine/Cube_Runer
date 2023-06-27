using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Number : MonoBehaviour
{
    public Text num;
    public string[] nm;
    void Update()
    {
        num.text = nm[Player.rid.number];
    }
}
