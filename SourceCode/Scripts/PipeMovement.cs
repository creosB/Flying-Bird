using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{

    public float Speed;


    private void Start()
    {
        // 5 seconds after destroy pipes
        Destroy(gameObject, 8);
    }

    void FixedUpdate()
    {
        transform.position += Vector3.left * Speed * Time.deltaTime;
    }
}
