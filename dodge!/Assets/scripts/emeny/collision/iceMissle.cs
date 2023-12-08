using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iceMissle : MonoBehaviour
{
    [SerializeField] private AudioClip _frozen;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            soundmanager.Instance.PlaySound(_frozen);
            other.GetComponent<Control>().force -=3;
            if (other.GetComponent<Control>().force <= 2)
            {
                other.GetComponent<Control>().force = 2;
            }
            Destroy(gameObject);
            StartCoroutine(unFreez());
        }
        IEnumerator unFreez()
        {
            yield return new WaitForSeconds(7);
            other.GetComponent<Control>().force +=3;
        }
    }
}
