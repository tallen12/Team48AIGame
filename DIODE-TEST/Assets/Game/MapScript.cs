using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;
public class MapScript : MonoBehaviour {
    public int Size
    {
        get { return 31; }
    }
    private float scale=1.28f;

    private GameObject[,] mapSquare;
    public GameObject this[int index1,int index2]
    {
        get { return mapSquare[index1, index2];}
    }
    // Use this for initialization
    void Start () {
        mapSquare=new GameObject[31,31];

        for (int x = 0; x < Size; x++)
        {
            for(int y = 0; y < Size; y++)
            {
                GameObject go = GameObject.Instantiate(Resources.Load("Terrain")) as GameObject;
                TerrainScript script = go.GetComponent<TerrainScript>();
                script.init(x,y);
                go.transform.position = new Vector3((x-(Size - 1)/2)*scale, (y - (Size - 1) / 2) * scale, 1);
                go.transform.parent = gameObject.transform;
                mapSquare[x, y] = go;
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public Vector3 convertMapToWorldCord(int x,int y)
    {
        return new Vector3((x - (Size - 1) / 2) * 1.28f, (y - (Size - 1) / 2) * 1.28f, 0);
    }
    public Vector2 convertWorldToMapCord(Vector3 input)
    {
        float x = (float)Math.Round(input.x / scale + ((Size - 1) / 2));
        float y = (float)Math.Round(input.y / scale + ((Size - 1) / 2));
        return new Vector2(x,y);
    }
    public List<GameObject> getAdjacent(Vector2 pos)
    {
        List<GameObject> output = new List<GameObject>();
        for (int x = -1; x <= 1; x++)
        {
            for (int y = -1; y <= 1; y++)
            {
                if (!(x == 0 && y == 0))
                {
                    int inx = x + (int)pos.x;
                    int iny =y + (int)pos.y;
                    if ((inx < Size && inx >= 0) && (iny < Size && iny >= 0))
                        output.Add(this[inx, iny]);
                }
            }
        }
        return output;
    }
}
