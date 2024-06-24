using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PopulationManager
{
    // Start is called before the first frame update
    [SerializeField] static private GameObject civilianPrefab;
    public static List<ICharacter> population = new List<ICharacter>();

    public static void CreateCivilians(int amount)
    {
        for(int i = 0; i < amount; i++){
            population.Add(new Civilian());
        }
        
    }
}
