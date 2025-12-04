using UnityEngine;

namespace RenAI.Core.Helpers
{
    public sealed class Timer
    {
        private static TimerBehaviour _runner;

        public float Duration { get; private set; }
        public bool IsRunning { get; private set; }
        public bool Repeat { get; private set; }

        private System.Action _onComplete;
        private bool _useUnscaled;

        public Timer(
            float duration, 
            System.Action onComplete = null, 
            bool repeat = false, 
            bool unscaled = false
            )
        {
            Duration = duration;
            _onComplete = onComplete;
            Repeat = repeat;
            _useUnscaled = unscaled;

            EnsureRunnerExists();
        }
        private void EnsureRunnerExists()
        {
            if (_runner != null) return;

            GameObject go = new GameObject("[TIMER_RUNNER]");
            Object.DontDestroyOnLoad(go);
            _runner = go.AddComponent<TimerBehaviour>();
        }
        public void Start()
        {
            IsRunning = true;
            _runner.StartCoroutine(Run());
        }

        public void Stop()
        {
            IsRunning = false;
        }

        private System.Collections.IEnumerator Run()
        {
            do
            {
                float t = 0f;

                while (t < Duration && IsRunning)
                {
                    t += _useUnscaled ? Time.unscaledDeltaTime : Time.deltaTime;
                    yield return null;
                }

                if (!IsRunning)
                    yield break;

                _onComplete?.Invoke();

            } while (Repeat);
        }
    }
}


