using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScene3Tiger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("rotateLeft", 7);
    }

    public float thrust = 2.0f;

    void FixedUpdate()
    {
        transform.position += this.transform.forward * thrust * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.down * 2.0f * Time.deltaTime, Space.World);
        Invoke("rotateLeft2", 3);
        Invoke("rotateLeft3", 7);
    }

    void rotateLeft()
    {
        transform.Rotate(Vector3.up * 180, Space.World);
    }
    void rotateLeft2()
    {
        transform.Rotate(Vector3.up * 10.0f * Time.deltaTime, Space.World);
    }
    void rotateLeft3()
    {
        transform.Rotate(Vector3.down * 15.0f * Time.deltaTime, Space.World);
    }
}
