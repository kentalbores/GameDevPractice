using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MineScript : MonoBehaviour
{
    private float time = 0f;
    private Stats st = new Stats();
    public TMP_Text tmp2;
    private int upgradeCost = 10, gpm = 1;
    public ParticleSystem ps;
    private SpriteRenderer sr;

    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        tmp2.text = "Upgrade Cost: " + upgradeCost;
        time += Time.deltaTime;
        if (time >= 1f)
        {
            st.setGold(st.getGold() + gpm);
            Debug.Log("GPM: " + gpm);
            time = 0f;
        }
    }

    private void OnMouseDown()
    {
        if (st.getGold()>=upgradeCost)
        {
            gpm++;
            sr.color = Color.green;
            st.setGold(st.getGold() - upgradeCost);
            upgradeCost += 10;
            ps.Play();
        }
    }

    private void OnMouseUp()
    {
        sr.color = Color.white;
    }
}
