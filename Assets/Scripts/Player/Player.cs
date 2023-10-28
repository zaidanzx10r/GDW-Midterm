using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Player : MonoBehaviour
{
    Vector2 _position;
    Transform _trans;
    [SerializeField] private int speed;

    int _currentPos = 1;

    bool _isPlayerTurn;

    private Rigidbody2D _rb;
    private Vector2 _moveDirection;

    // Start is called before the first frame update
    void Start()
    {
        InputManager.Init(this);
        InputManager.Gamemode();

        _rb = GetComponent<Rigidbody2D>();

        _trans = GetComponent<Transform>();

        _position = _trans.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.rotation * (speed * Time.deltaTime * _moveDirection);
        _trans.position = _position;
    }

    public void SetMovementDirection(Vector3 newDirection)
    {
        _moveDirection = newDirection;
    }

    public Vector2 GetPosition()
    {
        return _position;
    }

    public void SetPosition(Vector2 position)
    {
        _position = position;
    }

    public bool GetIsPlayerTurn()
    {
        return _isPlayerTurn;
    }

    public void SetIsPlayerTurn(bool isTurn)
    {
        _isPlayerTurn = isTurn;
    }

    public int GetCurrentPosition()
    {
        return _currentPos;
    }

    public void SetCurrentPosition(int currentPosition)
    {
        _currentPos = currentPosition;
    }
}
