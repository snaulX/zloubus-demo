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
    
    public float music_volume;
    public bool fullscreen;
    // Start is called before the first frame update
    void Start()
    {
        using (BinaryReader reader = new BinaryReader(File.Open(Application.dataPath + "/settings.dat", FileMode.Open)))
        {
            music_volume = reader.ReadSingle();
            fullscreen = reader.ReadBoolean();
            reader.Close();
        }
        Screen.fullScreen = fullscreen;
        GetComponent<AudioSource>().volume = music_volume;
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        Screen.fullScreen = fullscreen;
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
