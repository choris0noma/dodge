using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSprite : MonoBehaviour
{
    public Sprite standart;
    public Sprite first;
    public Sprite second;
    public Sprite third;
    public Sprite fourth;
    public Sprite fifth;
    public Sprite sixth;
    public Sprite seventh;
    public Sprite eighth;
    public Sprite nineth;
    public Sprite tenth;
    public Sprite eleventh;
    public Sprite twelfth;
    public SpriteRenderer sr;
    private int checkSkin;

    void Start()
    {
        checkSkin = PlayerPrefs.GetInt("skinChange");

        if (checkSkin == 1)
        {
            sr.sprite = first;
        }
        else if (checkSkin == 2)
        {
            sr.sprite = second;
        }
        else if (checkSkin == 3)
        {
            sr.sprite = third;
        }
        else if (checkSkin == 4)
        {
            sr.sprite = fourth;
        }
        else if (checkSkin == 5)
        {
            sr.sprite = fifth;
        }
        else if (checkSkin == 6)
        {
            sr.sprite = sixth;
        }
        else if (checkSkin == 7)
        {
            sr.sprite = seventh;
        }
        else if (checkSkin == 8)
        {
            sr.sprite = eighth;
        }
        else if (checkSkin == 9)
        {
            sr.sprite = nineth;
        }
        else if (checkSkin == 10)
        {
            sr.sprite = tenth;
        }
        else if (checkSkin == 11)
        {
            sr.sprite = eleventh;
        }
        else if (checkSkin == 12)
        {
            sr.sprite = twelfth;
        }
        else
        {
            sr.sprite = standart;
        }
    }
}
