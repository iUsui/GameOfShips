using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    [SerializeField] private int _width, _height;
    [SerializeField] private Tile _tilePrefab = null;
    [SerializeField] private Transform _camera = null;

    private void Start() {
        GenerateGrid();
    }

    private void GenerateGrid()
    {
        for (int i = 0; i < _width; i++) {
            for (int j = 0; j < _height; j++) {
               var spawnTile = Instantiate(_tilePrefab, new Vector3(i, 0f, j), Quaternion.identity);
               spawnTile.name = $"Tile [{i}, {j}]";
               var isOffset = (i % 2 == 0 && j % 2 != 0) || (i % 2 != 0 && j % 2 == 0);
               spawnTile.Init(isOffset);
            }
        }
        _camera.position = new Vector3((float)_width/2 -0.5f, 8, (float)_height/2 -0.5f);
    }
}
