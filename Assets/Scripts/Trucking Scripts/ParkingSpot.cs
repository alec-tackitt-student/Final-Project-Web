using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ParkingSpot : MonoBehaviour
{
    
    public Text scoreDisplay;
    public Animator animator;
    private bool hasHit = false;
    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Car"))
        {
            if (Truckingrating.score >= 95)
            {
                scoreDisplay.text = "Three Stars!";
                animator.SetInteger("Stars", 3);
                License.points += 3;
                Debug.Log("ADDED:" + License.points);
            }
            else if (Truckingrating.score >= 90)
            {
                scoreDisplay.text = "Two Stars!";
                animator.SetInteger("Stars", 2);
                License.points += 2;
                Debug.Log("ADDED:" + License.points);
            }
            else
            {
                scoreDisplay.text = "One Star!";
                animator.SetInteger("Stars", 1);
                License.points += 1;
                Debug.Log("ADDED:" + License.points);
            }
            print("exit Scene");
            Invoke("LicenseScreen", 2);
        }
    }

    private void LicenseScreen()
    {
        SceneManager.LoadScene("License Screen");
    }
}
