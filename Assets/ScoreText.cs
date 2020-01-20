using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class ScoreText : MonoBehaviour {

	private Text scoreText;
	public bool isO;

	void Awake(){
		scoreText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		
		if(isO==true){	
			scoreText.text = GameMaster.zwyciestwaO.ToString();
		}else if(isO==false) {		
			scoreText.text = GameMaster.zwyciestwaX.ToString();
		}
		
	}
}
