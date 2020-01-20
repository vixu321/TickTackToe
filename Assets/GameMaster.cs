using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class GameMaster : MonoBehaviour {

	
	private int p1, p2, p3, p4, p5, p6, p7, p8, p9;
	public GameObject[] linie; 						//poz, pion, lew-praw, praw-lew
	public Sprite znaczekX, znaczekO, pustePole;
	public static int tura; 
	public GameObject ekranWygranej;
	private int wygrany;
	public static string wygranyText;
	public GameObject kolejX, kolejO;
	public static int klikniecia = 0;

	public static int zwyciestwaX, zwyciestwaO;

	public GameObject turaCalosc;

	
	
	
	// Use this for initialization
	void Start () {
		tura = 0;

	}
	
	void Update(){


	if(tura==1){	
		kolejO.SetActive(false);
		kolejX.SetActive(true);

		if(p1==1 && p2==1 && p3==1){
			linie[0].SetActive(true);
			wygrana();
			wygrany=1;
		}else if(p4==1&&p5==1&&p6==1){
			linie[1].SetActive(true);
			wygrana();
			wygrany=1;
		}else if(p7==1&&p8==1&&p9==1){
			linie[2].SetActive(true);
			wygrana();
			wygrany=1;
		}else if(p1==1&&p4==1&&p7==1){
			linie[3].SetActive(true);
			wygrana();
			wygrany=1;
		}else if(p2==1&&p5==1&&p8==1){
			linie[4].SetActive(true);
			wygrana();
			wygrany=1;	
		}else if(p3==1&&p6==1&&p9==1){
			linie[5].SetActive(true);
			wygrana();
			wygrany=1;
		}else if(p1==1&&p5==1&&p9==1){
			linie[6].SetActive(true);
			wygrana();
			wygrany=1;
		}else if(p3==1&&p5==1&&p7==1){
			linie[7].SetActive(true);
			wygrana();
			wygrany=1;
		}
	}
	else if(tura==0){
		kolejO.SetActive(true);
		kolejX.SetActive(false);
				if(p1==2 && p2==2 && p3==2){
			linie[0].SetActive(true);
			wygrana();
			wygrany=0;
		}else if(p4==2&&p5==2&&p6==2){
			linie[1].SetActive(true);
			wygrana();
			wygrany=2;
		}else if(p7==2&&p8==2&&p9==2){
			linie[2].SetActive(true);
			wygrana();
			wygrany=2;
		}else if(p1==2&&p4==2&&p7==2){
			linie[3].SetActive(true);
			wygrana();
			wygrany=2;
		}else if(p2==2&&p5==2&&p8==2){
			linie[4].SetActive(true);
			wygrana();
			wygrany=2;	
		}else if(p3==2&&p6==2&&p9==2){
			linie[5].SetActive(true);
			wygrana();
			wygrany=2;
		}else if(p1==2&&p5==2&&p9==2){
			linie[6].SetActive(true);
			wygrana();
			wygrany=2;
		}else if(p3==2&&p5==2&&p7==2){
			linie[7].SetActive(true);
			wygrana();
			wygrany=2;
		}
	}


		if(wygrany==0){
			wygranyText="X";
			zwyciestwaX+=1;
		}else if(wygrany==1){
			wygranyText="O";
			zwyciestwaO+=1;
		}

	}

	public void zakreslPole(int pole){
		
	if(tura==0){
		if(pole==1){
			p1=1;
		}else if(pole==2){
			p2=1;
		}else if(pole==3){
			p3=1;
		}else if(pole==4){
			p4=1;
		}else if(pole==5){
			p5=1;
		}else if(pole==6){
			p6=1;
		}else if(pole==7){
			p7=1;
		}else if(pole==8){
			p8=1;
		}else if(pole==9){
			p9=1;
		}
	}else if(tura==1){
		if(pole==1){
			p1=2;
		}else if(pole==2){
			p2=2;
		}else if(pole==3){
			p3=2;
		}else if(pole==4){
			p4=2;
		}else if(pole==5){
			p5=2;
		}else if(pole==6){
			p6=2;
		}else if(pole==7){
			p7=2;
		}else if(pole==8){
			p8=2;
		}else if(pole==9){
			p9=2;
		}
	}
	}

	public void zmienObraz(Button przycisk){
			if(tura==0){
				przycisk.GetComponent<Image>().sprite = znaczekO;
				tura = 1;				
			}
			else if(tura == 1){
				przycisk.GetComponent<Image>().sprite = znaczekX;
				tura = 0;
			}
		przycisk.GetComponent<Button>().interactable = false;
		
	}
	public void Reset(){
		 Application.LoadLevel(Application.loadedLevel);
	}

	public void wygrana(){
		Time.timeScale = 0;
		turaCalosc.SetActive(false);
		ekranWygranej.SetActive(true);
		
	}

}
