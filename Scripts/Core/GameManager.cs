using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PopulationManager.CreateCivilians(2);
        POIManager.GeneratePOIGrid();

        GraphicsManager.SpawnCivilians(PopulationManager.population);
        GraphicsManager.SpawnPOIs(POIManager.POIs);
        //StartCoroutine(GraphicsManager.MoveAtoB(PopulationManager.population[0], POIManager.POIs[83], 5));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
