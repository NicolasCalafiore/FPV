using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static CharacterUtils;

public interface ICharacter
{

    public string Name { get; set; }
    public int Age { get; set; }
    public int Health { get; set; }
    public CharacterType Type { get; set; }
}
