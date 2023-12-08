using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class skinsShop : MonoBehaviour
{
    [SerializeField] private Button buyButton, equipButton;
    [SerializeField] private Sprite equiped, equip; 
    [SerializeField] private int price, skinNumber;
    [SerializeField] private bool wasPurchased;
    [SerializeField] private GameObject skinsList;
    private list listOfSkins;
    int chosen;

    public void Start()
    {
        listOfSkins = skinsList.GetComponent<list>();
        chosen = PlayerPrefs.GetInt("skinsNumbers");       
        listOfSkins.skins[chosen].GetComponent<Image>().sprite = equiped;
    }
    public void Buy()
    {
        if(PlayerPrefs.GetInt("Money") >= price )
        {
            PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - price);
            wasPurchased = true;
        }
    }

    public void Equip()
    {
        if(wasPurchased == true)
        {
            PlayerPrefs.SetInt("skinsNumbers", skinNumber);
            foreach(Button button in listOfSkins.skins)
            {
                button.GetComponent<Image>().sprite = equip;
            }
            equipButton.GetComponent<Image>().sprite = equiped;
        }
    }
}
