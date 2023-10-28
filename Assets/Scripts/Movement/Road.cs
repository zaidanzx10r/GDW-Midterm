using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour
{
    [SerializeField] private int _startHead;
    [SerializeField] private int _endTail;

    public Road(int startHead, int endTail)
    {
        _startHead = startHead;
        _endTail = endTail;
    }

    public int GetStartHead()
    {
        return _startHead;
    }

    public int GetEndTail()
    {
        return _endTail;
    }
}
