using UnityEngine;

public class Move : MonoBehaviour
{
	[SerializeField] private float Force;

	[SerializeField] private CharacterController controller;

	[SerializeField] private float smoothTime;

	[SerializeField] private Transform firstCamera;
	private float smooth;

	private void Update()
	{
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
		if (Input.GetKey(KeyCode.W))
		{
		}
	}
}
