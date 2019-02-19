using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmControl : MonoBehaviour {

    public Camera m_cam;
    private Vector3 origin;
    private Vector3 camAngles;

    private Vector3 newEulerAngles;

	// Use this for initialization
	void Start () {
        origin = transform.rotation.eulerAngles;
        camAngles = m_cam.transform.rotation.eulerAngles;
        newEulerAngles = camAngles;
        //newEulerAngles.x = 0;
        //newEulerAngles.z = 0;
    }
	
	// Update is called once per frame
	void Update () {
        camAngles = m_cam.transform.rotation.eulerAngles;
        newEulerAngles = camAngles+origin;
        //newEulerAngles.x = 0;
        //newEulerAngles.z = 0;
        transform.eulerAngles = newEulerAngles;
        //transform.eulerAngles = newEulerAngles;
    }
}
