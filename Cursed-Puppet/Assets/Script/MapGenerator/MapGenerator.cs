using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    public Node[,] playerNode;
    public Node[,] enmeyNode;

    [SerializeField] GameObject nodeObjPrefab;
    [SerializeField] Transform playerNodeParent;
    [SerializeField] Transform enmeyNodeParent;

    private void Start()
    {
        playerNode = GenerateNode(3, 3, playerNodeParent, -1.25f, new Vector3(3.75f, 0, 1.25f));
        enmeyNode = GenerateNode(3, 3, enmeyNodeParent, 1.25f, new Vector3(-3.75f, 0, -1.25f));
    }

    Node[,] GenerateNode(int width, int height, Transform parent, float distance, Vector3 offset)
    {
        Node[,] nodes = new Node[width, height];

        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                GameObject obj = Instantiate(nodeObjPrefab, parent);
                Vector3 pos = new Vector3(x * distance, 0.01f, y * distance);
                obj.transform.localPosition = pos;
                Node node = new Node(x, y, obj);
                nodes[x, y] = node;
            }
        }

        parent.position = parent.position + offset;

        return nodes;
    }

}

