using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Temperature : MonoBehaviour
{
	[SerializeField] private float minTemp = -45f;
	[SerializeField] private float maxTemp = 25f;
	[SerializeField] private float temp = 25f;
	[SerializeField] private Slider slider;

	[SerializeField] private UIScene scenes;
	[SerializeField] private GameObject gameover;
	private void Update()
	{
		temp -= 10 * Time.deltaTime;
		slider.value = temp;
		if (minTemp >= temp)
		{
			Time.timeScale = 0f;
			scenes.SetModal(true, gameover);
		}
	}
}
