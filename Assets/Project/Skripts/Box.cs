using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Box : MonoBehaviour
{
    public Material[] material;
    public MeshRenderer render;
    public int number;
    public Text num;
    public string[] nums;
    private void Start()
    {
        render.material = material[number];
        num.text = nums[number];
    }
    private void OnTriggerEnter(Collider other)
    {
        if (number == Player.rid.number)
        {
            Player.rid.number += 1;
            Destroy(gameObject);
        }
        else
        {
            if (Player.rid.number > 0)
            {
                Player.rid.number -= 1;
                Destroy(gameObject);
            }
        }
    }
    private void Update()
    {
        transform.position -= transform.forward * 5 * Time.deltaTime;
    }
}
