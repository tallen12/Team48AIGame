using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UnitScript : MonoBehaviour
{
    GameObject[] units;
    public MapScript map;
    public PlayerScript player;
    private int Size = 1;
    private UnitBehavor _clicked;
    public UnitBehavor Clicked
    {
        get
        {
            return _clicked;
        }
    }

    // Use this for initialization
    void Start()
    {
        List<UnitServer> unitServer = player.getUnitList();
        Size = unitServer.Count;
        units = new GameObject[Size];
        for (int x = 0; x < Size; x++)
        {
            GameObject go = GameObject.Instantiate(Resources.Load("Unit")) as GameObject;
            UnitBehavor script = go.GetComponent<UnitBehavor>();
            script.player = this;
            script.id = unitServer[x].ID;
            Vector3 cord = map.convertMapToWorldCord((int)unitServer[x].position.x, (int)unitServer[x].position.y);
            go.transform.position = cord;
            go.transform.parent = gameObject.transform;
            units[unitServer[x].ID] = go;
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
    public void clicked(UnitBehavor script)
    {
        _clicked = script;
        player.unitClicked();
    }
}
