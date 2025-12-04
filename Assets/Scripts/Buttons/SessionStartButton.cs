using RenAI.Events;
using UnityEngine;

namespace RenAI.Buttons
{
    public class SessionStartButton : MonoBehaviour
    {
        private void Start()
        {
            EventBus.Instance.Subscribe<OnSessionStartEvent>(OnSessionStart);
            NewSession();
        }
        private void NewSession()
        {
            // Some code

            EventBus.Instance.Publish(new OnSessionStartEvent());
        }

        private void OnSessionStart(OnSessionStartEvent e)
        {
            Debug.Log($"Session was successfully started at: {e.At}");
        }
    }
}