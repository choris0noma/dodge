using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{
    public Image image;
    private int checkColor;

    void Start()
    {
        image = GetComponent<Image>();
        
    }
    void Update()
    {
        checkColor = PlayerPrefs.GetInt("colorNum");
        if (checkColor == 1)
        {
            image.color = new Color32(45, 52, 255, 255);
        }
        else if (checkColor == 2)
        {
            image.color = new Color32(45, 147, 255, 255);
        }
        else if (checkColor == 3)
        {
            image.color = new Color32(45, 236, 255, 255);
        }
        else if (checkColor == 4)
        {
            image.color = new Color32(255, 131, 45, 255);
        }
        else if (checkColor == 5)
        {
            image.color = new Color32(255, 45, 57, 255);
        }
        else if (checkColor == 6)
        {
            image.color = new Color32(198, 98, 255, 255);
        }
        else
        {
            image.color = new Color32(41, 255, 134, 255);
        }
    }
}
