using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Interaction : MonoBehaviour
{
    private int coin = 0;
    [SerializeField] private Text coinText;
    [SerializeField] private AudioClip _coin;
    [SerializeField] private AudioClip _loseSound;
    [SerializeField] private GameObject _missleScripts;
    [HideInInspector] public bool defended = false;
    [SerializeField] private GameObject diePanel;


    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.CompareTag("Coin"))
        {
            soundmanager.Instance.PlaySound(_coin);
            coin++;
            coinText.text = coin.ToString();
            Destroy(other.gameObject);
        }

        if (other.CompareTag("enemy") && defended == false)
        {
            Destroy(other.gameObject);
            PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") + coin);
            PlayerPrefs.SetInt("earnedScore", coin);
            _missleScripts.gameObject.SetActive(false);
            soundmanager.Instance.PlaySound(_loseSound);
            Destroy(this.gameObject); 
            diePanel.gameObject.SetActive(true);
        }
    }
}
