#pragma warning disable CS0618
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.Networking;

public class Town : NetworkBehaviour
{
    public string Name;
    public Country country;
    public List<Building> buildings = new List<Building>();
    public List<People> peoples = new List<People>();
    public int money;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
