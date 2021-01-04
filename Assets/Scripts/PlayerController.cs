using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 50;
    public Rigidbody rb;
    private int score = 0;
    public int health = 5;

    void Update()
    {
        if (health == 0)
        {
            Debug.Log("Game Over!");
            SceneManager.LoadScene("maze");
        }
    }
    void FixedUpdate()
    {
        float XInput = Input.GetAxis("Horizontal");
        float ZInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3 (XInput, 0.0f, ZInput);
        
        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Pickup")
        {
            score += 1;
            Debug.Log($"Score: {score}");
            other.gameObject.SetActive(false);
        }

        if (other.tag == "Trap")
        {
            health -= 1;
            Debug.Log($"Health: {health}");
        }

        if (other.tag == "Goal")
        {
            Debug.Log("You win!");
        }
    }
}
