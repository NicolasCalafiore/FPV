using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GraphicsManager
{
    [SerializeField] private static GameObject civilianPrefab;
    public static Dictionary<ICharacter, GameObject> characterGraphics = new Dictionary<ICharacter, GameObject>();
    public static Dictionary<POI, GameObject> poiGraphics = new Dictionary<POI, GameObject>();

    public static void SpawnCivilians(List<ICharacter> civilians)
    {
        civilianPrefab = Resources.Load<GameObject>("Prefabs/Character");
        foreach (Civilian civilian in civilians)
        {
            GameObject civilianGO = GameObject.Instantiate(civilianPrefab);
            civilianGO.transform.position = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
            characterGraphics.Add(civilian, civilianGO);
        }
    }

    public static void SpawnPOIs(List<POI> pois)
    {
        GameObject poi_go = Resources.Load<GameObject>("Prefabs/POI");
        foreach (POI poi in pois)
        {
            GameObject poiGO = GameObject.Instantiate(poi_go);
            poiGO.transform.position = poi.Position;
            poiGraphics.Add(poi, poiGO);
        }
    }

    public static IEnumerator MoveAtoB(ICharacter character, POI poi, float speed)
    {
        GameObject characterGO = characterGraphics[character];
        GameObject poiGO = poiGraphics[poi];
        while (characterGO.transform.position != poiGO.transform.position)
        {
            characterGO.transform.position = Vector3.MoveTowards(characterGO.transform.position, poiGO.transform.position, speed * Time.deltaTime);
            yield return null;
        }
    }
        
}
