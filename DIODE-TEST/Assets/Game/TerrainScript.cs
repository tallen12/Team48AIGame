using UnityEngine;
using System.Collections;
using System;

public class TerrainScript : MonoBehaviour
{
    public UnitBehavor unit;
    public MapScript map;
    public bool check;
    private double _x;
    private double _y;
    public double x { get { return _x; } }
    public double y { get { return _y; } }

    // Use this for initialization
    void Start()
    {
        check = false;
    }
    public void init(double xin,double yin)
    {
        _x = xin;
        _y = yin;
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnMouseDown()
    {
        map.clicked(this);
    }
}