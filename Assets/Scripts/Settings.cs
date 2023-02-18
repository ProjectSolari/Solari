using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour
{
    public bool paused = false;
    public float volume = 1;
    public float timeSpeed = 1;

    public bool displayNames;

    public static Settings Instance;

    public TextMesh[] celestialNames;

    public GameObject stars;
    public bool showStars;
    public bool showSunLight;
    public GameObject sunLight;

	private void Awake()
	{
        Instance = this;
	}
	void Update()
    {
        AdjustVolume();

        if(paused) { Time.timeScale = 0; } else { Time.timeScale = timeSpeed; }
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }

        timeSpeed = UIManager.Instance.timeSpeedSlider.value;
        displayNames = UIManager.Instance.displayNamesToggle.isOn;

        celestialNames = FindObjectsOfType<TextMesh>();

        stars.SetActive(UIManager.Instance.showStarsToggle.isOn);
        sunLight.SetActive(UIManager.Instance.showSunLightToggle.isOn);
		if (displayNames)
		{
			for (int i = 0; i < celestialNames.Length; i++)
			{
                celestialNames[i].color = new Color(celestialNames[i].color.r, celestialNames[i].color.g, celestialNames[i].color.b, 255);
            }

		}
		else
		{
            for (int i = 0; i < celestialNames.Length; i++)
            {
                celestialNames[i].color = new Color(celestialNames[i].color.r, celestialNames[i].color.g, celestialNames[i].color.b, 0);
            }
        }
    }

    public void Pause()
	{
        paused = !paused;
    }

    public void AdjustVolume()
	{
        AudioSource[] sources;
        volume = UIManager.Instance.volumeSlider.value;

        sources = FindObjectsOfType<AudioSource>();
		for (int i = 0; i < sources.Length; i++)
		{
            sources[i].volume = volume;
		}
	}

	public void ShowSettings()
	{
        UIManager.Instance.settingsPanel.SetActive(!UIManager.Instance.settingsPanel.activeSelf);
	}
}
