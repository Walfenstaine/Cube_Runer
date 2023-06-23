using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Data data;
    public float helse = 10;
    public GameObject bullet;
    public AudioClip clip, damage, ded;
    public ParticleSystem pS;
    public Animator anim;
    public static Gun rid { get; set; }
    private bool relod = false;
    void Awake()
    {
        helse = data.playerHalse;
        if (rid == null)
        {
            rid = this;
        }
        else
        {
            Destroy(this);
        }
    }
    public void Hill()
    {
        float raz = data.playerHalse - helse;
        if (raz < data.playerFrtune*20)
        {
            helse = data.playerHalse;
        }
        else
        {
            helse += data.playerFrtune * 20;
        }
    }
    void OnDestroy()
    {
        rid = null;
    }

    public void Ded()
    {
        if (!anim.GetBool("Ded"))
        {
            Muwer muwer = Muwer.rid;
            muwer.enabled = false;
            anim.SetBool("Ded", true);
            SoundPlayer.regit.sorse.PlayOneShot(ded);
            helse = 0;
        }
    }
    public void GameOver()
    {
        Interface iF = Interface.rid;
        iF.GameOver();
        Destroy(this);
    }
    public void Shut() {
        if (!relod)
        {
            if (data.bulets > 0)
            {
                data.bulets -= 1;
                anim.SetBool("Shut", true);
                pS.Play();
                SoundPlayer.regit.sorse.PlayOneShot(clip);
                relod = true;
                Instantiate(bullet, transform.position + transform.forward * 2, transform.rotation);
            }
            else
            {
                Interface.rid.NullBK();
            }
        }   
    }
    public void Damage()
    {
        if (helse > data.record + 10)
        {
            SoundPlayer.regit.sorse.PlayOneShot(damage);
            relod = true;
            anim.SetBool("Damage", true);
            helse -= data.record + Random.Range(1,10);
        }
        else
        {
            Ded();
        }
    }
    public void Reload() {
        anim.SetBool("Shut", false);
        relod = false;
        anim.SetBool("Damage", false);
    }
}
