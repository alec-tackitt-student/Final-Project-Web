using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Progressbar : MonoBehaviour
{
    [SerializeField] Image bar;
    [SerializeField] Text progress;
    [SerializeField] Text levelText;
    // Start is called before the first frame update
    void Start()
    {
        print("LOADED:" + License.points);
        bar = GetComponent<Image>();
        UpdateBar(License.points);

    }

    // Update is called once per frame
    public void UpdateBar(float points)
    {
        print("updateBAr");
        if (bar.fillAmount != null)
        {
            if (bar.fillAmount < 1)
            {
                bar.fillAmount = points / 100 ;
                Debug.Log(bar.fillAmount);
            }
            else if (bar.fillAmount >= 1) 
            {
                License.level++;
                levelText.text = "Level: " + License.level;
                bar.fillAmount -=1;
                points -= 100;
            }
        }
        progress.text = "Progress " + points +"%";
    }
}
