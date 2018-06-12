using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class MenuShop : MonoBehaviour {
    public Text ShowMoney;
	// Use this for initialization
	void Start () {
        ShowMoney.text = Global.money.ToString();
	}
	public void Back()
    {
        Application.LoadLevel(2);
    }
    public void stick()
    {
        if Global.money => 10
           Global.money = Global.money - 10;

    }

    public void sword()
    {
        if Global.money => 40
        Global.money = Global.money - 40;
    }

    public void shield()
    {
        if Global.money => 7
        Global.money = Global.money - 7;
    }

    public void stout()
    {
        if Global.money => 25
        Global.money = Global.money - 25;
    }
    // Update is called once per frame
    void Update () {
        ShowMoney.text = Global.money.ToString();
    }
}
