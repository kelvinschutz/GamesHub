using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public List<Dropdown.OptionData> LocationOptions { get; set; }
    public List<Dropdown.OptionData> GameOptions { get; set; }
    public List<Dropdown.OptionData> XPLevelOptions { get; set; }

    void Awake()
    {
        LocationOptions = new List<Dropdown.OptionData>()
        {
            new Dropdown.OptionData() {text = "-Select Location-" },
            new Dropdown.OptionData() {text = "Fargo, ND" },
            new Dropdown.OptionData() {text = "Moorhead, MN" }
        };

        GameOptions = new List<Dropdown.OptionData>()
        {
            new Dropdown.OptionData() {text = "-Select Game-" },
            new Dropdown.OptionData() {text = "Settlers of Catan" },
            new Dropdown.OptionData() {text = "D&D" },
            new Dropdown.OptionData() {text = "Ticket To Ride" }
        };

        XPLevelOptions = new List<Dropdown.OptionData>()
        {
            new Dropdown.OptionData() {text = "-Select Exp Level-" },
            new Dropdown.OptionData() {text = "Casual" },
            new Dropdown.OptionData() {text = "Experienced" },
            new Dropdown.OptionData() {text = "Hardcore" }
        };

    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
