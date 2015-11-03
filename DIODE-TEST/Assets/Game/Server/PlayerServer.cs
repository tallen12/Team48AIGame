using UnityEngine;
using System.Collections;

public class PlayerServer {
    private int _player;
    public int playerId
    {
        get
        {
            return _player;
        }
    }
    public PlayerServer(int id)
    {
        _player = id;
    }
}
