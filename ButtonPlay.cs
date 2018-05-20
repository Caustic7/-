using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ButtonPlay : MonoBehaviour {
    public Text ShowMoney;
    public int money = 0;
    // Use this for initialization
    public void Play()
    {
        Application.LoadLevel(4);
    }

    public void Shop()
    {
        Application.LoadLevel(3);
    }

    public void Inventory()
    {
        Application.LoadLevel(5);
    }

    public void Back()
    {
        Application.LoadLevel(0);
    }
    public void Start()
    {   
        ShowMoney.text = Global.money.ToString();
    }
    public void Write(float value)
    {
        Global.money = value;
    }
}
