﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Quit : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        GameObject.Find("Main").GetComponent<Main>().handler.AddReference("Quit", gameObject);
        gameObject.GetComponent<Button>().onClick.AddListener(() => Application.Quit());
    }

    // Update is called once per frame
    void Update()
    {

    }
}
