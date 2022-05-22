using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    // Update is called once per frame
    Vector3 pos;
    float speed;
    private void Awake()
    {
        pos = transform.position;
        speed = 10;
    }
    void Update()
    {
        transform.Translate(0, speed*Time.deltaTime, 0);
    }
}
