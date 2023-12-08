using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class effectMusic : MonoBehaviour
{
    public void SoundOnOff()
    {
        soundmanager.Instance.ToggleEfects();
    }
    public void musicOnOff()
    {
        soundmanager.Instance.ToggleMusic();
    }
}
