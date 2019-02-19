using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoWayMovement : MonoBehaviour
{

    // Use this for initialization
    public GameObject target1;
    public GameObject target2;
    public float speed = 2.0f;
    public Vector3 offset = new Vector3(0f, 0f, 0f);
    private bool reverse = false;

    public float timeToLerp = 2;
    private Vector3 startingPosition;
    float timeLerped = 0.0f;

    void Start()
    {
        startingPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        /*float interpolation = speed * Time.deltaTime;
        Vector3 position = this.transform.position;
        if (!reverse)
        {
            position.y = Mathf.Lerp(this.transform.position.y, target2.transform.position.y + offset.y, interpolation);
            position.x = Mathf.Lerp(this.transform.position.x, target2.transform.position.x + offset.x, interpolation);
            position.z = Mathf.Lerp(this.transform.position.z, target2.transform.position.z + offset.z, interpolation);

            if (this.transform.position == target2.transform.position) reverse = !reverse;
        }
        else
        {
            position.y = Mathf.Lerp(this.transform.position.y, target1.transform.position.y + offset.y, interpolation);
            position.x = Mathf.Lerp(this.transform.position.x, target1.transform.position.x + offset.x, interpolation);
            position.z = Mathf.Lerp(this.transform.position.z, target1.transform.position.z + offset.z, interpolation);

            if (this.transform.position == target1.transform.position) reverse = !reverse;
        }
        this.transform.position = position;

    }*/

        timeLerped += Time.deltaTime;

        //bool change = false;

        if (!reverse)
        {
            transform.position = Vector3.Lerp(target1.transform.position, target2.transform.position, timeLerped / timeToLerp);

            if (this.transform.position == target2.transform.position)
            {
                reverse = !reverse;
                timeLerped = 0.0f;
            }

        }
        else if(reverse)
        {
            transform.position = Vector3.Lerp(target2.transform.position, target1.transform.position, timeLerped / timeToLerp);

            if (this.transform.position == target1.transform.position)
            {
                reverse = !reverse;
                timeLerped = 0.0f;
            }
        }
        //this.transform.position = position;

    }
}