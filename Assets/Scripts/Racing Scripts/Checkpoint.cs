using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Checkpoint : MonoBehaviour
{
    static public int checkpointsHit = 0;
    [SerializeField] Collider checkpoint;
    // Start is called before the first frame update
    void Start()
    {
        checkpoint = GetComponent<Collider>();
    }
    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("hit checkpoint");
        checkpointsHit++;
        checkpoint.gameObject.SetActive(false);
   
    }
    

}
