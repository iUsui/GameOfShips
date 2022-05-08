using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] private GameObject _playerBasePlatform = null;

    private void Start() {
        Instantiate(_playerBasePlatform, transform.position, transform.rotation, transform);
    }
}
