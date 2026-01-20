using System.Net.Sockets;
using System.Net;
using System.Text;
using UnityEngine;

namespace RenAI.Core.Telemetry
{
    public class EyeMetricsReceiver : MonoBehaviour
    {
        public int port = 5005;

        private UdpClient udp;
        private IPEndPoint ep;

        public EyeMetricsPacket Latest;
        public bool HasPacket;

        void Start()
        {
            ep = new IPEndPoint(IPAddress.Any, 0);
            udp = new UdpClient(port);
            udp.Client.ReceiveTimeout = 1;
        }

        void Update()
        {
            try
            {
                if (udp.Available > 0)
                {
                    byte[] data = udp.Receive(ref ep);
                    string json = Encoding.UTF8.GetString(data);

                    Latest = JsonUtility.FromJson<EyeMetricsPacket>(json);
                    HasPacket = true;
                }
            }
            catch {}

            if (HasPacket)
            {
            }
        }

        void OnApplicationQuit()
        {
            udp?.Close();
        }
    }
}

