using UnityEngine;
using System;

public class UnitServer
{
    private int _id;
    public int ID
    {
        get
        {
            return _id;
        }
    }
    private Vector2 _pos;
    public Vector2 position
    {
        get
        {
            return _pos;
        }
    }
    private int _combat;
    public int combatStat
    {
        get
        {
            return _combat;
        }
    }
    private int _movement;
    public int movementStat
    {
        get
        {
            return _movement;
        }
    }
    private int _sight;
    public int sightStat
    {
        get
        {
            return _sight;
        }
    }
    private PlayerServer _player;
    public PlayerServer player
    {
        get
        {
            return _player;
        }
    }

    public UnitServer(int id,Vector2 currentPos, int combatStats, int movementStats, int sigthStats, PlayerServer playerId)
    {
        _id = id;
        _pos = currentPos;
        _combat = combatStats;
        _movement = movementStats;
        _sight = sigthStats;
        _player = playerId;
    }
}
