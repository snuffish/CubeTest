using UnityEngine;
using UnityEngine.Serialization;

public class MoveCubeScript : MonoBehaviour
{
    public float moveSpeed = 30f;
    public Vector3 rotationAxis = Vector3.up;

    private float moveAmount;
    private bool moveCompleted;

    private void OnEnable()
    {
        moveAmount = 0f;
        moveCompleted = false;
    }

    void Update()
    {
        if (moveCompleted)
            enabled = false;
        
        Rotate90Degrees();
    }

    void Rotate90Degrees()
    {
        float moveStep = moveSpeed * Time.deltaTime;
        float moveRemaining = 90f - moveAmount;

        if (moveRemaining < moveStep)
        {
            moveStep = moveRemaining;
            moveCompleted = true;
        }

        // transform.Translate(rotationAxis, moveStep);
        moveAmount += moveStep;
    }
}
