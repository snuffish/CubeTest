using System;
using UnityEngine;

[RequireComponent(typeof(RotateCubeScript))]
public class CubeScript : MonoBehaviour, ICube
{
    private RotateCubeScript rotateCube;

    private void Start()
    {
        rotateCube = GetComponent<RotateCubeScript>();
    }

    public void FlipCube(Vector3 direction)
    {
        GetComponent<RotateCubeScript>().enabled = true;
        // var cross = Vector3.Cross(direction, Vector3.up);
        // var flipDegrees = cross * 90;
        //
        // transform.localRotation *= Quaternion.Euler(flipDegrees);

        // transform.position += direction;
    }
}