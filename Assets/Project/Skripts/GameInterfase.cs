using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameInterfase : MonoBehaviour
{
    public Slider intensity;
    public Data data;
    public Image hPbar;
    public Text bullets, coins, record;
    private float mHalse;
    void Start()
    {
        mHalse = data.playerHalse;
        Muwer.rid.sensitivity = intensity.value;
    }
    private void OnEnable()
    {
        mHalse = data.playerHalse;
        if (Muwer.rid)
        {
            Muwer.rid.sensitivity = intensity.value;
        }
    }
    void Update()
    {
        hPbar.fillAmount = Gun.rid.helse / mHalse;
        bullets.text = "" + data.bulets;
        coins.text = "" + data.coins;
        record.text = "" + (data.record-1);
    }
}
