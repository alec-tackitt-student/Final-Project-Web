using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UItrackers : MonoBehaviour
{
    [SerializeField] Text lapCount;
    [SerializeField] Text time;
    private Text[] texts;
    // Start is called before the first frame update
    void Start()
    {
        texts = GetComponentsInChildren<Text>();
        lapCount = texts[0];
        time = texts[1];
        StartCoroutine(UiTracking());
    }

    IEnumerator UiTracking()
    {
        while (true)
        {
            lapCount.text = "laps: " + RaceTracker.laps;
            time.text = "Time: " + RaceTracker.time.ToString();

            yield return null;
        }
    }
}
