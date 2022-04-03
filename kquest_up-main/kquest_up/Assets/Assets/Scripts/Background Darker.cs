using UnityEngine;
using System.Collections;

public class BackgroundDarker : MonoBehaviour

{
    SpriteRenderer sr;

    // Use this for initialization
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Color color = sr.color;
        color.a += Time.deltaTime * 0.1F;
        sr.color = color;
    }
}
