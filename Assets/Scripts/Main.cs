using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    [SerializeField]
    public Texture2D cursor_icon;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.SetCursor(cursor_icon, new Vector2(), CursorMode.ForceSoftware);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
