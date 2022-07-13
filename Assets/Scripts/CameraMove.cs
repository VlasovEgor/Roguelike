using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour //всё хуйня, переделываем
{
    [SerializeField] private PlayerMove _playerMove;

    [SerializeField]
    private float _roomSizeX = 18;
    [SerializeField]
    private float _roomSizeY = 10.25f;

    void Update()
    {
        if(_playerMove.gameObject.transform.position.x>gameObject.transform.position.x+  _roomSizeX/2)
        {
            var cameraPosition = gameObject.transform.position;
            cameraPosition.x += _roomSizeX;
            gameObject.transform.position = cameraPosition;
        }
        if (_playerMove.gameObject.transform.position.y > gameObject.transform.position.y+ _roomSizeY/2)
        {
            var cameraPosition = gameObject.transform.position;
            cameraPosition.y += _roomSizeY;
            gameObject.transform.position = cameraPosition;
        }
        if (_playerMove.gameObject.transform.position.x < gameObject.transform.position.x- _roomSizeX / 2)
        {
            var cameraPosition = gameObject.transform.position;
            cameraPosition.x -= _roomSizeX;
            gameObject.transform.position = cameraPosition;
        }
        if (_playerMove.gameObject.transform.position.y < gameObject.transform.position.y- _roomSizeY / 2)
        {
            var cameraPosition = gameObject.transform.position;
            cameraPosition.y -= _roomSizeY;
            gameObject.transform.position = cameraPosition;
        }
    }
}
