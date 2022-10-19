
using UnityEngine;
using UnityEngine.UI;

public class Food : MonoBehaviour
{
	[SerializeField] private float food = 100;
	[SerializeField] private Slider slider;
	[SerializeField] private UIScene scenes;
	[SerializeField] private GameObject gameover;
	public void setFood(float food)
	{
		this.food += food * Time.deltaTime;
	}
	private void Update()
	{
		slider.value = food;
		if (food <= 0)
		{
			scenes.SetModal(true, gameover);
			food = 0;
		}
		if (food >= 100)
		{
			food = 100;
		}
	}
}
