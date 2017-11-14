using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JoinTable : MonoBehaviour {

    public Text SeatsOpenText;
    public Image SeatImage;
    public Sprite ImageToSwap;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Join()
    {
        SeatsOpenText.text = "1/6 SEATS OPEN";
        SeatImage.sprite = ImageToSwap;
    }
}
