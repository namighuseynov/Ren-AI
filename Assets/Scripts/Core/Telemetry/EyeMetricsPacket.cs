using System;

namespace RenAI.Core.Telemetry
{
    [Serializable]
    public class EyeMetricsPacket
    {
        public double t;
        public float blink_rate;
        public float sacc_rate;
        public float fix_med_ms;
        public float perclos;

        public float blink_n;
        public float sacc_n;
        public float fix_n;
        public float perclos_n;

        public string fix_term;
        public string sacc_term;
        public string blink_term;
        public string perclos_term;

        public float cl;
        public string cl_term;

        public float stress;
        public string stress_term;

        public float fatigue;
        public string fatigue_term;

        public int calib_ready;
    }
}

