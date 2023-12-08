using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ThemeControl : MonoBehaviour
{
    public int themeNum;
    public bool isPurchased;
    public string tname;
    public int price;
    public int purch;
    private int chosen;
    public Button buyButton;
    public Button equipButton;
    public Sprite equiped;
    public Sprite equip;
    public List<Button> listButtons;


    void Start()
    {
        purch = PlayerPrefs.GetInt(tname, 0);
        chosen = PlayerPrefs.GetInt("selectedTheme");
        
        if (purch != 0)
        {
            isPurchased = true;
            buyButton.gameObject.SetActive(false);
        }
        for (int i=0; i<=chosen; i++)
        {
            if (i == chosen)
            {
                listButtons[i].GetComponent<Image>().sprite = equiped;
            }
        }
        
    }

    public void buy()
    {
        if (isPurchased == false)
        {
            PlayerPrefs.SetInt(tname, 1);
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
            PlayerPrefs.SetInt("selectedTheme", this.themeNum);
        }
    }

    IEnumerator select()
    {
        PlayerPrefs.SetInt("colorNum", themeNum);
        foreach(Button button in listButtons)
        {
            button.GetComponent<Image>().sprite = equip;
        }
        yield return new WaitForSeconds(0.1f);
        equipButton.GetComponent<Image>().sprite = equiped;
    }
}
