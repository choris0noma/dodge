using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkinControl : MonoBehaviour
{
    public int skinNum;
    public bool isPurchased;
    public string ppname;
    public int price;
    public int purch;
    private int picked;
    public Button buyButton;
    public Button equipButton;
    public Sprite equiped;
    public Sprite equip;
    public List<Button> listButtons;
    void Start()
    {
        purch = PlayerPrefs.GetInt(ppname, 0);
        picked = PlayerPrefs.GetInt("selectedSkin");

        if (purch != 0)
        {
            isPurchased = true;
            buyButton.gameObject.SetActive(false);
        }
        for (int i=0; i<=picked; i++)
        {
            if (i == picked)
            {
                listButtons[i].GetComponent<Image>().sprite = equiped;
            }
        }
    }

    public void buy()
    {
        if (isPurchased == false)
        {
            PlayerPrefs.SetInt(ppname, 1);
            PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - price);
            isPurchased = true;
            buyButton.gameObject.SetActive(false);
        }  
    }

    public void equiping()
    {
        if (isPurchased == true)
        {
            StartCoroutine(select());
            PlayerPrefs.SetInt("selectedSkin", this.skinNum);
        }
    }

    IEnumerator select()
    {
        PlayerPrefs.SetInt("skinChange", skinNum);
        foreach(Button button in listButtons)
        {
            button.GetComponent<Image>().sprite = equip;
        }
        yield return new WaitForSeconds(0.1f);
        equipButton.GetComponent<Image>().sprite = equiped;
    }
}