using UnityEngine;

public class ManagerScript : MonoBehaviour
{
    public CubeScript CubeGameObject;

    private ICube _cube;
    private float _horizontal;
    private bool _canFlipCube;
    private float _vertical;

    private void Awake() {
        CubeGameObject.TryGetComponent<ICube>(out _cube);
    }

    private void Update()
    {
        _horizontal = Input.GetAxis("Horizontal");
        _vertical = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(_horizontal, 0, _vertical).normalized;

        if (direction != Vector3.zero)
            _cube.FlipCube(direction);
    }
}
