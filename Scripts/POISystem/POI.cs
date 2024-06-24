using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class POI 
{
    public string Name { get; set; }
    public Vector3 Position { get; set; }

    public POI(string name) {
        Name = name;
    }

    public void SetPosition(Vector3 position) {
        Position = position;
    }
}
