using UnityEngine;
using System.Collections;

public class Back : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        objHandler.AddReference("Back", gameObject);
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
