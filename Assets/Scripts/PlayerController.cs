using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    // Rigidbody of player
    private Rigidbody rb;

    // Movement in x and y
    private float movementX;
    private float movementY;

    // Speed
    public float speed = 0;

    // WinText
    public GameObject winTextObject;

    public GameObject player;

    public GameObject loseTextObject;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        winTextObject.SetActive(false);
        loseTextObject.SetActive(false);
    }

    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    private void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);

        rb.AddForce(movement * speed);
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Water")
        {
            winTextObject.SetActive(true);
            Invoke("LoadNextScene", 3f);
        }

        if (col.gameObject.name == "Obstacle 1")
        {
            loseTextObject.SetActive(true);
            player.SetActive(false);
        }

        if (col.gameObject.name == "Obstacle 2")
        {
            loseTextObject.SetActive(true);
            player.SetActive(false);
        }

        if (col.gameObject.name == "Obstacle 3")
        {
            loseTextObject.SetActive(true);
            player.SetActive(false);
        }

        if (col.gameObject.name == "Obstacle 4")
        {
            loseTextObject.SetActive(true);
            player.SetActive(false);
        }

        if (col.gameObject.name == "Obstacle 5")
        {
            loseTextObject.SetActive(true);
            player.SetActive(false);
        }
    }

    private void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}