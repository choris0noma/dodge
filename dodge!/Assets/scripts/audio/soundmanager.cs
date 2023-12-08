using UnityEngine;
using UnityEngine.UI;

public class soundmanager : MonoBehaviour
{
    public static soundmanager Instance;
    
    [SerializeField] private AudioSource _effectsSource;
    [SerializeField] private AudioSource _musicSoure;

    void Awake()
    {
        if (Instance == null){
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else{
            Destroy(gameObject);
        }
    }

    public void Start()
    {
        if (PlayerPrefs.GetInt("sound") == 1)
        {
            _effectsSource.mute = true;
        }
        else
        {
            _effectsSource.mute = false;
        }
        if (PlayerPrefs.GetInt("music") == 1)
        {
            _musicSoure.mute = true;
        }
        else
        {
            _musicSoure.mute = false;
        }
    }


    public void PlaySound(AudioClip clip)
    {
        _effectsSource.PlayOneShot(clip);
    }

    public void ToggleEfects()
    {
        _effectsSource.mute =! _effectsSource.mute;
        if (_effectsSource.mute)
        {
            PlayerPrefs.SetInt("sound", 1);
        }
        else
        {
            PlayerPrefs.SetInt("sound", 0);
        }
    }
    public void ToggleMusic()
    {
        _musicSoure.mute =! _musicSoure.mute;
        if (_musicSoure.mute)
        {
            PlayerPrefs.SetInt("music", 1);
        }
        else
        {
            PlayerPrefs.SetInt("music", 0);
        }
    }
}
