using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour
{
    public enum OpeningType
    {
        Wall,
        Door
    }

    [SerializeField]
    private Openings _doors;

    [SerializeField]
    private Openings _walls;

   [SerializeField]
   private float _roomSizeX = 18;
   [SerializeField]
   private float _roomSizeY = 10.25f;

    public float GetRoomSizeX() { return _roomSizeX; }
    public float GetRoomSizeY() { return _roomSizeY; }

    public void Setup(List<Vector2Int> config)
    {
       foreach(var wall in _walls.GetOpenings())
       {
            bool contains = config.Contains(wall.OffsetFromCenter);
            wall.Door.SetActive(!contains);
       }
    }
}
