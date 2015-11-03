using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameServer : MonoBehaviour {
    // Use this for initialization
    private List<PlayerServer> players;
    private Dictionary<PlayerServer,List<UnitServer>> unitList;
    private int numPlayers=2;
    private MapServer map;
    void Start()
    {
        map = new MapServer(31, 31);
        unitList= new Dictionary<PlayerServer, List<UnitServer>>();
        for(int i = 0; i < numPlayers; i++)
        {
            PlayerServer player = new PlayerServer(i);
            List<UnitServer> units = new List<UnitServer>();
            players.Add(player);
            for(int u = 0; u < 5; u++)
            {
                units.Add(new UnitServer(u, new Vector2(14+u,16), 1, 1, 2, player));
            }
            unitList[player] = units;
        }
    }
	
	// Update is called once per frame
	void Update ()
    {

    }
    public string read(string message)
    {

        return "";
    }
}
