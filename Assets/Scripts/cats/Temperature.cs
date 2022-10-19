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
	private void Start()
	{
		slider.minValue = minTemp;
		slider.maxValue = maxTemp;
	}
	public void setTemp(float temp)
	{
		this.temp += temp * Time.deltaTime;
	}

	public void setGame(float temp, float maxTemp, float minTemp)
	{
		this.temp = temp;
		this.minTemp = minTemp;
		this.maxTemp = maxTemp;
	}

	private void Update()
	{
		temp -= 7 * Time.deltaTime;
		slider.value = temp;
		if (minTemp >= temp)
		{
			Time.timeScale = 0f;
			scenes.SetModal(true, gameover);
		}
		if (temp >= maxTemp)
		{
			temp = maxTemp;
		}
	}
}
