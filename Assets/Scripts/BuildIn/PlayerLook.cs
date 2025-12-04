using RenAI;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    [SerializeField] private CameraController _camController;

    private void Start()
    {
        if (!_camController) _camController = FindAnyObjectByType<CameraController>();
    }
    private void LateUpdate()
    {
        Vector3 lookRotation = new Vector3(0, _camController.Yaw, 0);
        transform.rotation = Quaternion.Euler(lookRotation);
    }
}