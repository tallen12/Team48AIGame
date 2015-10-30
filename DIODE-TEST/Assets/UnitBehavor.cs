using UnityEngine;
using System.Collections;

public class UnitBehavor : MonoBehaviour {
    private MapScript map;
    private bool click;
    // Use this for initialization
    void Start () {
        map= GameObject.Find("Map").GetComponent<MapScript>();
        click = false;
    }
	
	// Update is called once per frame
	void Update () {
        map[map.Size / 2, map.Size / 2].GetComponent<BoxCollider2D>().enabled = false;
    }
    void OnMouseDown()
    {
        if (!click)
        {
            click = true;
            for (int x = -1; x <= 1; x++)
            {
                for (int y = -1; y <= 1; y++)
                {
                    if (!(x == 0 && y == 0))
                    {
                        map[x + map.Size / 2, y + map.Size / 2].GetComponent<SpriteRenderer>().color = new Color(255, 0, 0, 255);
                        map[x + map.Size / 2, y + map.Size / 2].GetComponent<TerrainScript>().unit = this;
                        map[x + map.Size / 2, y + map.Size / 2].GetComponent<TerrainScript>().check = true;
                    }
                }
            }
        }
        else
        {
            click = false;
            for (int x = -1; x <= 1; x++)
            {
                for (int y = -1; y <= 1; y++)
                {
                    map[x + map.Size / 2, y + map.Size / 2].GetComponent<SpriteRenderer>().color = new Color(255, 255,255, 255);
                    map[x + map.Size / 2, y + map.Size / 2].GetComponent<TerrainScript>().check = false;
                }
            }

        }
    }
    public void move(float x,float y)
    {
        transform.position = new Vector2(x, y);
    }
}
