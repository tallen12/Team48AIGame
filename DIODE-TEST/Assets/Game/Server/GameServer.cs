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
        players = new List<PlayerServer>();
        Debug.Log("Server Start");
        for(int i = 0; i < numPlayers; i++)
        {
            PlayerServer player = new PlayerServer(i);
            List<UnitServer> units = new List<UnitServer>();
            players.Add(player);
            for(int u = 0; u < 5; u++)
            {
                units.Add(new UnitServer(u, new Vector2(14+u,16-2*i), 1, 1, 2, player));
            }
            unitList[player] = units;
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
    }
    public List<UnitServer> getUnits(int playerId)
    {
        for(int i=0;i<players.Count;i++)
        {
            PlayerServer p = players[i];
            if (p.playerId == playerId)
            {
                return unitList[p];
            }
        }
        return null;
    }
}
