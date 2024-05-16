using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 

public class RaceTracker : MonoBehaviour
{

    static public int laps = 0;
    static public float time = 0;
    static public float lastTime = 0;
    public GameObject checkpoits;
    

    public Text scoreDisplay;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        laps = 0;
        time = 0;
        lastTime = 0;
        
    } 
    
    private void OnTriggerEnter(Collider other)
    {
        StopAllCoroutines();
        if (Checkpoint.checkpointsHit >= 12)
        {
            laps++;
            Debug.Log(laps);
        }

        lastTime += time;
        time = 0;

        StartCoroutine(Timer());
        for(int i = 0; i < checkpoits.transform.childCount; i++)
        {
            checkpoits.transform.GetChild(i).gameObject.SetActive(true);
        }
        Checkpoint.checkpointsHit = 0;

        if (laps == 2)
        {
            
            if (lastTime <= 240)
            {
                scoreDisplay.text = "Three Stars!";
                animator.SetInteger("Stars", 3);
                License.points += 3;
                Debug.Log(License.points);
            }
            else if (lastTime <= 260)
            {
                scoreDisplay.text = "Two Stars!";
                animator.SetInteger("Stars", 2);
                License.points += 2;
                Debug.Log(License.points);
            }
            else
            {
                scoreDisplay.text = "One Star!";
                animator.SetInteger("Stars", 1);
                License.points += 1;
                Debug.Log(License.points);
            }
            Debug.Log(License.points);
            Invoke("LicenseScreen", 2);
        }
    }

    private void LicenseScreen()
    {
        SceneManager.LoadScene("License Screen");
    }

    IEnumerator Timer()
    {
        while (true)
        {
            time += Time.smoothDeltaTime;
            yield return null;
        }
    }
}
