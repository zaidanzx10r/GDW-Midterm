using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusSquare : MonoBehaviour
{
    Vector2 _position;
    [SerializeField] private int _currentPos;

    public Vector2 SetCurrentPosition()
    {
        return _position;
    }

    public int GetPosition()
    {
        return _currentPos;
    }
}
