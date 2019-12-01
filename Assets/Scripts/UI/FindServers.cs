using UnityEngine;
using System.Collections;
using UnityEngine.UI;

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
        objHandler.objRefs["Connect"].SetActive(true);

        foreach (GameObject obj in GameObject.FindGameObjectsWithTag("Main UI"))
        {
            obj.SetActive(false);
        }
    }
}
