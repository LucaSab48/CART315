using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class BreakoutBall_working : MonoBehaviour
{
    private Rigidbody2D rb;
    public float ballSpeed;
    public float maxSpeed = 10f;
    public float minSpeed = 2f;
    
    public AudioSource scoreSound, blip;
    public AudioSource collisionSound; 
    
    
    private int[] dirOptions = {-1, 1};
    private int   hDir;

    private bool gameRunning;
    
    public TrailRenderer trailRenderer;
    

    void Start() {
        rb = GetComponent<Rigidbody2D>();
        Reset(); 
    }
    
    void Update() {
        if (Input.GetKeyDown(KeyCode.Space) && !gameRunning) StartCoroutine(Launch());
    }



    private IEnumerator Launch() {
        gameRunning = true;
        hDir = dirOptions[Random.Range(0, dirOptions.Length)];
        rb.AddForce(transform.right * ballSpeed * hDir); 
        rb.AddForce(transform.up * -1f);
        
        yield return null;
    }

    public void Reset() {
        rb.linearVelocity = Vector2.zero;
        ballSpeed = 2;
        transform.position = new Vector2(0, 0);
        gameRunning = false;
        
    }
    

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (collisionSound != null)
        {
            collisionSound.pitch = Random.Range(0.8f, 1.2f);
            collisionSound.Play();
        }
        

        if (other.gameObject.tag == "Wall")
        {

            blip.pitch = 0.75f;
            blip.Play();
            SpeedCheck();
        }
        
        if (other.gameObject.tag == "Paddle")
        {

            blip.pitch = 1f;
            blip.Play();
            SpeedCheck();
        }
        
        if (other.gameObject.tag == "Reset")
        {
            Debug.Log("Hit Bottom");
            gameManagement.S.loseLife();
            Reset();
            
        }

        if (other.gameObject.tag == "Brick")
        {
            BrickValue brick = other.gameObject.GetComponent<BrickValue>();
            if (brick != null)
            {
                brick.TakeHit();
            }
        }

    }

    
    
    private void SpeedCheck() {
        
        // Prevent ball from going too fast
        if (Mathf.Abs(rb.linearVelocity.x) > maxSpeed) rb.linearVelocity = new Vector2(rb.linearVelocity.x * 0.99f, rb.linearVelocity.y);
        if (Mathf.Abs(rb.linearVelocity.y) > maxSpeed) rb.linearVelocity = new Vector2(rb.linearVelocity.x, rb.linearVelocity.y * 0.99f);

        if (Mathf.Abs(rb.linearVelocity.x) < minSpeed)
        {
            Debug.Log("too slow?");
            rb.linearVelocity = new Vector2(rb.linearVelocity.x * 1.1f, rb.linearVelocity.y);
        }

        if (Mathf.Abs(rb.linearVelocity.y) < minSpeed)
        {
            Debug.Log("too slow?");
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, rb.linearVelocity.y * 1.1f);
        }


        // Prevent too shallow of an angle
        if (Mathf.Abs(rb.linearVelocity.x) < minSpeed) {
            // shorthand to check for existing direction
            rb.linearVelocity = new Vector2((rb.linearVelocity.x < 0) ? -minSpeed : minSpeed, rb.linearVelocity.y);
        }

        if (Mathf.Abs(rb.linearVelocity.y) < minSpeed) {
            // shorthand to check for existing direction
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, (rb.linearVelocity.y < 0) ? -minSpeed : minSpeed);
        }
        
        Debug.Log(rb.linearVelocity);

    }


}
