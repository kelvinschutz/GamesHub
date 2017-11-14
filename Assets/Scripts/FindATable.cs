using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindATable : MonoBehaviour {

    public GameObject[] Objects;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void FindTable()
    {
        foreach(var item in Objects)
        {
            item.SetActive(true);
        }
    }
}
