using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendInfo : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		bool RMB = input.GetMouseButtonDown (1);

		if (RMB)

		    RaycastHit hit 
		    Ray ray = Camera.main.ScreenPointToRay(input.mousePosition);

		    if (Physics.Raycast(ray, out hit) && hit.transform.tag == "New Terrain") {
		    	this.GetComponent<PhotonView>() .RPC("RecivedMove", PhotonTargets.ALL, hit.point);
		
	}
}
