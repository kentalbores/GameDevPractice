using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TownHallScipt : MonoBehaviour
{
    public TMP_Text tmp;
    private SpriteRenderer sr;
    private static int thLevel = 0;
    private static int gpm = 0;
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }
    private void OnMouseDown()
    {
        thLevel++;
        gpm++;
        sr.color = Color.green;
        tmp.text = ("TH Level: " + thLevel);
    }

    private void OnMouseUp()
    {
        sr.color = Color.white;
    }

    
    public int GetThLevel()
    {
        return thLevel;
    }

}
