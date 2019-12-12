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
    public GameObject select;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
#if UNITY_STANDALONE
        if (Input.GetAxis("Horizontal") > 0) GetComponentInChildren<Camera>().transform.Translate(0.2f, 0, 0);
        else if (Input.GetAxis("Horizontal") < 0) GetComponentInChildren<Camera>().transform.Translate(-0.2f, 0, 0);
        if (Input.GetAxis("Vertical") > 0) GetComponentInChildren<Camera>().transform.Translate(0, 0.2f, 0);
        else if (Input.GetAxis("Vertical") < 0) GetComponentInChildren<Camera>().transform.Translate(0, -0.2f, 0);
#elif UNITY_ANDROID
        Touch touch = Input.GetTouch(0);
        if (touch.phase == TouchPhase.Moved)
        {
            GetComponentInChildren<Camera>().transform.Translate(touch.deltaPosition);
        }
#endif
    }

    private void OnGUI()
    {

#if UNITY_STANDALONE
        GUILayout.Label("Press WASD or Arrows " + Input.GetAxis("Horizontal") + " " + Input.GetAxis("Vertical"));
        GUILayout.Box(select.name);
#elif UNITY_ANDROID
        GUILayout.Label("Move map " + Camera.main.transform.position);
#endif
    }
}
