using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropdownXPOptions : MonoBehaviour {

    public GameManager gm;
    private Dropdown dropdown;

    private void Awake()
    {
        gm = FindObjectOfType<GameManager>();
        dropdown = gameObject.GetComponent<Dropdown>();
    }

    // Use this for initialization
    void Start()
    {
        dropdown.options = gm.XPLevelOptions;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
