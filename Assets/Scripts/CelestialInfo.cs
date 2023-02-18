using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CelestialInfo : MonoBehaviour
{

    public string name,size,mass,distance,satellites,rotation,translation,description;

	private void OnMouseEnter()
	{
		UIManager.Instance.CelestialInfoPanel.SetActive(true);

		UIManager.Instance.nameText.text = name;
		UIManager.Instance.sizeText.text = size;
		UIManager.Instance.distanceText.text = distance;
		UIManager.Instance.satellitesText.text = satellites;
		UIManager.Instance.rotationText.text = rotation;
		UIManager.Instance.translationText.text = translation;
		UIManager.Instance.descriptionText.text = description;
		UIManager.Instance.massText.text = mass;
	}

	private void OnMouseExit()
	{
		UIManager.Instance.CelestialInfoPanel.SetActive(false);
	}
}
