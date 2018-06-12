using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryMenu : MonoBehaviour {
    public Text ShowMoney;
    public GameObject stick;
    public GameObject sword;
    public GameObject shield;
    public GameObject stout;
    // Use this for initialization
    void Start () {
        ShowMoney.text = Global.money.ToString();
    }
	public void Back()
    {
        Application.LoadLevel(2);
    }
    public void EquipStick(){
        if (Global.atc != 30){
            Global.atc = 30;
        }
        Global.atc = Global.atc + 20;
    }
    public void EquipSword(){
                if (Global.atc != 30){
            Global.atc = 30;
        }
        Global.atc = Global.atc + 40;
    }
    public void EquipShield(){
        if (Global.hp != 3){
            Global.hp = 3;
        }
        Global.hp = Global.hp + 1;
    }
    public void EquipStout(){
                if (Global.hp != 3){
            Global.hp = 3;
        }
        Global.hp = Global.hp + 3;
    }
    void Update (){
        ShowMoney.text = Global.money.ToString();
        if (Global.stick)
        Stick.SetActive(true);
        if (Global.sword)
        Sword.SetActive(true);
        if (Global.shield)
        Shield.SetActive(true);
        if (Global.stout)
        Stout.SetActive(true);
    }
}
