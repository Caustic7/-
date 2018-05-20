using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsMenu : MonoBehaviour {
    public void setMusic(float value)
    {
        Global.music = value;
    }
    public void setSound(float value)
    {
        Global.sound = value;
    }
    public void Back()
    {
        Application.LoadLevel(0);
    }
}
