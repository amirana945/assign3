using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {

    public float x;
    public float y;
    public float z;

    public int itemValue;

    GameController gameController;
	// Update is called once per frame
	void Update () {
        this.transform.Rotate(x, y, z);
	}

    void Start()
    {
        GameObject gameControllerObject = GameObject.FindGameObjectWithTag("GameController");
        gameController = gameControllerObject.GetComponent<GameController>();    
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gameController.ScoreValue += itemValue;
            Destroy(this.gameObject);
        }
    }

    void OnCollisionEnter()
    {
      
    }
}
