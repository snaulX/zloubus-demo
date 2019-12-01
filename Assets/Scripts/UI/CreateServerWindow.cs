using UnityEngine;
using System.Collections;

public class CreateServerWindow : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        objHandler.AddReference("CreateServerWindow", gameObject);
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
