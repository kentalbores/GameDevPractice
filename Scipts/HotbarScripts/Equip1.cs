using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Equip1 : MonoBehaviour
{
    private Stats st = new Stats();

    public void OnButtonClick()
    {
        st.setBuildMode(true);
    }
}
