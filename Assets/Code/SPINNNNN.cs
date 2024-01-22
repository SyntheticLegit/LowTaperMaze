using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinObject : MonoBehaviour
{
    [SerializeField] float minSpeed = 5f; // Degrees per second
    [SerializeField] float maxSpeed = 15f; // Degrees per second

    private Vector3 randomAxis;

    void Start()
    {
        randomAxis = Random.insideUnitSphere;
    }

    void Update()
    {
        transform.Rotate(randomAxis, Random.Range(minSpeed, maxSpeed) * Time.deltaTime);
    }
}
