#pragma warning disable CS0618 
using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class Player : NetworkBehaviour
{
    public enum CursorMode
    {
        DEFAULT,
        MIGHT
    }

    public Country country
    {
        get => GetComponent<Country>();
    }
    public GameObject select;
    [SerializeField]
    public Texture2D cursor_might, cursor_default;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
#if UNITY_STANDALONE
        bool select_knight = select.GetComponent<KnightSquad>() != null;
        if (Input.GetMouseButtonDown(0))
        {
            if (select_knight) select.GetComponent<KnightSquad>().Move(Input.mousePosition);
        }
        if (Input.GetAxis("Horizontal") > 0) GetComponentInChildren<Camera>().transform.Translate(0.2f, 0, 0);
        else if (Input.GetAxis("Horizontal") < 0) GetComponentInChildren<Camera>().transform.Translate(-0.2f, 0, 0);
        if (Input.GetAxis("Vertical") > 0) GetComponentInChildren<Camera>().transform.Translate(0, 0.2f, 0);
        else if (Input.GetAxis("Vertical") < 0) GetComponentInChildren<Camera>().transform.Translate(0, -0.2f, 0);
        if (select_knight) ChangeCursor(CursorMode.MIGHT);
        else ChangeCursor(CursorMode.DEFAULT);
#elif UNITY_ANDROID
        Touch touch = Input.GetTouch(0);
        if (touch.phase == TouchPhase.Moved)
        {
            GetComponentInChildren<Camera>().transform.Translate(touch.deltaPosition * Time.deltaTime);
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

    public void ChangeCursor(CursorMode mode)
    {
        if (mode == CursorMode.MIGHT) Cursor.SetCursor(cursor_might, new Vector2(), UnityEngine.CursorMode.Auto);
        else if (mode == CursorMode.DEFAULT) Cursor.SetCursor(cursor_might, new Vector2(), UnityEngine.CursorMode.Auto);
    }
}
