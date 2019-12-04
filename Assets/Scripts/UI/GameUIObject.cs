using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUIObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        objHandler.AddReference(gameObject.name, gameObject);
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
