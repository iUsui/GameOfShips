using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] private Color _baseColor, _offsetColor, _highlighted, _selected;
    [SerializeField] private Renderer _renderer = null;

    private Color _tileColor;
    private bool _isSelected = false;

    public static event Action<Tile> OnSelected;
    public bool isTaken = false;
    
    public void Init(bool isOffset) {
        _tileColor = isOffset ? _offsetColor : _baseColor;
        _renderer.material.SetColor("_BaseColor", _tileColor);
    }

    private void OnMouseEnter() {
        if (_isSelected) { return; }
        _renderer.material.SetColor("_BaseColor", _highlighted);
    }

    private void OnMouseExit() {
        if (_isSelected) { return; }
        _renderer.material.SetColor("_BaseColor", _tileColor);
    }

    private void OnMouseUp() {
        _isSelected = true;
        _renderer.material.SetColor("_BaseColor", _selected);
        OnSelected?.Invoke(this);
    }

    public void DeselectTile() {
        _isSelected = false;
        OnMouseExit();
    }

}
