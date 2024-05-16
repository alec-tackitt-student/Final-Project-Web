using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;



public class Truckingrating : MonoBehaviour
{
    [SerializeField] public static float score = 100;
    public Transform point;
   
    // Start is called before the first frame update
    void Start()
    {
        score = 100;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
      
        Vector3 impactVelocity = collision.relativeVelocity;
      
            score -= Mathf.Abs(impactVelocity.y) * 2;
        
        Debug.Log(collision.relativeVelocity);
    }

   
   

}
