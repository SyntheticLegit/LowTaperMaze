using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PointGenerator : MonoBehaviour
{
    [SerializeField] int numberOfPoints = 10; // Number of points to generate
    [SerializeField] float minX = -10f; // Minimum X position
    [SerializeField] float maxX = 10f; // Maximum X position
    [SerializeField] float minY = -5f; // Minimum Y position
    [SerializeField] float maxY = 5f; // Maximum Y position

    // Use a List to store the generated points
    List<Vector3> points = new List<Vector3>();

    private void Start()
    {
        // Generate random points
        for (int i = 0; i < numberOfPoints; i++)
        {
            float x = Random.Range(minX, maxX);
            float y = Random.Range(minY, maxY);
            float z = 0f; // Replace with desired Z value

            Vector3 point = new Vector3(x, y, z);
            points.Add(point);

            // Optionally, spawn a GameObject at each point
            //GameObject gameObj = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            //gameObj.transform.position = point;
        }
    }

    // Access the generated points through public methods or properties
    public List<Vector3> GetPoints()
    {
        return points;
    }

    public int GetNumberOfPoints()
    {
        return points.Count;
    }
}
