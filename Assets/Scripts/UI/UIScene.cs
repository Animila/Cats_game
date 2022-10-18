using UnityEngine;
using UnityEngine.SceneManagement;

public class UIScene : MonoBehaviour
{
	public void ChangeScene(string name)
	{
		SceneManager.LoadScene(name);
	}

	public void Exit()
	{
		Application.Quit();
	}
}
