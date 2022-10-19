
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using System.Collections.Generic;

public class TextTask : MonoBehaviour
{
	[SerializeField] private TMP_Text text;



	private void Start()
	{

		var tasks = new Dictionary<int, string>()
				{
						{ 1, "Найдите хоть кого-то"},
						{ 2, "Помочь найти еду"},
				};
		text.text = "Задание: \n" + tasks[1];
	}
}
