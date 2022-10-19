using UnityEngine;

public class newGame : MonoBehaviour
{
	public void startGame(int difficult)
	{
		if (difficult == 0)
		{
			GetComponent<UIScene>().ChangeScene("game");
			Debug.Log(GetComponent<hire>());
		}
		if (difficult == 1)
		{

		}
		if (difficult == 2)
		{

		}
	}
}
