using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyMove : MonoBehaviour
{
    // 키버튼을 이용해서 움직이자.
    Vector3 pos;
    public float speed;
    private void Start()
    {
        pos = transform.position;
        speed = 1;
    }
    void Update()
    {
        pos.x += speed * Input.GetAxisRaw("Horizontal") * Time.deltaTime;
        pos.y += speed * Input.GetAxisRaw("Vertical") * Time.deltaTime;
        transform.position = pos;
    }
}
