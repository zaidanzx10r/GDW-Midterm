using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    [SerializeField] private Transform _initialTransform;
    [SerializeField] private List<VirusSquare> _virusSquares;
    [SerializeField] private List<Road> _roads;

    Vector2[] _tilePositions = new Vector2[100];

    public List<VirusSquare> GetVirusSquares()
    {
        return _virusSquares;
    }

    public List<Road> GetRoads()
    {
        return _roads;
    }

    public Vector2[] GetTilePositions()
    {
        return _tilePositions;
    }

        public void InitPosition()
    {
        _tilePositions[0] = new Vector2(_initialTransform.position.x, _initialTransform.position.y);
    }

}
