using System;
using Unity.VisualScripting;
using UnityEngine;

public class shotScript : MonoBehaviour
{
    public int score = 0;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            //score point
            score++;
            //destroy enemy
            Destroy(other.gameObject);
            //destroy self
            Destroy(this.gameObject);
        }
    }
}
