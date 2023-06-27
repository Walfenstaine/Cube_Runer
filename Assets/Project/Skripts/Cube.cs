using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer render;
    public Material[] mat;

    private void Update()
    {
        render.material = mat[Player.rid.number];
    }
}
