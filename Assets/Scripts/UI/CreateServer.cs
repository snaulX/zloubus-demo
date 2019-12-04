﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class CreateServer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        objHandler.AddReference("CreateServer", gameObject);
        gameObject.GetComponent<Button>().onClick.AddListener(OnClick);
    }

    private void OnClick()
    {
        objHandler.objRefs["Back"].SetActive(true);
        objHandler.objRefs["CreateOwnServer"].SetActive(true);
        objHandler.objRefs["ServerName"].SetActive(true);
        objHandler.objRefs["ServerDescription"].SetActive(true);

        foreach (GameObject obj in GameObject.FindGameObjectsWithTag("Main UI"))
        {
            obj.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //pass
    }
}
