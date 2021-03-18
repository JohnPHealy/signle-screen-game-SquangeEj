using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    float spd = 10;
    void Update()
    {
        transform.position += Vector3.right / spd;
    }
}
