using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour {

    //public Transform headTransform;
    public Transform target;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void LateUpdate () {
        transform.LookAt(target);
        //Quaternion lookRotation = Quaternion.LookRotation(target.position - headTransform.position);
        //headTransform.rotation *= lookRotation;
	}
}
