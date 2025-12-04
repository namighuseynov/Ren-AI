namespace RenAI.Core
{
    /// <summary>
    /// Data from eye-tracking
    /// </summary>
    public sealed class EyeMetrics
    {
        #region Constructors
        public EyeMetrics(float pupilDiameter,
                            float saccade,
                            float fixation,
                            float perclos,
                            float blinkRate)
        {
            _pupilDiameter = pupilDiameter;
            _saccade = saccade;
            _fixation = fixation;
            _perclos = perclos;
            _blinkRate = blinkRate;
        }
        #endregion

        #region Fields 
        private float _pupilDiameter;
        private float _saccade;
        private float _fixation;
        private float _perclos;
        private float _blinkRate;
        #endregion

        #region Properties
        public float PupilDiameter { get { return  _pupilDiameter; } }
        public float Saccade { get { return _saccade; } }
        public float Fixation { get { return _fixation; } }
        public float PERCLOS { get { return _perclos; } }
        public float BlinkRate { get { return _blinkRate; } }
        #endregion

    }
}