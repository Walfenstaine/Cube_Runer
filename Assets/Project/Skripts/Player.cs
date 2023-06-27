using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool active = false;
    public int number;
    public Animator anim;
    public float aspect;
    public static Player rid { get; set; }
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

    public void Interactive()
    {
        if (active)
        {
            NumUp();
        }
        else
        {
            NumDown();
        }
        active = !active;
    }
    public void NumUp()
    {
        number += 1;
    }
    public void NumDown()
    {
        number -= 1;
    }
    private void Update()
    {
        anim.SetFloat("Aspect",aspect);
        if (active)
        {
            if (aspect < 1)
            {
                aspect += Time.deltaTime;
            }
        }
        else
        {
            if (aspect > 0)
            {
                aspect -= Time.deltaTime;
            }
        }
    }
}
