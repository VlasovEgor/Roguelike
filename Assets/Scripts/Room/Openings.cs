using System.Collections.Generic;
using UnityEngine;

public class Openings : MonoBehaviour
{
    [System.Serializable]
    public class Opening
    {
        public Vector2Int OffsetFromCenter;
        public GameObject Door;
    }

    [SerializeField]
    private Opening top;
    [SerializeField]
    private Opening right;
    [SerializeField]
    private Opening bottom;
    [SerializeField]
    private Opening left;

    private List<Opening> list;

    public List<Opening> GetOpenings()
    {
        if (list == null)
        {
            list = new List<Opening>()
            {
                top,
                right,
                bottom,
                left
            };
        }

        return list;
    }

}
