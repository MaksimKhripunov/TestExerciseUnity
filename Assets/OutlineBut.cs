using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class OutlineBut : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject gb;

   
    void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData)
    {
        gb.GetComponent<Image>().enabled = true;
    }

    void IPointerExitHandler.OnPointerExit(PointerEventData eventData)
    {
        gb.GetComponent<Image>().enabled = false;
    }
}
