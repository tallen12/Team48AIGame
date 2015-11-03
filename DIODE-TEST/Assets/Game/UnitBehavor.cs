using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class UnitBehavor : MonoBehaviour {
    private MapScript map;
    private Terrain current;
    private bool click;
    public int id;
    public UnitScript player;
    private Vector2 currentPos;
    
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
            player.clicked(this);
            click = true;
        }
        else
        {
            player.clicked(null);
            click = false;
        }
    }
    public void move(float x,float y)
    {
        transform.position = map.convertMapToWorldCord((int)x, (int)y);
    }

}
