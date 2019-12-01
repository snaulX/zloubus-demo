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

public static class objHandler
{
    public static Dictionary<string, GameObject> objRefs = new Dictionary<string, GameObject>();

    public static void AddReference(string name, GameObject obj)
    {
        if (!objRefs.ContainsKey(name))
            objRefs.Add(name, obj);
    }
}
