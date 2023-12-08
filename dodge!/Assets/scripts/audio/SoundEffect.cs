using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffect : MonoBehaviour
{
    [SerializeField] private AudioClip _clip;

    public void PlaySoundWhenPressed()
    {
        soundmanager.Instance.PlaySound(_clip);
    }
}
