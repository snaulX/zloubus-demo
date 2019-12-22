#pragma warning disable CS0618
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.Networking;

public class Town : NetworkBehaviour
{
    public string Name;
    public Country country;
    public List<Building> buildings;
    public List<People> peoples;
    public uint money;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
