using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillRedaktor : MonoBehaviour
{
    public AudioClip ok, off;
    public Text helse, atak, creet, fortune, coins;
    public Data data;

    public void Replay()
    {
        SaveAndLoad.Instance.Save();
        Gun.rid.helse = data.playerHalse;
    }
    public void Helse()
    {
        int h = (int)data.playerHalse - 99;
        if (h <= data.coins)
        {
            SoundPlayer.regit.sorse.PlayOneShot(ok);
            data.playerHalse += 10;
            data.coins -= h;
        }
        else {
            SoundPlayer.regit.sorse.PlayOneShot(off);
        }
    }
    public void Atak()
    {
        int a = (int)data.playerAtak;
        if (a <= data.coins)
        {
            SoundPlayer.regit.sorse.PlayOneShot(ok);
            data.playerAtak += 1;
            data.coins -= a;
        }
        else
        {
            SoundPlayer.regit.sorse.PlayOneShot(off);
        }
    }
    public void Kreet()
    {
        int k = (int)data.playerCreet;
        if (k <= data.coins)
        {
            SoundPlayer.regit.sorse.PlayOneShot(ok);
            data.playerCreet += 1;
            data.coins -= k;
        }
        else
        {
            SoundPlayer.regit.sorse.PlayOneShot(off);
        }
    }
    public void Fortune()
    {
        int f = (int)data.playerFrtune;
        if (f <= data.coins)
        {
            data.playerFrtune += 1;
            data.coins -= f;
        }
        else
        {
            SoundPlayer.regit.sorse.PlayOneShot(off);
        }
    }
    private void Update()
    {
        helse.text = "" + data.playerHalse;
        atak.text = "" + data.playerAtak;
        creet.text = "" + data.playerCreet;
        fortune.text = "" + data.playerFrtune;
        coins.text = "" + data.coins;
    }
}
