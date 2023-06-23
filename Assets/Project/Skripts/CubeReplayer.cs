using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeReplayer : MonoBehaviour
{
    public static CubeReplayer rid { get; set; }
    void Awake()
    {
        if (rid == null)
        {
            rid = this;
        }
        else
        {
            Destroy(this);
        }
    }
    void OnDestroy()
    {
        rid = null;
    }
}
