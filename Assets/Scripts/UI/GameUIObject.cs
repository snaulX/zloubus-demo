using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUIObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Main").GetComponent<Main>().handler.AddReference(gameObject.name, gameObject);
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
