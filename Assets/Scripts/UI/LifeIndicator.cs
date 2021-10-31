using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeIndicator : MonoBehaviour
{
    int lifeCount;

    // Update is called once per frame
    void Update()
    {
        try
        {
            lifeCount = GameObject.FindWithTag("Player").GetComponent<Health>().currentLives;
        }
        catch
        {
            transform.GetChild(0).gameObject.SetActive(false);
        }

        if (lifeCount == 2)
        {
            transform.GetChild(2).gameObject.SetActive(false);
        }
        if (lifeCount == 1)
        {
            transform.GetChild(1).gameObject.SetActive(false);
        }
    }
}
