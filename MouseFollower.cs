using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseFollower : MonoBehaviour
{
     GameObject[] eyes;
     GameObject parent;
     
     void Start () {
        this.parent = GameObject.Find("Bob");
	 	this.eyes = GameObject.FindGameObjectsWithTag("Eye");
     }
     
     void Update () {
     	Vector3 pos = Camera.main.ScreenPointToRay(Input.mousePosition).GetPoint(30);
	 	Vector3 invertedMousePos = new Vector3(-pos.x, -pos.y, pos.z);

	 	foreach(GameObject o in this.eyes) {
         	o.transform.LookAt(invertedMousePos + 7 * o.transform.position);
	 		o.transform.localRotation *= Quaternion.Euler(0, 180, 0);
	 	}
     }
}
