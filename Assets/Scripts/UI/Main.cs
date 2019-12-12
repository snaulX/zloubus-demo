using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Main : MonoBehaviour
{
    public Dictionary<string, GameObject> objRefs = new Dictionary<string, GameObject>();

    public void AddReference(string name, GameObject obj)
    {
        if (!objRefs.ContainsKey(name))
            objRefs.Add(name, obj);
    }

    [SerializeField]
    public Texture2D cursor_icon;
    public float music_volume;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.SetCursor(cursor_icon, new Vector2(), CursorMode.ForceSoftware);
        using (BinaryReader reader = new BinaryReader(File.Open(Application.dataPath + "/settings.dat", FileMode.Open)))
        {
            music_volume = reader.ReadSingle();
            reader.Close();
        }
        GetComponent<AudioSource>().volume = music_volume;
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<AudioSource>().volume = music_volume;
    }

    private void Awake()
    {
#if UNITY_ANDROID
        Screen.autorotateToLandscapeRight = true;
#elif UNITY_STANDALONE
        //pass
#endif
    }
}
