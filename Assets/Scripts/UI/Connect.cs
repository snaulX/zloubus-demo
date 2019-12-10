using UnityEngine;
using System.Collections;

public class Connect : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        GameObject.Find("Main").GetComponent<Main>().handler.AddReference("Connect", gameObject);
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
