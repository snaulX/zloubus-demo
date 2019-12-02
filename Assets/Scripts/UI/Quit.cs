using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Quit : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        objHandler.AddReference("Quit", gameObject);
        gameObject.GetComponent<Button>().onClick.AddListener(() => Application.Quit());
    }

    // Update is called once per frame
    void Update()
    {

    }
}
