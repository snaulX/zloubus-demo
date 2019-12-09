#pragma warning disable CS0618 
using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
using System;

public enum Estate : byte
{
    PEASANT,
    ARTISAN,
    WARRIOR,
    KNIGHT,
    HORSE_KNIGHT,
    CATAPULT,
    NOBLEMAN,
    FEODAL,
    COMMANDER,
    KING
}

public class People : NetworkBehaviour
{
    public string Name, Surname;
    public DateTime age;
    public Estate estate;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
