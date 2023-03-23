using System.Collections;
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

    private void Start()
    {
        PhotonNetwork.JoinLobby();
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

       
        foreach (Player p in PhotonNetwork.PlayerList)
        {

           TMP_Text nick = Instantiate(prefabname, content);
            nick.text = p.NickName;
        }
    

}


    public void OnClickJoin()
    {
        PhotonNetwork.JoinRoom(Join_room_name.text);
        after_connection.SetActive(false);
        lobby.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
