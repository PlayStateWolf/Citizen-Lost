using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{

    public float speed;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(despawn(5));
        rb = GetComponent<Rigidbody>();
        rb.AddRelativeForce(0, 0, (-speed * 100) * Time.deltaTime);
    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }

    IEnumerator despawn(float time)
    {
        yield return new WaitForSeconds(time);
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }
}
