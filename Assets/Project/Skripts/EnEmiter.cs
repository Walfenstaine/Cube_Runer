using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnEmiter : MonoBehaviour
{
    public GameObject[] enemy;
    public Transform emiter;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            int index = Random.Range(0, enemy.Length);
            Instantiate(enemy[index], emiter.position, Quaternion.identity);
        }
    }
}
