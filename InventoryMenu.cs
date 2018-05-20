using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryMenu : MonoBehaviour {
    public Text ShowMoney;
    // Use this for initialization
    void Start () {
        ShowMoney.text = Global.money.ToString();
    }
	public void Back()
    {
        Application.LoadLevel(2);
    }
    public void Sell()
    {

    }
	// Update is called once per frame
	void Update () {
		
	}
}
