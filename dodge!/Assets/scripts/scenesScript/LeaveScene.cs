using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LeaveScene : MonoBehaviour
{
    public void ChangeScenes()
    {
        SceneManager.LoadScene("menu");
        Time.timeScale = 1f;
    }
}
