using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public void RestartGameScene()
    {
        SceneManager.LoadScene("game");
    }
}
