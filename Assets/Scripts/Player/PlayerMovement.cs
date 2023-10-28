using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private List<Player> _players;
    public float _speed;

    [SerializeField] private Board _board = new Board();
    [SerializeField] private Text _text;

    Vector2 _currentPos;
    Vector2 _nextPos;

    bool _isMoving;
    bool _turnStarted;

    int _currentplayer = 0;

    void Start()
    {
        _board.InitPosition();
        _text.text = "Press 'Space' to start turn";
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            _turnStarted = true;
        }
        for (int i = 0; i < _board.GetRoads().Count; i++)
        {
            if (_players[_currentPlayer].GetTilePositions() == _board.GetRoads()[i].GetEndTail())
            {
                TravelRoad(i);
            }
        }
    }

    void TravelRoad(int slot)
    {
        _players[_currentPlayer].GetTilePositions(_board.GetRoads()[slot].GetStartHead() - 1);
    }
}
