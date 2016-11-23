using UnityEngine;
using System.Collections;

public class playerFire : MonoBehaviour {

    public GameObject bulletPrefab;
    public Transform bulletSpawn;


	void Update () {
        if (Input.GetMouseButtonDown(0))
        {//Creating bullet
            var bullet = (GameObject)Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
            //Velocity adding to the bulletes
            bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 6;
            //Destroying bullets after 2 seconds
            Destroy(bullet, 2.0f);
        }
           
	}

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
        }
    }

   
}
