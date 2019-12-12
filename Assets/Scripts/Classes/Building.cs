#pragma warning disable CS0618
using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class Building : NetworkBehaviour
{
    public People master;

    // Use this for initialization
    void Start()
    {

    }

    private void Update()
    {
#if UNITY_STANDALONE
        GUI.Label(new Rect(Input.mousePosition, new Vector2(100, 80)), Info());
#endif

#if UNITY_ANDROID
        Touch touch = Input.GetTouch(0);
        if (touch.phase == TouchPhase.Began)
        {
            GUI.Label(new Rect(transform.position, new Vector2(100, 80)), Info());
        }
#endif
    }

#if UNITY_STANDALONE
    private void OnMouseDown()
    {
        GameObject.Find("Player1").GetComponent<Player>().select = gameObject;
    }
#endif

    public virtual string Info()
    {
        string info = "Master is " + master.Name + ' ' + master.Surname + '\n';
        return info;
    }
}