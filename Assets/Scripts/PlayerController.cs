using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float goStraight;
    public float goSide;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //move the vechicle forward
        goStraight = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * 2 * goStraight);
        goSide = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * 2 * goSide);
    }
}
