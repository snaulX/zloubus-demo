using System;
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
        foreach (GameObject obj in GameObject.FindGameObjectsWithTag("Main UI"))
        {
            obj.SetActive(false);
        }

        objHandler.objRefs["Back"].SetActive(true);
        objHandler.objRefs["CreateOwnServer"].SetActive(true);
        objHandler.objRefs["ServerName"].SetActive(true);
        objHandler.objRefs["ServerDescription"].SetActive(true);
        objHandler.objRefs["NumbText"].SetActive(true);
        objHandler.objRefs["NumberOfPersons"].SetActive(true);
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
