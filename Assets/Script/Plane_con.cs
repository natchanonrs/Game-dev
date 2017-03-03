using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane_con : MonoBehaviour {

	public GameObject prefab;
	public GameObject current;
	public GameObject cam;

	private float pos=0;

	void Start () {
		pos = cam.transform.position.z;
		for (int i = 0; i < 4; i++) {
			SpawnPlane ();
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (Mathf.Abs(cam.transform.position.z - pos) >= 10) {
			pos = cam.transform.position.z;
			Debug.Log ("pos : " + pos);
			if (pos >= 0) {
				SpawnPlane ();	
			}
		}
	}
		
	void SpawnPlane(){
		current = (GameObject)Instantiate (prefab, current.transform.GetChild(0).GetChild(2).position, Quaternion.identity);
	}
}
