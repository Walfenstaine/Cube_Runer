using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using InstantGamesBridge;

public class Interface : MonoBehaviour
{
    public UnityEvent gameer, menue, gamover, skill, andLVL, nullBK;
    public static Interface rid { get; set; }
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
    void Start()
    {
        Menu();
    }

    public void Menu()
    {
        menue.Invoke();
    }
    public void AndLVL()
    {
        andLVL.Invoke();
    }
    public void Skill()
    {
        skill.Invoke();
    }

    public void Game()
    {
        gameer.Invoke();
    }
    public void GameOver()
    {
        gamover.Invoke();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Menu();
        }
    }
}
