using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene2Sound3 : MonoBehaviour
{
    private AudioSource S3S1;

    // Start is called before the first frame update
    void Start()
    {
        S3S1 = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            S3S1.Play();
            S3S1.loop = true;
        }
    }
}
