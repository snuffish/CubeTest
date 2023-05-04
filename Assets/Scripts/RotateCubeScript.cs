using UnityEngine;

public class RotateCubeScript : MonoBehaviour
{
    public float rotationSpeed = 30f;
    public Vector3 rotationAxis = Vector3.up;

    private float rotationAmount;
    private bool rotationCompleted;

    private void OnEnable()
    {
        rotationAmount = 0f;
        rotationCompleted = false;
    }

    void Update()
    {
        if (rotationCompleted)
            enabled = false;
        
        Rotate90Degrees();
    }

    void Rotate90Degrees()
    {
        Physics.Raycast(transform.position, transform.forward, out RaycastHit hit)
        float rotationStep = rotationSpeed * Time.deltaTime;
        float remainingRotation = 90f - rotationAmount;

        if (remainingRotation < rotationStep)
        {
            rotationStep = remainingRotation;
            rotationCompleted = true;
        }

        transform.Rotate(rotationAxis, rotationStep);
        rotationAmount += rotationStep;
    }
}
