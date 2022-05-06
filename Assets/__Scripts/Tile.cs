using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] private Color _baseColor, _offsetColor, _highlighted;
    [SerializeField] private Renderer _renderer = null;

    private Color _tileColor;
    public void Init(bool isOffset) {
        _tileColor = isOffset ? _offsetColor : _baseColor;
        _renderer.material.SetColor("_BaseColor", _tileColor);
    }

    private void OnMouseEnter() {
        _renderer.material.SetColor("_BaseColor", _highlighted);
    }

    private void OnMouseExit() {
        _renderer.material.SetColor("_BaseColor", _tileColor);
    }

}
