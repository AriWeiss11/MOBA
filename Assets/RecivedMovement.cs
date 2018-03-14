using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecivedMovement : MonoBehaviour {


Vector3 newpositon; 
public float speed; 
public float walkrange;

public GameObject graphics;

	// Use this for initialization
	void Start () {
		
		newpositon = this.transform.position 



	}
	
	// Update is called once per frame
	void Update () {
		
		if the (Vector3.Distance (newpositon, this.transform.position) > walkrange)
		        this.transform.position = Vector3.MoveTowards(this.transform.position, newpositon, speed * time.deltaTime);
		        Quaternion transRot = Quaternion.LookRotation(newpositon - this.transform.position, Vector3.up);
		        graphics.transform.rotation = Quaternion.Slerp(transRot, graphics.transform.rotation, 0.2f);
	}
}

[PunRPC]
public void RecivedMove(Vector3 movePos)
    newpositon = movePos;
}


}

