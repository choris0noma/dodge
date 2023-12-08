using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    [SerializeField] private Text bestScore;
    [SerializeField] private AudioClip newScore;
    int scorecount;

    private void Start()
    {
        scorecount = PlayerPrefs.GetInt("earnedScore");
        if (scorecount > PlayerPrefs.GetInt("best",0))
        {
            PlayerPrefs.SetInt("best",scorecount);
            soundmanager.Instance.PlaySound(newScore);

        }
        bestScore.text = PlayerPrefs.GetInt("best").ToString();
    }
}
