using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BK_Menue : MonoBehaviour
{
    public Data data;
    public AudioClip clip;
    public Text coins;

    public void Bk_Rekl()
    {
        SoundPlayer.regit.sorse.PlayOneShot(clip);
        data.bulets += 30;
    }
    public void Bk_Coins()
    {
        SoundPlayer.regit.sorse.PlayOneShot(clip);
        data.bulets += 10;
        data.coins -= 100;
    }
    void Update()
    {
        coins.text = "" + data.coins;
    }
}
