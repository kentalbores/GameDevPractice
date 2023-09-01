using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEditor;
using UnityEngine;

public class SpawningScript : MonoBehaviour
{
    private Vector3 mouseWorld, mouseScreen;
    public GameObject objectToSpawn;
    private Stats st = new Stats();
    private GameObject gmo;

    private void Start()
    {
        gmo = GameObject.Find("GemMine");
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && st.getBuildMode())
        {
            mouseScreen = Input.mousePosition;
            mouseWorld = Camera.main.ScreenToWorldPoint(mouseScreen);
            Instantiate(gmo, new Vector3(mouseWorld.x,mouseWorld.y,0f), quaternion.identity);
            st.setBuildMode(false);
        }
    }
}
