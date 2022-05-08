using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    [SerializeField] private GameObject _cameraObject = null;

    private void Start() {
        _cameraObject.SetActive(true);
    }
}
