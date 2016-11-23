using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour
{
    GameController gameController;
    public int itemValue;

    // Use this for initialization
    void Start()
    {
        GameObject gameControllerObject = GameObject.FindGameObjectWithTag("GameController");
        gameController = gameControllerObject.GetComponent<GameController>();

    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            gameController.ScoreValue += itemValue;
            Destroy(this.gameObject);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gameController.LivesValue -= itemValue;
            Destroy(other.gameObject);
        }

        // Update is called once per frame

    }
}
