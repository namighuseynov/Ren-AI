using UnityEngine;

namespace RenAI
{
    public class PlayerMovementController : MonoBehaviour
    {
        [SerializeField] private float _inputX;
        [SerializeField] private float _inputY;

        [SerializeField] private float _playerSpeed = 2;

        private void Update()
        {
            Vector3 move = Vector3.zero;
            _inputX = Input.GetAxis("Horizontal");
            _inputY = Input.GetAxis("Vertical");

            float move_magnitude = Mathf.Sqrt(Mathf.Pow(_inputX, 2) + Mathf.Pow(_inputY, 2));
            if (move_magnitude == 0) return;

            move = (transform.forward * (_inputY / move_magnitude) * _playerSpeed * Time.deltaTime) + (transform.right * (_inputX / move_magnitude) * _playerSpeed * Time.deltaTime);

            transform.position = transform.position + move;
        }
    }
}


