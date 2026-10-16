using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemyMovement : MonoBehaviour
{
    private float timer = 0f;
    public float speed = 5f;
    public Vector3 direction = Vector3.forward;
    public GameOver gameOverCanvas;

    private void Start()
    {
        gameOverCanvas = FindObjectOfType<GameOver>();
    }
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 8)
        {
            Destroy(gameObject);
        }

        transform.Translate(direction.normalized * speed * Time.deltaTime);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            gameOverCanvas.ShowGameOver();
        }
    }
    
}
