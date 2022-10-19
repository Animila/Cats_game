using UnityEngine;

public class hire : MonoBehaviour
{
	[SerializeField] private float time;

	public void setGame(float time)
	{
		this.time = time;
		Debug.Log(time);
	}

	private void OnTriggerStay(Collider collision)
	{
		collision.GetComponent<Temperature>().setTemp(11f);
		// destroy(time);
	}


	private void destroy(float time)
	{
		Destroy(gameObject, time * Time.deltaTime);
	}

}
