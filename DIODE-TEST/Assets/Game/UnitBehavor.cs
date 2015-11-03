using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class UnitBehavor : MonoBehaviour {
    private MapScript map;
    private Terrain current;
    private bool click;
    private Vector2 currentPos;
    private List<GameObject> adj;
    // Use this for initialization
    void Start () {
        map= GameObject.Find("Map").GetComponent<MapScript>();
        click = false;
    }
	
	// Update is called once per frame
	void Update () {
    }
    void OnMouseDown()
    {
        if (!click)
        {
            currentPos = map.convertWorldToMapCord(this.transform.position);
            adj = map.getAdjacent(currentPos);
            click = true;
            foreach(GameObject a in adj)
            {
                a.GetComponent<SpriteRenderer>().color = new Color(255, 0, 0, 255);
                a.GetComponent<TerrainScript>().unit = this;
                a.GetComponent<TerrainScript>().check = true;
            }
        }
        else
        {
            foreach (GameObject a in adj)
            {
                a.GetComponent<SpriteRenderer>().GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 255);
                a.GetComponent<TerrainScript>().unit = null;
                a.GetComponent<TerrainScript>().GetComponent<TerrainScript>().check = false;
            }
            click = false;
        }
    }
    public void move(float x,float y)
    {
        transform.position = new Vector2(x, y);
    }
}
