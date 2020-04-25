using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BllinkingButter : MonoBehaviour
{
    private Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        StartCoroutine(FadeInAndOut(100));
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator FadeInAndOut(float duration)
    {
        for (float t = 0f; t < duration; t += Time.deltaTime)
        {
            Color c = rend.material.color;
            c.a = c.a - 0.0001f;
            rend.material.color = c;
            yield return null;

        }
    }
}
