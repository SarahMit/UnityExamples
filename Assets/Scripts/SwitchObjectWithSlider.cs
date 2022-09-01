using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SwitchObjectWithSlider : MonoBehaviour
{
    [SerializeField] Slider slider;
    [SerializeField] GameObject[] objects = new GameObject[1];

    int numberOfObjects;
    int activeIndex;

    // Start is called before the first frame update
    void Start()
    {
        numberOfObjects = objects.Length;

        for (int i = 0; i < numberOfObjects; i++)
        {
            objects[i].SetActive(false); // when starting the program disable all objects
        }

        activeIndex = 0;
        objects[activeIndex].SetActive(true);
    }

    public void moveSlider()
    {
        if (slider.value > activeIndex && activeIndex + 1 < numberOfObjects)
        {
            print("Load Next Object");
            objects[activeIndex].SetActive(false);
            activeIndex = (int)slider.value;
            objects[activeIndex].SetActive(true);
            slider.value = activeIndex;
        }
        
        if (slider.value < activeIndex && activeIndex - 1 >= 0)
        {
            print("Load Previous Object");
            objects[activeIndex].SetActive(false);
            activeIndex = (int)slider.value;
            objects[activeIndex].SetActive(true);
            slider.value = activeIndex;
        }
    }
}
