using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScene2Door : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("rotateLeft", 0.5f);
    }

    public float thrust = 2.0f;

    void FixedUpdate()
    {
        transform.position += this.transform.forward * thrust * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(Vector3.down * 0.5f * Time.deltaTime, Space.World);
     
    }

    void rotateLeft()
    {
        //transform.Rotate(Vector3.up * 180, Space.World);
        transform.rotation = Quaternion.identity;
        transform.RotateAround(transform.position + new Vector3(1f / 2f, 1f / 2f, 0f), Vector3.forward, 90f);
    }


}
