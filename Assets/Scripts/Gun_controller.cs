using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun_controller : MonoBehaviour
{
    public Transform barrel;
    public GameObject bullet_prefab;
    public List<GameObject> active_bullets;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject bullet = Instantiate(bullet_prefab);
            active_bullets.Add(bullet);
            bullet.transform.position = barrel.position;

            bullet.transform.parent = barrel;
            bullet.transform.localRotation = Quaternion.identity;

            bullet.transform.parent = null;
        }
    }
}
