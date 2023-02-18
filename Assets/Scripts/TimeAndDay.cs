using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TimeAndDay : MonoBehaviour
{
    string currentTime;

    void Update()
    {

		if (!Settings.Instance.paused)
		{
            UIManager.Instance.dayText.text = DateTime.UtcNow.ToString() + " UTC" + "\nReal Time";
            currentTime = DateTime.UtcNow.ToString();
		}
		else
		{
            UIManager.Instance.dayText.text = currentTime + " UTC" + "\n<color=red>Paused</color>";
		}
        
    }
}
