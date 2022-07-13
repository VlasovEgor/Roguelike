using UnityEngine;

public class RoomsGenerator : MonoBehaviour
{
    [SerializeField]
    private Room _roomPrefab;

    [SerializeField]
    private int _NumberRooms=100;

   

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
            var room = Instantiate(_roomPrefab, new Vector3(info.Position.x * _roomPrefab.GetRoomSizeX(), info.Position.y * _roomPrefab.GetRoomSizeY()), Quaternion.identity);
            room.Setup(info.Dirs);
        }
    }
}
