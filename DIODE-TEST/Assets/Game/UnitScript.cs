using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UnitScript : MonoBehaviour {
    GameObject[] units;
    MapScript map;
    private int Size=1;
    // Use this for initialization
    void Start () {
        units = new GameObject[Size];
        for (int x = 0; x < Size; x++)
        {
                GameObject go = GameObject.Instantiate(Resources.Load("Unit")) as GameObject;
                Vector3 cord= new Vector3(0,0,0);
                go.transform.position = cord;
                go.transform.parent = gameObject.transform;
                units[x] = go;
        }
    }

    // Update is called once per frame
    void Update () {
	
	}
}
