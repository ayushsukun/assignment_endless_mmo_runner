﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class lobbymanager : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update

    public TMP_InputField Create_room_name;
    public TMP_InputField Join_room_name;
    public GameObject after_connection;
    public GameObject lobby;
    public TMP_Text room_name;
    public Transform content;
    public TMP_Text prefabname;
    public GameObject start_btn;
    public GameObject error_m;

    List<TMP_Text> prefablist = new List<TMP_Text>(); 

   

    private void Start()
    {
        PhotonNetwork.JoinLobby();
        PhotonNetwork.AutomaticallySyncScene = true;
    }


    public void OnClickCreate()
    {
        if (Create_room_name.text.Length >= 1)
        {
            PhotonNetwork.CreateRoom(Create_room_name.text);
            after_connection.SetActive(false);
            lobby.SetActive(true);
            start_btn.SetActive(true);
           // room_name.text = "Room Name: " + PhotonNetwork.CurrentRoom.Name;

        }
    }


    public override void OnJoinedRoom()
    {
        after_connection.SetActive(false);
        lobby.SetActive(true);
        room_name.text = "Room Name: " + PhotonNetwork.CurrentRoom.Name;

        if (error_m.active == true)
        {
            error_m.SetActive(false);
        }

        Debug.Log(PhotonNetwork.PlayerList.Length);

        UpdateplayerList();
    

}

    void UpdateplayerList()
    {
        foreach( TMP_Text j in prefablist)
        {
            Destroy(j.gameObject);
        }
        prefablist.Clear();

        foreach (Player p in PhotonNetwork.PlayerList)
        {

            TMP_Text nick = Instantiate(prefabname, content);
            nick.text = p.NickName;
            prefablist.Add(nick);
        }

    }

    public void OnClickJoin()
    {
      
       PhotonNetwork.JoinRoom(Join_room_name.text);
        
        //after_connection.SetActive(false);
        //lobby.SetActive(true);
    }

    public override void OnJoinRoomFailed(short returnCode, string message)
    {
        error_m.SetActive(true);
    }

    public void OnClickLeave_Room()
    {
        PhotonNetwork.LeaveRoom();
    }
    
    public void OnClickStart_button()
    {
        PhotonNetwork.LoadLevel("game");
        //SceneManager.LoadScene("game");
    }

    public override void OnPlayerEnteredRoom(Player newPlayer)
    {
        UpdateplayerList();
    }
    public override void OnPlayerLeftRoom(Player otherPlayer)
    {
      
     UpdateplayerList();
       
    }

    public override void OnLeftRoom()
    {
        if (start_btn.active==true)
        {
            start_btn.SetActive(false);
        }
        lobby.SetActive(false);
        after_connection.SetActive(true);
    }
     
   

    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby();
    }
    // Update is called once per frame
   
}
