using UnityEngine;

public class RoomsGenerator : MonoBehaviour
{
    [SerializeField]
    private Room _roomPrefab;

    [SerializeField]
    private int _NumberRooms=100;

    [SerializeField]
    private float _roomSizeX=18;
    [SerializeField]
    private float _roomSizeY=10.25f;

    private void Start()
    {
        Generate();
    }

    private void Generate()
    {
        Graph graph = new Graph();
        var infos = graph.Generate(_NumberRooms);

        foreach (var info in infos)
        {
            var room = Instantiate(_roomPrefab, new Vector3(info.Position.x * _roomSizeX, info.Position.y * _roomSizeY), Quaternion.identity);
            room.Setup(info.Dirs);
        }
    }
}
