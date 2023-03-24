using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    public float speed = 1000f;
    private Rigidbody player;
    Vector3 lastpos;

    // Start is called before the first frame update
    void Start()
    {
        player=gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        lastpos = player.transform.position;
        if (Input.GetKeyDown(KeyCode.Space) )
        {
            if (player.velocity== Vector3.zero)
            {
                player.velocity = Vector3.left * speed * Time.deltaTime;
               // player.AddForce(Vector3.left * speed * Time.deltaTime);
            }

            else if (player.velocity != Vector3.zero)
            {
                player.velocity = Vector3.left * 0 * Time.deltaTime;
               // player.AddForce(Vector3.right * speed * Time.deltaTime);
            }

        }
        
       
     
    }
}
