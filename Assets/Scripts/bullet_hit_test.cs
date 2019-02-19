using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_hit_test : MonoBehaviour
{
    public MeshRenderer rend;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision hit)
    {
        if (hit.gameObject.tag == "bullet")
        {
            rend.material.SetColor("_Color", new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f)));
        }
    }
}
