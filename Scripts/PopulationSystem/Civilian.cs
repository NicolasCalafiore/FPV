using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static CharacterUtils;


public class Civilian : ICharacter
{
    public string Name { get; set; } = "Civilian";
    public int Age { get; set; } = 18;
    public int Health { get; set; } = 100;
    public CharacterType Type { get; set; } = CharacterType.Civilian;
    
    public Civilian() {
        Debug.Log("Civilian created"); 
    }

    public void MoveTo(POI position)
    {
        
    }

}

