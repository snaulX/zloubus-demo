﻿#pragma warning disable CS0618 
using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Networking.Match;
using UnityEngine.UI;

public class CreateOwnServer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Main").GetComponent<Main>().AddReference("CreateOwnServer", gameObject);
        GetComponent<Button>().onClick.AddListener(OnClick);
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnClick()
    {
        string externalip = new WebClient().DownloadString("http://icanhazip.com"); //thanks https://stackoverflow.com/questions/3253701/get-public-external-ip-address
        NetworkMaster nm = GameObject.Find("NetworkMaster").GetComponent<NetworkMaster>();
        nm.matchSize = (uint) GameObject.Find("NumberOfPersons").GetComponent<Slider>().value;
        nm.matchName = GameObject.Find("ServerName").GetComponent<InputField>().text;
        nm.networkAddress = externalip;
        nm.StartServer();
    }
}
