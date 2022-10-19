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

	public void setTemp(float temp)
	{
		this.temp += temp * Time.deltaTime;
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
	}
}
