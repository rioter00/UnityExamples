using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetPrefs : MonoBehaviour
{
    public void resetPrefValues()
    {
        // nuke em all
        //PlayerPrefs.DeleteAll();
        //PlayerPrefs.Save();
        // set 'coins' pref to zero;
        PlayerPrefs.SetInt("Coins", 0);
    }
}
