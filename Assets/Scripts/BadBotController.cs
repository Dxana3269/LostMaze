using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadBotController : MonoBehaviour
{
    private float speed;
    private Rigidbody enemyRb;
    private GameObject playerGoal;
    private int enemyCount = 1;

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        playerGoal = GameObject.Find("Player");
        enemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;
        speed = speed * (2 * enemyCount);

    }

    // Update is called once per frame
    void Update()
    {
        // Set enemy direction towards player goal and move there
        Vector3 lookDirection = (playerGoal.transform.position - transform.position).normalized;
        enemyRb.AddForce(lookDirection * speed * Time.deltaTime);

    }

    private void OnCollisionEnter(Collision other)
    {
        // If player collides with either goal, destroy it
        if (other.gameObject.name == "Ground")
        {
            //do nothing, save the ground
        }
        else if (other.gameObject.name == "Bad Bot")
        {
            Destroy(this.gameObject);
        }

    }

}

