using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Image))]
public class TabButton : MonoBehaviour, IPointerClickHandler, IPointerExitHandler
{
    public TabGroup tabGroup;
    public Image background;
    [SerializeField] private AudioClip _selected;


    public void OnPointerClick(PointerEventData eventData)
    {
        soundmanager.Instance.PlaySound(_selected);
        tabGroup.OnTabSelected(this);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        tabGroup.OnTabExit(this);
    }
    
    void Start()
    {
        background = GetComponent<Image>();
        tabGroup.Subscribe(this);
    }
}
