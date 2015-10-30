using UnityEngine;
using System.Collections;

public class UnitScript : MonoBehaviour {
    GameObject[,] units;
    private int Size=1;
    // Use this for initialization
    void Start () {
        units = new GameObject[31, 31];
        for (int x = 0; x < Size; x++)
        {
            for (int y = 0; y < Size; y++)
            {
                GameObject go = GameObject.Instantiate(Resources.Load("Unit")) as GameObject;
                go.transform.position = new Vector3(0, 0, 0);
                go.transform.parent = gameObject.transform;
                units[x, y] = go;
            }
        }
    }

    // Update is called once per frame
    void Update () {
	
	}
}
