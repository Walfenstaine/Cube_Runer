using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CracedObject : MonoBehaviour
{
    public Animator anim;
    public GameObject[] loot;
    public void OnCrack()
    {
        anim.SetFloat("Speed", 1);
        Destroy(GetComponent<BoxCollider>());
    }
    public void Destroyer()
    {
        int num = Random.Range(0, loot.Length);
        Instantiate(loot[num], transform.parent.position, Quaternion.identity);
    }
}
