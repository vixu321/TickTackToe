using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class WinnerText : MonoBehaviour {

	private Text winnerText;
	
	void Awake () {
		winnerText = GetComponent<Text>();

	}
	

	void Update () {

		winnerText.text = "Wygral " + GameMaster.wygranyText;
	}
}