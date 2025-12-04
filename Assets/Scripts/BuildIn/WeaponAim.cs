using UnityEngine;

namespace RenAI
{
    public class WeaponAim : MonoBehaviour
    {
        [SerializeField] private Camera _cam;
        [SerializeField] private float _maxDistance = 1000f;

        private void LateUpdate()
        {
            Ray ray = _cam.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));

            Vector3 targetPoint = ray.GetPoint(_maxDistance);

            transform.LookAt(targetPoint);
        }
    }
}