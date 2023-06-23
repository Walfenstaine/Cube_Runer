using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InstantGamesBridge;

public class Loot : MonoBehaviour
{
    [SerializeField] private Language language;
    public AudioClip clip;
    public Data data;
    public LootTipe tipe;
    public enum LootTipe {bullets, coins, hilka}
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            SoundPlayer.regit.sorse.PlayOneShot(clip);
            if (tipe == LootTipe.bullets)
            {
                int mas = data.record + (int)data.playerFrtune;
                if (Bridge.platform.language == "ru")
                {
                    Subtitres.regit.subtitres = language.ru + " + " + mas;
                }
                else
                {
                    Subtitres.regit.subtitres = language.en + " + " + mas; ;
                }
                data.bulets += mas;
                Destroy(gameObject);
            }
            if (tipe == LootTipe.coins)
            {
                int mas = data.record + (int)data.playerFrtune;
                if (Bridge.platform.language == "ru")
                {
                    Subtitres.regit.subtitres = language.ru + " + " + mas; ;
                }
                else
                {
                    Subtitres.regit.subtitres = language.en + " + " + mas; ;
                }
                data.coins += mas;
                Destroy(gameObject);
            }
            if (tipe == LootTipe.hilka)
            {
                int mas = data.record + (int)data.playerFrtune;
                if (Bridge.platform.language == "ru")
                {
                    Subtitres.regit.subtitres = language.ru;
                }
                else
                {
                    Subtitres.regit.subtitres = language.en;
                }
                Gun.rid.Hill();
                Destroy(gameObject);
            }
        }
    }
}
