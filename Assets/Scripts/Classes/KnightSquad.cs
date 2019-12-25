#pragma warning disable CS0618 
using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
using System.Collections.Generic;

public class KnightSquad : NetworkBehaviour
{
    public People commander;
    public List<People> knights, horse_knights, warriors, catapults;

    public Country home
    {
        get => commander.home;
    }
    // Use this for initialization
    void Start()
    {
        commander = GetComponent<People>();
        for (int i = 0; i < knights.Count; i++)
        {
            knights[i] = new People(Estate.KNIGHT, home);
        }
        for (int i = 0; i < horse_knights.Count; i++)
        {
            horse_knights[i] = new People(Estate.HORSE_KNIGHT, home);
        }
        for (int i = 0; i < warriors.Count; i++)
        {
            warriors[i] = new People(Estate.WARRIOR, home);
        }
        for (int i = 0; i < catapults.Count; i++)
        {
            catapults[i] = new People(Estate.CATAPULT, home);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

#if UNITY_STANDALONE
    private void OnMouseDown()
    {
        GameObject select = GameObject.Find("Player1").GetComponent<Player>().select;
        if (select != gameObject) select = gameObject;
        else select = null;
    }
#endif

    public void Move(Vector2 toPosition)
    {
        //pass
    }
}
