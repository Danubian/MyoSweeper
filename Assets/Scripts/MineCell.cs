﻿using UnityEngine;
using System.Collections;

public class MineCell : Cell {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    override public void OnSelected()
    {
        Debug.Log("MineCell - OnSelected");
        GameObject explosion = Instantiate(Resources.Load("Fireworks")) as GameObject;
        explosion.transform.parent = this.transform;
        explosion.transform.position = this.transform.position;
        GameObject mines = GameObject.Find("Mines");
        foreach (Transform child in this.transform.parent.transform)
        {
            child.GetComponent<MineCell>().Unselect();
        }
    }
}
