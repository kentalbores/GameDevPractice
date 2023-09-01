using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIScript : MonoBehaviour
{
    private Stats st = new Stats();
    public TMP_Text tmp;
    void Update()
    {
        tmp.text = "Gold: " + st.getGold();
    }
}
