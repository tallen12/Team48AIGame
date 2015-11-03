using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerScript : MonoBehaviour {
    public GameServer server;
    public UnitScript units;
    public MapScript map;
    private int id = 0;
    private List<GameObject> adj;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

    }
    public List<UnitServer> getUnitList()
    {
        return server.getUnits(id);
    }
    private UnitBehavor currentClicked;
    public void unitClicked()
    {
        if (units.Clicked != currentClicked)
        {
            currentClicked = units.Clicked;
            foreach (GameObject a in adj)
            {
                a.GetComponent<SpriteRenderer>().GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 255);
                a.GetComponent<TerrainScript>().unit = null;
                a.GetComponent<TerrainScript>().GetComponent<TerrainScript>().check = false;
            }
        }
        if (units.Clicked != null)
        {
            Vector2 cord = map.convertWorldToMapCord(units.Clicked.transform.position);
            adj = map.getAdjacent(cord);
            foreach (GameObject a in adj)
            {
                a.GetComponent<SpriteRenderer>().color = new Color(255, 0, 0, 255);
                a.GetComponent<TerrainScript>().unit = units.Clicked;
                a.GetComponent<TerrainScript>().check = true;
            }
        }
    }
    public void terrainClick()
    {
        if (map.Clicked != null&&units.Clicked!=null)
        {
            foreach (GameObject a in adj)
            {
                if (a.GetComponent<TerrainScript>() == map.Clicked)
                {
                    units.Clicked.move((int)map.Clicked.x, (int)map.Clicked.y);
                }
            }
        }
    }
}
