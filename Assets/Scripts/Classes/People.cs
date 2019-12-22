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
    public Country home;
    public uint money;
    public sbyte mood;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public People(Estate estate, Country country)
    {
        money = country.taxes[estate] * 5;
        this.estate = estate;
        home = country;
        mood = 10;
    }
}
