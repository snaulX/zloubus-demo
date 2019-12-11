#pragma warning disable CS0618 
using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class Player : NetworkBehaviour
{
    public Country country
    {
        get => GetComponent<Country>();
    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") > 0) GetComponentInChildren<Camera>().transform.Translate(0.2f, 0, 0);
        else if (Input.GetAxis("Horizontal") < 0) GetComponentInChildren<Camera>().transform.Translate(-0.2f, 0, 0);
        if (Input.GetAxis("Vertical") > 0) GetComponentInChildren<Camera>().transform.Translate(0, 0.2f, 0);
        else if (Input.GetAxis("Vertical") < 0) GetComponentInChildren<Camera>().transform.Translate(0, -0.2f, 0);
    }

    private void OnGUI()
    {
        GUILayout.Label("Press WASD or Arrows " + Input.GetAxis("Horizontal") + " " + Input.GetAxis("Vertical"));
    }
}
