using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5;
    private float timer = 5.0f;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        timer -= Time.deltaTime;
        if (timer < 0)
        {
            transform.position += Vector3.forward * Time.deltaTime * speed;
        }
    }
}
