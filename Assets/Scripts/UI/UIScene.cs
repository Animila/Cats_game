using UnityEngine;
using UnityEngine.SceneManagement;

public class UIScene : MonoBehaviour
{
	[SerializeField] private GameObject pause;
	public void Awake()
	{
		Time.timeScale = 1f;
	}
	public void ChangeScene(string name)
	{
		SceneManager.LoadScene(name);
	}
	public void SetModal(bool status, GameObject modal)
	{
		Time.timeScale = 0f;
		modal.SetActive(status);
	}
	public void OpenModal(GameObject modal)
	{
		Time.timeScale = 1f;
		modal.SetActive(true);
	}
	public void CloseModal(GameObject modal)
	{
		Time.timeScale = 1f;
		modal.SetActive(false);
	}
	public void Exit()
	{
		Application.Quit();
	}
	private void Update()
	{
		if (Input.GetKey(KeyCode.F12) || Input.GetKey(KeyCode.Escape))
		{
			SetModal(true, pause);
		}
	}
}
