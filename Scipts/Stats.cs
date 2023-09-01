using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats
{
    private static int gold = 0;
    private static int gpm = 1;
    private static Vector3 MousePosition;
    private static bool BuildMode = false;
    

    public void setBuildMode(bool con)
    {
        BuildMode = con;
    }
    public bool getBuildMode()
    {
        return BuildMode;
    }
    public int getGold()
    {
        return gold;
    }
    public void setGold(int amount)
    {
        gold = amount;
    }
    public void setGPM(int add)
    {
        gpm = add;
    }
    public int getGPM()
    {
        return gpm;
    }
}
