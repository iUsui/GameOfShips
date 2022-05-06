using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    [SerializeField] private GameObject _player = null;
    [SerializeField] private int _width, _height;
    [SerializeField] private Tile _tilePrefab = null;
    [SerializeField] private Transform _camera = null;

    private Dictionary<Vector3, Tile> _tiles;
    

    private void Start() {
        GenerateGrid();
    }

    private void GenerateGrid()
    {
        
        _tiles = new Dictionary<Vector3, Tile>();
        for (int i = 0; i < _width; i++) {
            for (int j = 0; j < _height; j++) {
               var spawnedTile = Instantiate(_tilePrefab, new Vector3(i, 0f, j), Quaternion.identity);
               spawnedTile.transform.parent = _player.transform;
               spawnedTile.name = $"Tile [{i}, {j}]";
               var isOffset = (i % 2 == 0 && j % 2 != 0) || (i % 2 != 0 && j % 2 == 0);
               spawnedTile.Init(isOffset);


               _tiles[new Vector3(i, 0f, j)] = spawnedTile;
            }
        }
        _camera.position = new Vector3((float)_width/2 -0.5f, 8, (float)_height/2 -0.5f);
    }

    public Tile GetTileAtPosition(Vector3 position) {
        if (_tiles.TryGetValue(position, out Tile tile)) {
            return tile;
        }
        return null;
    }
}
