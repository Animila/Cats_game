using UnityEngine;
using UnityEngine.UI;

public class Move : MonoBehaviour
{
	[SerializeField] private float Force = 5;

	[SerializeField] private CharacterController controller;

	[SerializeField] private float smoothTime;

	[SerializeField] private Transform firstCamera;

	[SerializeField] private float food = 100;
	[SerializeField] private Slider slider;
	private float smooth;

	public void setFood(float food)
	{
		this.food = food;
	}

	private void Update()
	{
		slider.value = food;
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
		}
		if (Input.GetKey(KeyCode.LeftShift) && food >= 0)
		{
			Force = 10;
			food -= 1;
		}
		else
		{
			Force = 5;
			food += 0.3f;
		}

		if (food >= 100)
		{
			food = 100;

		}
	}
}
