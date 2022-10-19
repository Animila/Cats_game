using UnityEngine;
using UnityEngine.UI;

public class Move : MonoBehaviour
{
	[SerializeField] private float Force = 5;

	[SerializeField] private CharacterController controller;

	[SerializeField] private float smoothTime;

	[SerializeField] private Transform firstCamera;

	[SerializeField] private float runStrength = 100;
	[SerializeField] private Slider slider;
	private float smooth;

	public void setRunStrength(float food)
	{
		this.runStrength = food;
	}

	private void Update()
	{
		slider.value = runStrength;
		float horizontal = Input.GetAxisRaw("Horizontal");
		float vertical = Input.GetAxisRaw("Vertical");
		Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

		if (direction.magnitude >= 0.1f)
		{
			float rotationAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + firstCamera.eulerAngles.y;
			float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, rotationAngle, ref smooth, smoothTime);
			transform.rotation = Quaternion.Euler(0f, angle, 0f);
			Vector3 move = Quaternion.Euler(0f, rotationAngle, 0f) * Vector3.forward;
			controller.Move(move.normalized * Force * Time.deltaTime);
			GetComponent<Food>().setFood(-6f);
		}
		if (Input.GetKey(KeyCode.LeftShift) && runStrength >= 0)
		{
			Force = 10;
			runStrength -= 1;
			GetComponent<Food>().setFood(-10f);

		}
		else
		{
			Force = 5;
			runStrength += 0.3f;
		}

		if (runStrength >= 100)
		{
			runStrength = 100;

		}
	}
}
