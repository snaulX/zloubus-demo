using UnityEngine;
using System.Collections;

public class Connect : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        objHandler.AddReference("Connect", gameObject);
        Debug.Log(string.Join(" ", objHandler.objRefs.Keys));
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
