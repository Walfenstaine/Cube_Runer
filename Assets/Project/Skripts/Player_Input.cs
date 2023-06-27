using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Input : MonoBehaviour {

	void Start () {

	}
	

	void Update () {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Player.rid.Interactive();
        }
    }
}
