using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SelectionManager : MonoBehaviour, IPointerClickHandler
{
    public List<Tile> _selectedTiles = new List<Tile>();

    private void OnEnable() {
        Tile.OnSelected += HandleOnTileSelected;
    }

    private void OnDisable() {
        Tile.OnSelected -= HandleOnTileSelected;
    }

    private void HandleOnTileSelected(Tile tile) {
        _selectedTiles.Add(tile);
    }

    public void OnPointerClick(PointerEventData eventData) {
        if (eventData.button == PointerEventData.InputButton.Right) {
            foreach (Tile tile in _selectedTiles) {
                tile.DeselectTile();
            }
            _selectedTiles.Clear();
        }
    }
}
