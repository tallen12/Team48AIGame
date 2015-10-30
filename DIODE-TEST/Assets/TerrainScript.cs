using UnityEngine;
using System.Collections;

public class TerrainScript : MonoBehaviour
{
    public UnitBehavor unit;
    public bool check;
    // Use this for initialization
    void Start()
    {
        check = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnMouseDown()
    {
        if (check)
        {
            unit.move(transform.position.x,transform.position.y);
        }
    }
}