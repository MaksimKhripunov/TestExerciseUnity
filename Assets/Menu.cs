using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class Menu : MonoBehaviour
{

    bool pressBut;
    bool open;
    public RectTransform slider;
    public RectTransform button;
    public RectTransform skills;
    Vector2 vector;

    void Start()
    {
        open= false;
        vector = slider.anchorMin;
        slider.anchoredPosition = new Vector3(0f, -skills.sizeDelta.y,0f);
        
    }

    void Update()
    {
        if (pressBut && !open)
        {

            if (slider.anchorMin.y <= 0.4) {
                pressBut = false;
                open = true;
            }
            else
            {
                if (slider.anchorMin.y < 0.8)
                {
                    button.sizeDelta = new Vector2(120.75f, 126.105f);
                }
                vector.y -= 0.005f;
                slider.anchorMin = vector;
            }

        }else if (pressBut && open)
        {
            if (slider.anchorMin.y >= 1)
            {
                pressBut = false;
                open = false;
            }
            else
            {
                if (slider.anchorMin.y > 0.8)
                {
                    button.sizeDelta = new Vector2(0f, 0f);
                }
                vector.y += 0.005f;
                slider.anchorMin = vector;
            }
        }

    }

    public void pB()
    {
        pressBut = true;
    }

    
}