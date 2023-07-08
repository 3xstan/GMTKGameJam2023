using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformerPlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame, good for input
    void Update()
    {

    }

    // Update is called 50 times a second, good for motion
    void FixedUpdate()
    {

    }
}
