using UnityEngine;

namespace RenAI
{
    public sealed class CameraController : MonoBehaviour
    {
        #region Fields
        [Header("Mouse params")]
        [SerializeField] private float _clampY;
        [SerializeField] private float _sensivityX;
        [SerializeField] private float _sensivityY;
        [SerializeField] private float _mouseX;
        [SerializeField] private float _mouseY;
        [SerializeField] private float _pitch;
        [SerializeField] private float _yaw;

        #endregion

        #region Properties
        public float Yaw { get { return _yaw; } }
        public float Pitch { get { return _pitch; } }
        #endregion

        private void LateUpdate()
        {
            _mouseX = Input.GetAxis("Mouse X");
            _mouseY = Input.GetAxis("Mouse Y");

            float _deltaRotX = _mouseX * _sensivityX * Time.deltaTime;
            float _deltaRotY = _mouseY * _sensivityY * Time.deltaTime;

            _pitch -= _deltaRotY;
            _yaw += _deltaRotX;

            _pitch = Mathf.Clamp(_pitch, -_clampY, _clampY);

            transform.rotation = Quaternion.Euler(new Vector3(_pitch, _yaw, 0));

        }
    }
}


