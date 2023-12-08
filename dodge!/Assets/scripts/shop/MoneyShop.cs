using UnityEngine;
using UnityEngine.UI;

public class MoneyShop : MonoBehaviour
{
    public int money;
    private int earnedMoney;
    private int reward1;
    private int reward2;
    public Text moneyText;

    public void Start()
    {
        money = PlayerPrefs.GetInt("Money");
        moneyText.text = money.ToString();
    }
}
