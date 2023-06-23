using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject boomer;
    public float speed;
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "Enemi")
        {
            other.GetComponent<EnemiAI>().Damage();
        }
        if (other.gameObject.tag == "CraCed")
        {
            other.GetComponent<CracedObject>().OnCrack();
        }
        if (other.gameObject.tag == "Key")
        {
            other.GetComponent<Key>().Kik();
        }
        Instantiate(boomer, transform.position, transform.rotation);
        Destroy(gameObject);
    }
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
        Destroy(gameObject, 25.0f);
    }
}
