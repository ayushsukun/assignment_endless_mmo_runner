using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;

public class attckscript : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="Player")
        {
            Debug.Log("it hit");
            Destroy(collision.gameObject);
            PhotonNetwork.LeaveLobby();
            SceneManager.LoadScene("first");

        }
    }

}
