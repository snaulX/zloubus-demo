using System;
using UnityEngine;
using System.Collections.Generic;

public class Castle : Building
{
    public List<People> garisson = new List<People>();
    public string Name;

    private void OnMouseEnter()
    {
        GUI.Label(new Rect(Input.mousePosition, new Vector2(100, 80)), Name);
    }
}