using UnityEngine;
using System.Collections;

public class MapServer {
    public Vector2 dim
    {
        set;
        get;
    }
    public MapServer(int x, int y)
    {
        dim = new Vector2(x, y);
        for (int i = 0; i < dim.x; i++)
        {
            for(int j = 0; j < dim.y; j++)
            {

            }
        }
    }
}
