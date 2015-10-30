using UnityEngine;
using System.Collections;

public class MapScript : MonoBehaviour {
    public int Size
    {
        get { return 31; }
    }
    private GameObject[,] mapSquare;
    public GameObject this[int index1,int index2]
    {
        get { return mapSquare[index1, index2];}
    }
    // Use this for initialization
    void Start () {
        mapSquare=new GameObject[31,31];
        for(int x = 0; x < Size; x++)
        {
            for(int y = 0; y < Size; y++)
            {
                GameObject go = GameObject.Instantiate(Resources.Load("Terrain")) as GameObject;
                go.transform.position = new Vector3((x-(Size - 1)/2)*1.28f, (y - (Size - 1) / 2) * 1.28f, 0);
                go.transform.parent = gameObject.transform;
                mapSquare[x, y] = go;
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
