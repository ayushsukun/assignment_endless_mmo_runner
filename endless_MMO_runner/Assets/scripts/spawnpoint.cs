﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class spawnpoint : MonoBehaviour
{
    public GameObject playerPrefab;

    public float minX;
    public float maxX;
    public float minY;
    public float maxY;
    public float minZ;
    public float maxZ;
    // Start is called before the first frame update
    private void Start()
    {
        Vector3 randomPosition = new Vector3(Random.Range(minX,maxX), Random.Range(minY, maxY), Random.Range(minZ, maxZ));
        PhotonNetwork.Instantiate(playerPrefab.name, randomPosition, Quaternion.identity);
        Debug.Log(randomPosition);
    }

    // Update is called once per frame
   
}
