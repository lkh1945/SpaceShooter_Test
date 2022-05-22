using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    private void Update()
    {
        transform.Translate(0, -0.01f, 0);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Bullet"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
