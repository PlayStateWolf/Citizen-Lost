using UnityEngine;

public class p : MonoBehaviour
{

    //assign this field in inspector:

    public Transform subject;

    public float _depthOffset = 0f;

    Camera _camera;

    void Start()
    {

        //copy a reference to main camera, for both convenience and performance:

        _camera = Camera.main;

    }

    void Update()
    {

        //update rotation:

        Vector3 mousePositionWorldSpace = _camera.ScreenToWorldPoint(Input.mousePosition);

        Vector3 pointOfInterest = mousePositionWorldSpace + _camera.transform.forward * _depthOffset;

        Vector3 direction = pointOfInterest - subject.position;

        subject.rotation = Quaternion.LookRotation(direction);

    }

}

