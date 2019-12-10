using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Main : MonoBehaviour
{
    [SerializeField]
    public Texture2D cursor_icon;
    public float music_volume;
    public objHandler handler;
    // Start is called before the first frame update
    void Start()
    {
        handler = new objHandler();
        Cursor.SetCursor(cursor_icon, new Vector2(), CursorMode.ForceSoftware);
        using (BinaryReader reader = new BinaryReader(File.Open(@"settings.dat", FileMode.Open)))
        {
            music_volume = reader.ReadSingle();
            reader.Close();
        }
        GetComponent<AudioSource>().volume = music_volume;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<AudioSource>().volume = music_volume;
    }
}

public class objHandler
{
    public Dictionary<string, GameObject> objRefs = new Dictionary<string, GameObject>();

    public void AddReference(string name, GameObject obj)
    {
        if (!objRefs.ContainsKey(name))
            objRefs.Add(name, obj);
    }
}
