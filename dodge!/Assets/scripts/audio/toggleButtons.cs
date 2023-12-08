using UnityEngine;
using UnityEngine.UI;

public class toggleButtons : MonoBehaviour
{
    [SerializeField] private Button soundButton;
    [SerializeField] private Sprite _off;
    [SerializeField] private Sprite _on;
    [SerializeField] private Button musicButton;
    [SerializeField] private Sprite _off1;
    [SerializeField] private Sprite _on1;
    public void Update()
    {
        if (PlayerPrefs.GetInt("sound") == 1)
        {
            soundButton.GetComponent<Image>().sprite = _off;
        }
        else
        {
            soundButton.GetComponent<Image>().sprite = _on;
        }
        if (PlayerPrefs.GetInt("music") == 1)
        {
            musicButton.GetComponent<Image>().sprite = _off1;
        }
        else
        {
            musicButton.GetComponent<Image>().sprite = _on1;
        }
    }
}
