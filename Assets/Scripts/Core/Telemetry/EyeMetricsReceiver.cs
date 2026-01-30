using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using UnityEngine;

namespace RenAI.Core.Telemetry
{
    public class EyeMetricsReceiver : MonoBehaviour
    {
        [Header("Port")]
        public int port = 5005;

        [Header("Timeout settings")]
        [SerializeField] private float noDataTimeout = 1.0f; // seconds

        [Header("Logging")]
        [SerializeField] private bool logConnectionEvents = true;

        private UdpClient udp;
        private IPEndPoint ep;

        public bool HasPacket { get; private set; }

        private float _lastPacketRealtime;
        private bool _lostEventRaised;
        private bool _socketRunning;

        // Events
        public event Action<EyeMetricsPacket> OnPacket;
        public event Action OnConnectionLost;
        public event Action OnConnectionRestored;

        [SerializeField] private EyeMetricsPacket _latest;

        public EyeMetricsPacket Latest { get { return _latest; } private set { _latest = value; } }
        public bool HasEverReceived { get; private set; }
        public bool IsReceivingNow { get; private set; }

        #region Unity event handlers

        private void Awake()
        {
            Latest = default;
            HasPacket = false;
            HasEverReceived = false;
            IsReceivingNow = false;

            _lostEventRaised = false;
            _socketRunning = false;

            _lastPacketRealtime = Time.realtimeSinceStartup;
        }

        private void OnEnable()
        {
            StartReceiver();
        }

        private void OnDisable()
        {
            StopReceiver();
        }

        private void OnApplicationQuit()
        {
            StopReceiver();
        }

        #endregion

        private void Update()
        {
            try
            {
                if (udp != null && udp.Available > 0)
                {
                    byte[] data = udp.Receive(ref ep);
                    string json = Encoding.UTF8.GetString(data);

                    Latest = JsonUtility.FromJson<EyeMetricsPacket>(json);

                    HasEverReceived = true;
                    HasPacket = true;

                    _lastPacketRealtime = Time.realtimeSinceStartup;

                    if (!IsReceivingNow)
                    {
                        IsReceivingNow = true;
                        _lostEventRaised = false;

                        if (logConnectionEvents)
                            Debug.Log($"[EyeMetricsReceiver] Connection restored (port={port}).");

                        OnConnectionRestored?.Invoke();
                    }

                    OnPacket?.Invoke(Latest);
                }
            }
            catch (SocketException) {}
            catch (Exception) {}

            if (HasEverReceived)
            {
                float age = Time.realtimeSinceStartup - _lastPacketRealtime;

                if (age > noDataTimeout && !_lostEventRaised)
                {
                    HasPacket = false;
                    IsReceivingNow = false;
                    _lostEventRaised = true;

                    if (logConnectionEvents)
                        Debug.LogWarning($"[EyeMetricsReceiver] No UDP data for {noDataTimeout:0.###}s (port={port}).");

                    OnConnectionLost?.Invoke();
                }
            }
            else
            {
                HasPacket = false;
            }
        }

        #region System methods

        private void StartReceiver()
        {
            if (_socketRunning) return;

            try
            {
                ep = new IPEndPoint(IPAddress.Any, 0);

                udp = new UdpClient(port);
                udp.EnableBroadcast = true;

                udp.Client.ReceiveTimeout = 1;

                _socketRunning = true;

                if (logConnectionEvents)
                    Debug.Log($"[EyeMetricsReceiver] UDP receiver started (bind=Any:{port}).");
            }
            catch (Exception ex)
            {
                _socketRunning = false;
                SafeCloseUdp();

                Debug.LogError($"[EyeMetricsReceiver] Failed to start UDP receiver on port={port}. {ex.GetType().Name}: {ex.Message}");
            }
        }

        private void StopReceiver()
        {
            if (!_socketRunning) return;

            _socketRunning = false;

            SafeCloseUdp();

            HasPacket = false;
            IsReceivingNow = false;

            if (logConnectionEvents)
                Debug.Log($"[EyeMetricsReceiver] UDP receiver stopped (port={port}).");
        }

        private void SafeCloseUdp()
        {
            try { udp?.Close(); } catch { }
            try { udp?.Dispose(); } catch { }
            udp = null;
        }

        #endregion
    }
}
