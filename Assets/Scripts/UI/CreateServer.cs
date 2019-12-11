using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class CreateServer : MonoBehaviour
{
    Main handler
    {
        get => GameObject.Find("Main").GetComponent<Main>();
    }
    // Start is called before the first frame update
    void Start()
    {
        handler.AddReference("CreateServer", gameObject);
        gameObject.GetComponent<Button>().onClick.AddListener(OnClick);
    }

    private void OnClick()
    {
        foreach (GameObject obj in GameObject.FindGameObjectsWithTag("Main UI"))
        {
            obj.SetActive(false);
        }
        
        handler.objRefs["Back"].SetActive(true);
        handler.objRefs["CreateOwnServer"].SetActive(true);
        handler.objRefs["ServerName"].SetActive(true);
        handler.objRefs["ServerDescription"].SetActive(true);
        handler.objRefs["NumbText"].SetActive(true);
        handler.objRefs["NumberOfPersons"].SetActive(true);
        GameObject.Find("NumberOfPersons").GetComponent<Slider>().maxValue = 30;
        GameObject.Find("NumberOfPersons").GetComponent<Slider>().minValue = 1;
        GameObject.Find("NumbText").GetComponent<Text>().text = "Number of persons on server:";
        GameObject.Find("Name").GetComponent<Text>().text = "Create Own Server";
    }

    // Update is called once per frame
    void Update()
    {
        //pass
    }
}
