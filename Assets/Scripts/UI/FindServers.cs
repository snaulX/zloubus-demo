using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class FindServers : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        objHandler.AddReference("FindServers", gameObject);
        gameObject.GetComponent<Button>().onClick.AddListener(OnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnClick()
    {
        objHandler.objRefs["ServersList"].SetActive(true);
        objHandler.objRefs["Back"].SetActive(true);
        try
        {
            objHandler.objRefs["Connect"].SetActive(true);
        }
        catch (KeyNotFoundException e)
        {
            Debug.Log(string.Join(" ", objHandler.objRefs.Keys));
        }

        foreach (GameObject obj in GameObject.FindGameObjectsWithTag("Main UI"))
        {
            obj.SetActive(false);
        }
    }
}
