using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class POIManager
{
    // Start is called before the first frame update
    public static List<POI> POIs = new List<POI>();
    public static void GeneratePOIGrid()
    {
        for(int i = 0; i <= 10; i++){
            for(int j = 0; j <= 10; j++){
                POI poi = new POI("POI");
                POIs.Add(poi);
                poi.SetPosition(new Vector3(i*5, 0, j*5));
            }
        }
    }
}
