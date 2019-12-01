using UnityEngine;
using System.Collections;

public class ServersList : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        objHandler.AddReference("ServersList", gameObject);
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
