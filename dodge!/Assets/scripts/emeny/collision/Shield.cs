using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class Shield : MonoBehaviour
{
    [SerializeField] private AudioClip _shield;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            soundmanager.Instance.PlaySound(_shield);
            other.gameObject.GetComponent<Image>().color = new Color32(255, 255, 255, 160);
            Destroy(gameObject);
            other.GetComponent<Interaction>().defended = true;
            StartCoroutine(defend());
        }

        IEnumerator defend()
        {
            yield return new WaitForSeconds(6);
            other.gameObject.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            other.GetComponent<Interaction>().defended = false;
        }
    }

    
}
