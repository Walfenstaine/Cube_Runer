using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddCoins : MonoBehaviour
{
    public Text text;
    public Data data;
    public AudioClip clip;
    private float coins;
    private void Start()
    {
        coins = data.record * 100;
    }
    public void Addcoins()
    {
        SoundPlayer.regit.sorse.PlayOneShot(clip);
        data.coins += (int)coins;
        SaveAndLoad.Instance.Save();
    }
    private void Update()
    {
        text.text = "+" + (int)coins;
        coins -= Time.unscaledDeltaTime;
    }
}
