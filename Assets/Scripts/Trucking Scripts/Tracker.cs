using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Tracker : MonoBehaviour
{
    public Transform parkingSpot;

    public float rotationspeed = 3f;
   

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(parkingSpot.position- transform.position), rotationspeed * Time.deltaTime);
    }
}
