using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
	[Header("Celestial Body Info")]

    public Text nameText, sizeText, massText, distanceText, satellitesText, rotationText, translationText, descriptionText;
	public GameObject CelestialInfoPanel;

	[Header("Hud")]
	[Space]

	public GameObject pauseButton;
	public Sprite pauseSprite;
	public Sprite unPauseSprite;
	public Text dayText;
	public Text timeOfDayText;

	[Header("Settings")]
	[Space]

	public GameObject settingsPanel;
	public Slider timeSpeedSlider;
	public Text timeSpeedText;
	public Toggle displayNamesToggle;
	public Slider volumeSlider;
	public Text volumeText;
	public Toggle showStarsToggle;
	public Toggle showSunLightToggle;

	public static UIManager Instance;
	private void Awake()
	{
		Instance = this;
	}

	public void Update()
	{
		timeSpeedText.text = Settings.Instance.timeSpeed.ToString();
		volumeText.text = Settings.Instance.volume.ToString();

		if (Settings.Instance.paused)
		{
			pauseButton.GetComponent<Image>().sprite = unPauseSprite;
		}
		else
		{
			pauseButton.GetComponent<Image>().sprite = pauseSprite;

		}
	}
}
