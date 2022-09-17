using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunMovement : MonoBehaviour
{
    public float SunSpeed = 1f;
    private void FixedUpdate()
    {
        SunSpeed++;
        transform.eulerAngles = new (SunSpeed,0,0);
    }
}
