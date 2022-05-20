using System.Collections;
using System.Collections.Generic;
using UnityEngine;



    public enum NodeType    //Defining two different types of node constants
    {
        Open = 0,
        Blocked = 1
    }


public class Node
{
    public NodeType nodeType = NodeType.Open; //Default node, which is open

    public int xIndex = -1; // Index of rows and columns for two dimensional array
    public int yIndex = -1;

    public Vector3 position; //Position of the node based on the index

    public List<Node> neighbors = new List<Node>(); // List of neighbours

    public Node previous = null; // Previous node
    // Constructor to initialize the values
    public Node(int xIndex, int yIndex, NodeType nodeType)
    {
        this.xIndex = xIndex;
        this.yIndex = yIndex;
        this.nodeType = nodeType;
    }

    public void Reset() // Reset the nodes in the graph
    {
        previous = null;
    }
}

