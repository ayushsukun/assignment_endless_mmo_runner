using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class player_movement : MonoBehaviour
{
    public float speed ;
    private Rigidbody player;
    Vector3 lastpos;

    PhotonView view;

    // Start is called before the first frame update
    void Start()
    {
        player=gameObject.GetComponent<Rigidbody>();
        view = GetComponent<PhotonView>();
    }

    // Update is called once per frame
    void Update()
    {
        if (view.IsMine)
        {
        lastpos = player.transform.position;
                if (Input.GetKeyDown(KeyCode.Return) )
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
}
