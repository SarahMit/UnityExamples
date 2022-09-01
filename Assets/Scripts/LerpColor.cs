using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpColor : MonoBehaviour
{
    [SerializeField] float timeTillAlphaEqualsZero = 2.0f;
    Material material;
    private float t = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        material = GetComponent<Renderer>().material; 
    }

    IEnumerator Fade(float start, float end)
    {
        t = 0;
        while (material.GetFloat("_Alpha") != end)
        {
            // t =< 0 sets 1 as alpha, t>=1 sets 0 as alpha
            material.SetFloat("_Alpha", Mathf.Lerp(start, end, t));
            t += Time.deltaTime / timeTillAlphaEqualsZero;
            print("t: " + t);
            yield return null;
        }
    }

    public void FadeOut()
    {
        StartCoroutine(Fade(1.0f, 0.0f));
    }

    public void FadeIn()
    {
        StartCoroutine(Fade(0.0f, 1.0f));
    }
}