using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hire : MonoBehaviour
{
	private void OnTriggerStay(Collider collision)
	{
		if (collision.name == "cat")
		{
			collision.GetComponent<Temperature>().setTemp(11f);
		}
	}
}
