using UnityEngine;

public class trash : MonoBehaviour
{
	private void OnTriggerStay(Collider collision)
	{
		collision.GetComponent<Food>().setFood(100f);
		Debug.Log(collision.name);
	}
}
