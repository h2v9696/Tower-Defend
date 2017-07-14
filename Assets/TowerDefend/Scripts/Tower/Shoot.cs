using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
    [SerializeField]
    GameObject bullet;
    [SerializeField]
    float force;
    [SerializeField]
    float fireRate = 0.2f;
    float nextFire;
    [SerializeField]
    Transform firePos;
    [SerializeField]
    LayerMask layerHit;
    private RaycastHit hit;
    private Vector3 direction;

    void Update () {
//        FireBullet ();
    }

    public void FireBullet()
    {
//        if (Input.GetButton ("Fire1") && Time.time > nextFire)
        if (Time.time > nextFire)
        {

            GameObject go = (GameObject)Instantiate (bullet, firePos.position, transform.rotation);
//            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 rayOrigin = Camera.main.ViewportToWorldPoint (new Vector3 (.5f, .5f, 0));
//            Debug.DrawRay(ray.origin, ray.direction * 10, Color.green);
//            Physics.Raycast (ray.origin, ray.direction, out hit, layerHit);
            if (Physics.Raycast (rayOrigin, Camera.main.transform.forward, out hit, 1000, layerHit))
            {
                direction = (hit.point - firePos.position).normalized;
                Debug.Log (hit.point);
                go.GetComponent<Rigidbody> ().AddForce (direction * force, ForceMode.Impulse);
            }
            nextFire = Time.time + fireRate;
        }

    }

}
