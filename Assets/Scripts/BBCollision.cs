using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BBCollision : MonoBehaviour
{

        void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.tag == "Enemy")
            {
                Destroy(this.gameObject);
                //lives will be decreased when bad bot collides with player
            }
        }
}
