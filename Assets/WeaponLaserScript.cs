using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponLaserScript : MonoBehaviour
{
    public GameObject missile;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            var newMissile = Instantiate(missile);
            newMissile.transform.position = transform.position;
        }
    }
}
