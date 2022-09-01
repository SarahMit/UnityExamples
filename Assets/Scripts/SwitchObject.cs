using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchObject : MonoBehaviour
{
    // I attatched this script to the "Canvas" in the scene hierarchy :)

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

    // if the forward button is used
    public void NextScene()
    {
        if (activeIndex+1 < numberOfObjects)
        {
            print("Load Next Object");
            objects[activeIndex].SetActive(false);
            activeIndex++;
            objects[activeIndex].SetActive(true);
            slider.value = activeIndex;
        }
        else
        {
            print("No more object available.");
        }

    }

    // if the backward button is used
    public void PreviousScene()
    {
        if (activeIndex - 1 >= 0)
        {
            print("Load Previous Object");
            objects[activeIndex].SetActive(false);
            activeIndex--;
            objects[activeIndex].SetActive(true);
            slider.value = activeIndex;
        }
        else
        {
            print("No more object available.");
        }
    }

    // if the slider is used
    public void moveSlider()
    {
        print("test");
        if (slider.value > activeIndex)
        {
            activeIndex = (int)slider.value;
            NextScene();
        }
        else
        {
            activeIndex = (int)slider.value;
            PreviousScene();
        }
    }
}
