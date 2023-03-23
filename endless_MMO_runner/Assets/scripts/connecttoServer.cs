using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class connecttoServer : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    
    public TMP_Text button_conn;
    public TMP_InputField username;
    public GameObject on_entry;
    public GameObject Loading;


    public void OnClickConnect()
    {
        if (username.text.Length >= 1)
        {
            PhotonNetwork.NickName = username.text;
            PhotonNetwork.ConnectUsingSettings();
            on_entry.SetActive(false);
            Loading.SetActive(true);

        }
    }


    public override void OnConnectedToMaster()
    {
        SceneManager.LoadScene("Create_join_menu");
    }
   
}
