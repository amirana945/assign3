using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {
    public AudioSource BulletSound;

   
    void FixedUpdate()
    {
        if (Input.GetButtonDown("Fire1"))
            {
         
            this.BulletSound.Play();
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        
        Destroy(gameObject);
    }
}
