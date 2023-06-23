using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Data", order = 1)]
public class Data: ScriptableObject
{
    public int record;
    public int coins;
    public int bulets;
    public int lvlNumber;
    public string currentScene;

    public float playerHalse;
    public float playerAtak;
    public float playerCreet;
    public float playerFrtune;
    public bool soundOn;
}
