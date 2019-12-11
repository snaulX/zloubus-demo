using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class FindServers : MonoBehaviour
{
    Main handler
    {
        get => GameObject.Find("Main").GetComponent<Main>();
    }
    // Use this for initialization
    void Start()
    {
        handler.AddReference("FindServers", gameObject);
        gameObject.GetComponent<Button>().onClick.AddListener(OnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnClick()
    {
        handler.objRefs["ServersList"].SetActive(true);
        handler.objRefs["Back"].SetActive(true);
        GameObject.Find("Name").GetComponent<Text>().text = "Find Servers";
        try
        {
            handler.objRefs["Connect"].SetActive(true);
        }
        catch (KeyNotFoundException)
        {
            Debug.Log(string.Join(" ", handler.objRefs.Keys));
        }

        foreach (GameObject obj in GameObject.FindGameObjectsWithTag("Main UI"))
        {
            obj.SetActive(false);
        }
    }
}
