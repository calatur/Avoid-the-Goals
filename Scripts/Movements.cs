using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class Movements : MonoBehaviour
{
    public float speed;
    public Rigidbody ball;
    public int score;
    public Text point;

    void Start()
    {
        score = 0;
    }

    void Update()
    {
        roll();
        Camera.main.transform.position = new Vector3(transform.position.x - 35,
            11f, transform.position.z);
        
    }
    void roll()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            ball.AddForce(Vector3.right * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) 
        {
            ball.AddForce(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            ball.AddForce(Vector3.back * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            ball.AddForce(Vector3.forward * speed * Time.deltaTime);
        }
    }

    
        void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == "Consumable")
            {
                collision.gameObject.SetActive(false);
                 count.instance.increase();
            }

            if (collision.gameObject.tag == "Finish")
            {
                SceneManager.LoadScene("Finish");
            }
            if (collision.gameObject.tag == "Goal")
            {
                Destroy(ball);
                SceneManager.LoadScene("Death");
            }

            
        }
    
}
