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

    public void Setup(List<Vector2Int> config)
    {
       foreach(var wall in _walls.GetOpenings())
       {
            bool contains = config.Contains(wall.OffsetFromCenter);
            wall.Door.SetActive(!contains);
       }

    }
}
