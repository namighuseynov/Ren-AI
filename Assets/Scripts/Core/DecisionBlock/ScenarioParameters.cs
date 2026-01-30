namespace RenAI.Core.Expert
{
    public struct ScenarioParameters
    {
        public int Targets;     // N_tgt [1,5]
        public float Fog;       // [0,1]
        public float Rain;      // [0,1]
        public float Wind;      // [0,W_max]
        public float TargetSpeed; // norm
    }
}