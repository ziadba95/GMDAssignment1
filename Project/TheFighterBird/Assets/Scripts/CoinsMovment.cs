using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsMovment : MonoBehaviour
{
    public float Speed = 1;


    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * Speed, Space.World);

    }
}
