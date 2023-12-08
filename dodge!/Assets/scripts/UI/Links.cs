using UnityEngine;
using UnityEngine.UI;

public class Links : MonoBehaviour
{
    [SerializeField] private Image coinimage;
    [SerializeField] private Text text;
    [SerializeField] private Image coinimage1;
    [SerializeField] private Text text1;
    void Start()
    {
        if (PlayerPrefs.GetInt("zero") != 0)
        {
            coinimage.gameObject.SetActive(false);
            text.gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("first") != 0)
        {
            coinimage1.gameObject.SetActive(false);
            text1.gameObject.SetActive(false); 
        }
    }
    public void linkTT()
    {
        Application.OpenURL("https://twitter.com/mambaStudio_o");
        PlayerPrefs.SetInt("zero", 1);
        coinimage.gameObject.SetActive(false);
        text.gameObject.SetActive(false);
        if (PlayerPrefs.GetInt("reward") != 1)
        {
            PlayerPrefs.SetInt("earnedReward1", 25);
        }
        PlayerPrefs.SetInt("reward", 1);
    }

    public void linkYT()
    {
        Application.OpenURL("https://www.youtube.com/channel/UCRVTsm8H7jt-3jv2mxmqULw");
        PlayerPrefs.SetInt("first", 1);
        coinimage1.gameObject.SetActive(false);
        text1.gameObject.SetActive(false);
        if (PlayerPrefs.GetInt("reward1") != 1)
        {
            PlayerPrefs.SetInt("earnedReward2", 25);
        }
        PlayerPrefs.SetInt("reward1", 1);;
    }
}
